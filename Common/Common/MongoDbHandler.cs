using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class MongoDbHandler : IDbHandler
    {
        public void AddNewTag(Tag newTag)
        {
            throw new NotImplementedException();
        }

        public void AddNewUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public void AddTagToUser(Guid userId, Tag newTag)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAllTagsInCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Tag GetTag(string tagText)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetTagsByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByString(string str)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByTags(IEnumerable<Tag> tags)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Guid userId, User newUser)
        {
            throw new NotImplementedException();
        }
    }
}
