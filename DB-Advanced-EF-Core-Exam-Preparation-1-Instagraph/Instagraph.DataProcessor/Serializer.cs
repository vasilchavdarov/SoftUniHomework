using System;

using Instagraph.Data;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using Instagraph.DataProcessor.DtoModels;
using Newtonsoft.Json;

namespace Instagraph.DataProcessor
{
    public class Serializer
    {
        public static string ExportUncommentedPosts(InstagraphContext context)
        {
            var posts = context.Posts.Where(p => p.Comments.Count < 1).OrderBy(p => p.Id).Select(p => new
            {
                p.Id,
                Picture = p.Picture.Path,
                User = p.User.Username
            }).ToArray();

            var jsonStr = JsonConvert.SerializeObject(posts, Formatting.Indented);

            return jsonStr;
        }

        public static string ExportPopularUsers(InstagraphContext context)
        {
            var users = context.Users.Where(u => u.Posts.Any(p => p.Comments.Any(c => u.Followers.Any(f => f.FollowerId == c.UserId))))
                .OrderBy(u => u.Id)
                .Select(u => new
                {
                    Username = u.Username,
                    Followers = u.Followers.Count
                }).ToArray();

            var jsonStr = JsonConvert.SerializeObject(users, Formatting.Indented);

            return jsonStr;
        }

        public static string ExportCommentsOnPosts(InstagraphContext context)
        {
            var users = context.Users.Select(u => new
            {
                Username = u.Username,
                Posts = u.Posts.Select(p => p.Comments.Count).ToArray()
            });

            var xDoc = new XDocument(new XElement("users"));

            var list = new List<TopPostDto>();
            

            foreach (var user in users)
            {
                int mostComments = 0;
                if (user.Posts.Any())
                {
                    mostComments = user.Posts.OrderByDescending(c => c).First();
                }

                var userDto = new TopPostDto
                {
                    Username = user.Username,
                    MostComments = mostComments
                };

                list.Add(userDto);
            }

            list = list.OrderByDescending(u => u.MostComments).ThenBy(u => u.Username).ToList();

            foreach (var u in list)
            {
                xDoc.Root.Add(new XElement("user",
                    new XElement("Username", u.Username),
                    new XElement("MostComments", u.MostComments)
                    ));
            }

            var result = xDoc.ToString();
            return result;
        }
    }
}
