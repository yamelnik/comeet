using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Common
{
    class MongoDbHandler : IDbHandler
    {
        private static readonly string ConnectionString = @"mongodb://teamd9mongodb:pfps2B8gq5UnVPzV1ssVPmjVBqL7WNE0IRNqviBqT9CYcNU640qHyA9WkBZ8SMdJsHNEdW4ZNRkummsefCV2Dw==@teamd9mongodb.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        private readonly IMongoCollection<User> UsersCollection;
        private readonly IMongoCollection<Tag> TagsCollection;

        private MongoDbHandler()
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase("comeet");
            UsersCollection = db.GetCollection<User>("users");
            TagsCollection = db.GetCollection<Tag>("tags");
        }

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
