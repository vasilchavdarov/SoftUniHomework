using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Instagraph.Data;
using Instagraph.Models;
using Instagraph.DataProcessor.DtoModels;
using System.IO;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        private static string errorMsg = "Error: Invalid data.";

        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            var deserializePicturs = JsonConvert.DeserializeObject<Picture[]>(jsonString);

            var sb = new StringBuilder();

            var pictures = new List<Picture>();

            foreach (var picture in deserializePicturs)
            {
                var isValid = !String.IsNullOrWhiteSpace(picture.Path) && picture.Size > 0;

                var isPictureExists = context.Pictures.Any(p => p.Path == picture.Path) || pictures.Any(p => p.Path == picture.Path);

                if (!isValid || isPictureExists)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                pictures.Add(picture);
                sb.AppendLine($"Successfully imported Picture {picture.Path}.");

            }

            context.Pictures.AddRange(pictures);
            context.SaveChanges();

            return sb.ToString().Trim();
            
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var deserializeUsers = JsonConvert.DeserializeObject<UserDto[]>(jsonString);

            var sb = new StringBuilder();

            var users = new List<User>();

            foreach (var userDto in deserializeUsers)
            {
                var isValidUsername = !String.IsNullOrWhiteSpace(userDto.Username) && userDto.Username.Length <= 30;
                var isValidPassword = !String.IsNullOrWhiteSpace(userDto.Password) && userDto.Password.Length <= 20 && !String.IsNullOrWhiteSpace(userDto.ProfilePicture);
                var picture = context.Pictures.FirstOrDefault(p => p.Path == userDto.ProfilePicture);
                var userExist = users.Any(u => u.Username == userDto.Username);

                if (!isValidUsername || !isValidPassword || picture == null || userExist)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                var user = Mapper.Map<User>(userDto);
                user.ProfilePicture = picture;
                
                users.Add(user);
                sb.AppendLine($"Successfully imported User {userDto.Username}.");

            }

            context.AddRange(users);
            context.SaveChanges();

            return sb.ToString().Trim();
            
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            var desirializeFollower = JsonConvert.DeserializeObject<UserFollowerDto[]>(jsonString);

            var sb = new StringBuilder();

            var followers = new List<UserFollower>();

            foreach (var dto in desirializeFollower)
            {
                int? userId = context.Users.FirstOrDefault(u => u.Username == dto.User)?.Id;
                int? followerId = context.Users.FirstOrDefault(u => u.Username == dto.Follower)?.Id;

                if (userId == null || followerId == null)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                var alreadyFollowed = followers.Any(f => f.UserId == userId && f.FollowerId == followerId);

                if (alreadyFollowed)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                var userfollower = new UserFollower
                {
                    UserId = userId.Value,
                    FollowerId = followerId.Value
                };

                followers.Add(userfollower);
                sb.AppendLine($"Successfully imported Follower {dto.Follower} to User {dto.User}.");
            }

            context.UsersFollowers.AddRange(followers);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var xml = XDocument.Parse(xmlString);

            var elemets = xml.Root.Elements();

            var sb = new StringBuilder();

            var posts = new List<Post>();

            foreach (var element in elemets)
            {
                var caption = element.Element("caption")?.Value;
                var username = element.Element("user")?.Value;
                var picturePath = element.Element("picture")?.Value;

                if (caption == null || username == null || picturePath == null)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                int? userId = context.Users.FirstOrDefault(u => u.Username == username)?.Id;
                int? pictureId = context.Pictures.FirstOrDefault(p => p.Path == picturePath)?.Id;

                if (userId == null || pictureId == null)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                var post = new Post
                {
                    Caption = caption,
                    UserId = userId.Value,
                    PictureId = pictureId.Value
                };

                posts.Add(post);
                sb.AppendLine($"Successfully imported Post {caption}.");
            }

            context.Posts.AddRange(posts);
            context.SaveChanges();


            return sb.ToString().Trim();
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            var xml = XDocument.Parse(xmlString);

            var elements = xml.Root.Elements();

            var sb = new StringBuilder();

            var comments = new List<Comment>();

            foreach (var element in elements)
            {
                var content = element.Element("content")?.Value;
                var username = element.Element("user")?.Value;
                var postIdStr = element.Element("post")?.Attribute("id")?.Value;

                if (content == null || username == null || postIdStr == null)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                var postId = int.Parse(postIdStr);

                int? userId = context.Users.FirstOrDefault(u => u.Username == username)?.Id;
                bool postExist = context.Posts.Any(p => p.Id == postId);

                if (userId == null || !postExist)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                var comment = new Comment
                {
                    Content = content,
                    UserId = userId.Value,
                    PostId = postId
                };

                comments.Add(comment);
                sb.AppendLine($"Successfully imported Comment {content}.");
            }

            context.Comments.AddRange(comments);

            context.SaveChanges();

            return sb.ToString().Trim();
        }
    }
}
