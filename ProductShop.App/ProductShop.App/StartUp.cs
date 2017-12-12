using Newtonsoft.Json;
using ProductShop.Models;
using System;
using System.IO;
using ProductShop.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ProductShop.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CategoriyByProductXml();

        }

        public static void UsersAndProductsXml()
        {
            using (var context = new ProductShopContext())
            {
                var users = context.Users
                    .Where(b => b.SoldProducts.Any())
                    .OrderByDescending(e => e.SoldProducts.Count())
                    .ThenBy(e => e.LastName)
                    .Select(x => new
                    {
                        firstName = x.FirstName,
                        lastName = x.LastName,
                        age = x.Age,
                        soldProdcuts = x.SoldProducts.Select(e => new
                        {
                            count = e.Seller.SoldProducts.Count,
                            name = e.Name,
                            price = e.Price
                        })
                    })

                    .ToList();

                var xDoc = new XDocument(new XElement("users", new XAttribute("count", users.Count())));

                foreach (var u in users)
                {
                    List<XElement> list = new List<XElement>();

                    foreach (var p in u.soldProdcuts)
                    {
                        var products = new XElement("product",
                                        new XAttribute("name", p.name), new XAttribute("price", p.price));

                        list.Add(products);
                    }
                    xDoc.Root.Add(new XElement("user",
                                                    new XAttribute("first-name", u.firstName ?? "Empty"),
                                                    new XAttribute("last-name", u.lastName),
                                                    new XAttribute("age", u.age ?? 0),
                                                         new XElement("sold-products",
                                                         new XAttribute("count", u.soldProdcuts.Count()), list)));

                }

                var xmlStr = xDoc.ToString();

                File.WriteAllText("UsersAndProductsXml.xml", xmlStr);

            }
        }

        public static void CategoriyByProductXml()
        {
            using (var context = new ProductShopContext())
            {
                var categories = context.Categories
                    .OrderByDescending(c => c.Products.Count)
                    .Select(c => new
                    {
                        Category = c.Name,
                        ProductsCount = c.Products.Count,
                        AveragePrice = c.Products.Select(p => p.Product.Price).Average(),
                        TotalRevenue = c.Products.Select(p => p.Product.Price).Sum()

                    }).ToArray();

                var xDoc = new XDocument(new XElement("categories"));

                foreach (var c in categories)
                {
                    xDoc.Root.Add(new XElement("category", new XAttribute("name", c.Category),
                        new XElement("product-counte", c.ProductsCount),
                        new XElement("average-price", c.AveragePrice),
                        new XElement("total-revenue", c.TotalRevenue)));
                }

                var xmlstr = xDoc.ToString();
                File.WriteAllText("CategoriyByProductXml.xml", xmlstr);
            }
        }

        static void SoldProductsXml()
        {
            using (var context = new ProductShopContext())
            {
                var users = context.Users
                    .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                        u.FirstName,
                        u.LastName,
                        SoldProduct = u.SoldProducts.Select(p => new
                        {
                            p.Name,
                            p.Price
                        })
                    }).ToArray();

                var xDoc = new XDocument(new XElement("users"));

                foreach (var u in users)
                {
                   
                    var list = new List<XElement>();
                    
                    foreach (var p in u.SoldProduct)
                    {
                        var product = new XElement("product", new XElement("name", p.Name), new XElement("price", p.Price));

                        list.Add(product);
                    }

                    xDoc.Root.Add(new XElement("user", new XAttribute("first-name", u.FirstName ?? "Empty"), 
                        new XAttribute("last-name", u.LastName), new XElement("sold-productss", list)));

                }

                var xmlStr = xDoc.ToString();

                File.WriteAllText("SoldProducts.xml", xmlStr);
            }
        }

        static void ProductsInRangeXml()
        {
            using (var context = new ProductShopContext())
            {
                var products = context.Products
                    .Where(p => p.BuyerId != null && p.Price >= 1000 && p.Price <= 2000)
                    .OrderBy(p => p.Price)
                    .Select(p => new
                    {
                        p.Name,
                        p.Price,
                        Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                    }).ToArray();

                var xdoc = new XDocument(new XElement("products"));

                foreach (var p in products)
                {
                    xdoc.Root.Add(new XElement("product", 
                        new XElement("name", p.Name), 
                        new XElement("price", p.Price), 
                        new XElement("buyer", p.Buyer)));
                }

                var xmlStr = xdoc.ToString();

                File.WriteAllText("ProductsInRange.xml", xmlStr);
            }
        }

        static void ImportProductsXml()
        {
            var xmlStr = File.ReadAllText("Files/products.xml");

            var xml = XDocument.Parse(xmlStr);

            var elemets = xml.Root.Elements();

            using (var context = new ProductShopContext())
            {
                var catProducts = new List<CategoryProduct>();

                var userIds = context.Users.Select(u => u.UserId).ToArray();
                var categoryIds = context.Categories.Select(u => u.CategoryId).ToArray();
                var rnd = new Random();

                foreach (var e in elemets)
                {
                    var name = e.Element("name").Value;
                    var price = decimal.Parse(e.Element("price").Value);

                    var index = rnd.Next(0, userIds.Length);
                    var sellerId = userIds[index];

                    int? buyerId = sellerId;
                    while (buyerId == sellerId)
                    {
                        var buyerindex = rnd.Next(0, userIds.Length);
                        buyerId = userIds[buyerindex];
                    }

                    if (buyerId - sellerId < 6 && buyerId - sellerId > 0)
                    {
                        buyerId = null;
                    }

                    var product = new Product
                    {
                        Name = name,
                        Price = price,
                        SellerId = sellerId,
                        BuyerId = buyerId
                    };

                    var catIndex = rnd.Next(0, categoryIds.Length);
                    var categoryId = categoryIds[catIndex];

                    var catProduct = new CategoryProduct
                    {
                        CategoryId = categoryId,
                        Product = product

                    };

                    catProducts.Add(catProduct);
                }

                context.AddRange(catProducts);
                context.SaveChanges();
            }
        }

        static void ImportCategoriesXml()
        {
            var xmlStr = File.ReadAllText("Files/categories.xml");

            var xml = XDocument.Parse(xmlStr);

            var elemets = xml.Root.Elements();

            var categories = new List<Categorie>();

            foreach (var e in elemets)
            {
                var category = new Categorie
                {
                    Name = e.Element("name").Value
                };

                categories.Add(category);
            }

            using (var db = new ProductShopContext())
            {
                db.AddRange(categories);

                db.SaveChanges();
            }
        }

        static void ImportUsersXml()
        {
            var xmlStr = File.ReadAllText("Files/users.xml");

            var xml = XDocument.Parse(xmlStr);

            var elemets = xml.Root.Elements();

            var users = new List<User>();

            foreach (var e in elemets)
            {
                var firstName = e.Attribute("firstName")?.Value;
                var lastName = e.Attribute("lastName").Value;

                int? age = null;

                if (e.Attribute("age") != null)
                {
                    age = int.Parse(e.Attribute("age").Value);
                }

                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                users.Add(user);
            }

            using (var db = new ProductShopContext())
            {
                db.Users.AddRange(users);

                db.SaveChanges();
            }
        }

        static void UsersAndProducts()
        {
            using (var context = new ProductShopContext())
            {
                var users = context.Users
                    .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                    .OrderBy(u => u.SoldProducts.Count)
                    .ThenBy(u => u.LastName)
                    .Select(u => new
                    {
                        u.FirstName,
                        u.LastName,
                        u.Age,
                        SoldProducts = u.SoldProducts.Select(p => new
                        {
                            p.Name,
                            p.Price
                        })
                    }).ToArray();

                var jsonStr = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

                File.WriteAllText("UsersAndProducts", jsonStr);
            }
        }

        static void CategorieByProductCount()
        {
            using (var context = new ProductShopContext())
            {
                var categories = context.Categories
                    .OrderBy(c => c.Name)
                    .Select(c => new
                    {
                        Category = c.Name,
                        ProductsCount = c.Products.Count,
                        AveragePrice = c.Products.Select(p => p.Product.Price).Average(),
                        TotalRevenue = c.Products.Select(p => p.Product.Price).Sum()

                    }).ToArray();

                var jsonStr = JsonConvert.SerializeObject(categories, Formatting.Indented);

                File.WriteAllText("CategoriesByProduct.json", jsonStr);
            }
        }

        static void SuccessfullySoldProducts()
        {
            using (var context = new ProductShopContext())
            {
                var users = context.Users
                    .Where(u => u.SoldProducts.Any(p => p.BuyerId != null))
                    .OrderBy(u => u.LastName)
                    .ThenBy(u => u.FirstName)
                    .Select(u => new
                    {
                        u.FirstName,
                        u.LastName,
                        SoldProducts = u.SoldProducts.Select(p => new {
                            p.Name,
                            p.Price,
                            BuyerFirstName = p.Buyer.FirstName,
                            BuyerLastName = p.Buyer.LastName
                        })
                    }).ToArray();

                var jsonStr = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });

                File.WriteAllText("SuccessfullySoldProducts.json", jsonStr);
            }
        }

        static void ExportProductsInRangeInJson()
        {
            using (var context = new ProductShopContext())
            {
                var products = context.Products
                    .Where(p => p.Price >= 500 && p.Price <= 1000)
                    .OrderBy(p => p.Price)
                    .Select(p => new
                    {
                        p.Name,
                        p.Price,
                        Seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                    }).ToArray();

                var jsonStr = JsonConvert.SerializeObject(products, Formatting.Indented);

                File.WriteAllText("PricesInRange.json", jsonStr);
            }
        }

        static void SetCategoryProducts()
        {
            using (var context = new ProductShopContext())
            {
                var productIds = context.Products.AsNoTracking().Select(p => p.ProductId).ToArray();
                var categoryIds = context.Categories.AsNoTracking().Select(c => c.CategoryId).ToArray();

                var rnd = new Random();

                var categoryProducts = new List<CategoryProduct>();

                foreach (var p in productIds)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var index = rnd.Next(0, categoryIds.Length);
                        while (categoryProducts.Any(cp => cp.ProductId == p && cp.CategoryId == categoryIds[index]))
                        {
                            index = rnd.Next(0, categoryIds.Length);
                        }

                        var catPr = new CategoryProduct
                        {
                            ProductId = p,
                            CategoryId = categoryIds[index]
                        };

                        categoryProducts.Add(catPr);
                    }
                }
                context.CatecoryProducts.AddRange(categoryProducts);

                context.SaveChanges();
            }
        }

        static string ImportProductFromJson()
        {
            var products = ImportJson<Product>("Files/products.json");

            var rnd = new Random();

            using (var db = new ProductShopContext())
            {
                var userIds = db.Users.Select(u => u.UserId).ToArray();

                foreach (var p in products)
                {
                    var index = rnd.Next(0, userIds.Length);
                    var sellerId = userIds[index];

                    int? buyerId = sellerId;
                    while (buyerId == sellerId)
                    {
                        var buyerindex = rnd.Next(0, userIds.Length);
                        buyerId = userIds[buyerindex];
                    }

                    if (buyerId - sellerId < 6 && buyerId - sellerId > 0)
                    {
                        buyerId = null;
                    }

                    p.SellerId = sellerId;
                    p.BuyerId = buyerId;
                }

                db.Products.AddRange(products);

                db.SaveChanges();
            }

            return $"{products.Length} products were imported!";
        }

        static string ImportCategoriesFromJson()
        {
            var categories = ImportJson<Categorie>("Files/categories.json");

            using (var db = new ProductShopContext())
            {
                db.Categories.AddRange(categories);

                db.SaveChanges();
            }

            return $"{categories.Length} categories were imported!";
        }

        static string ImportUsersFromJson()
        {
            var users = ImportJson<User>("Files/users.json");
            
            using (var db = new ProductShopContext())
            {
                db.Users.AddRange(users);

                db.SaveChanges();
            }

            return $"{users.Length} users were imported!";
        }

        static T[] ImportJson<T>(string path)
        {
            var jsonStr = File.ReadAllText(path);

            T[] objects = JsonConvert.DeserializeObject<T[]>(jsonStr);

            return objects;
        }
    }
}
