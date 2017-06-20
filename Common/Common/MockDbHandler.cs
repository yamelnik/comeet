using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class MockDbHandler : IDbHandler
    {
        public MockDbHandler()
        {

        }
        public void AddNewTag(Tag newTag)
        {

        }

        public void AddNewUser(User newUser)
        {

        }

        public void AddTagToUser(Guid userId, Tag newTag)
        {

        }

        public IEnumerable<Tag> GetAllTags()
        {
            return new List<Tag>
            {
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Category = "Mador",
                    Value = "968",
                    Description = "Best"
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Category = "Hobby",
                    Value = "Football",
                    Description = "Haha"
                }
            };
        }

        public IEnumerable<Tag> GetAllTagsInCategory(string categoryName)
        {
            return new List<Tag>
            {
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Category = "Mador",
                    Value = "968",
                    Description = "Best"
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Category = "Hobby",
                    Value = "Football",
                    Description = "Haha"
                }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amos",
                    LastName = "Melnik",
                    BirthTime = DateTime.Parse("1998-04-07"),
                    DischargeTime = DateTime.Parse("2017-06-19"),
                    Sex = "male",
                    VoipNumber = "0000",
                    PhoneNumber = "0524259259",
                    Tags = new List<Tag>()
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amos",
                    LastName = "Melnik",
                    BirthTime = DateTime.Parse("1998-04-07"),
                    DischargeTime = DateTime.Parse("2017-06-19"),
                    Sex = "male",
                    VoipNumber = "0000",
                    PhoneNumber = "0524259259",
                    Tags = new List<Tag>()
                }
            };
        }

        public Tag GetTag(string tagText)
        {
            return new Tag
            {
                Id = Guid.NewGuid(),
                Category = "Hobby",
                Value = "Football",
                Description = "Haha"
            };
        }

        public IEnumerable<Tag> GetTagsByUser(Guid userId)
        {
            return new List<Tag>
            {
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Category = "Mador",
                    Value = "968",
                    Description = "Best"
                },
                new Tag
                {
                    Id = Guid.NewGuid(),
                    Category = "Hobby",
                    Value = "Football",
                    Description = "Haha"
                }
            };
        }

        public User GetUser(Guid userId)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Amos",
                LastName = "Melnik",
                BirthTime = DateTime.Parse("1998-04-07"),
                DischargeTime = DateTime.Parse("2017-06-19"),
                Sex = "male",
                VoipNumber = "0000",
                PhoneNumber = "0524259259",
                Tags = new List<Tag>()
            };
        }

        public IEnumerable<User> GetUsersByString(string str)
        {
            return new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amos",
                    LastName = "Melnik",
                    BirthTime = DateTime.Parse("1998-04-07"),
                    DischargeTime = DateTime.Parse("2017-06-19"),
                    Sex = "male",
                    VoipNumber = "0000",
                    PhoneNumber = "0524259259",
                    Tags = new List<Tag>()
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amos",
                    LastName = "Melnik",
                    BirthTime = DateTime.Parse("1998-04-07"),
                    DischargeTime = DateTime.Parse("2017-06-19"),
                    Sex = "male",
                    VoipNumber = "0000",
                    PhoneNumber = "0524259259",
                    Tags = new List<Tag>()
                }
            };
        }

        public IEnumerable<User> GetUsersByTags(IEnumerable<Tag> tags)
        {
            return new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amos",
                    LastName = "Melnik",
                    BirthTime = DateTime.Parse("1998-04-07"),
                    DischargeTime = DateTime.Parse("2017-06-19"),
                    Sex = "male",
                    VoipNumber = "0000",
                    PhoneNumber = "0524259259",
                    Tags = new List<Tag>()
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amos",
                    LastName = "Melnik",
                    BirthTime = DateTime.Parse("1998-04-07"),
                    DischargeTime = DateTime.Parse("2017-06-19"),
                    Sex = "male",
                    VoipNumber = "0000",
                    PhoneNumber = "0524259259",
                    Tags = new List<Tag>()
                }
            };
        }

        public void UpdateUser(Guid userId, User newUser)
        {
            
        }
    }
}
