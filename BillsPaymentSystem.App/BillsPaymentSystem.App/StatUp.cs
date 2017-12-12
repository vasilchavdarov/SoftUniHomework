using System;
using P01_BillsPaymentSystem.Data;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data.Models;

namespace BillsPaymentSystem.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new BillsPaymentSystemContext())
            {
                db.Database.Migrate();

                Seed(db);
            }
        }

        private static void Seed(BillsPaymentSystemContext db)
        {
            var user = new User()
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Email = "Ivan@abv.bg",
                Password = "ivan123"
            };

            var creditCard = new CreditCard()
            {
                ExpirationDate = DateTime.ParseExact("24/11/2020", "dd/MM/yyyy",null),
                Limit = 500,
                MoneyOwed = 150,
                
            };

            var bankAccount = new BankAccount()
            {
                BankName = "OBB",
                SwiftCode = "OBB1427",
                Balance = 2000
            };

            var paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod()
                {
                    User = user,
                    BankAccount = bankAccount,
                    Type = PaymentMethodType.BankAccount,
                },

                new PaymentMethod()
                {
                    User = user,
                    CreditCard = creditCard,
                    Type = PaymentMethodType.CreditCard,
                }
            };

            db.PaymentMethods.AddRange(paymentMethods);

            db.SaveChanges();
        }
    }
}
