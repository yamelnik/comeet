﻿using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Common
{
    public class MongoDbHandler : IDbHandler
    {
        private static readonly string ConnectionString = @"mongodb://teamd9mongodb:pfps2B8gq5UnVPzV1ssVPmjVBqL7WNE0IRNqviBqT9CYcNU640qHyA9WkBZ8SMdJsHNEdW4ZNRkummsefCV2Dw==@teamd9mongodb.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        private readonly IMongoCollection<User> UsersCollection;
        private readonly IMongoCollection<Tag> TagsCollection;

        public MongoDbHandler()
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase("comeet");
            UsersCollection = db.GetCollection<User>("users");
            TagsCollection = db.GetCollection<Tag>("tags");
        }

        public void AddNewTag(Tag newTag)
        {
            TagsCollection.InsertOne(newTag);
        }

        public void AddNewUser(User newUser)
        {
            UsersCollection.InsertOne(newUser);
        }

        public void AddTagToUser(Guid userId, Tag newTag)
        {
            var existingTag = GetTag(newTag.Category, newTag.Value);
            if (existingTag != null)
            {
                newTag.Id = existingTag.Id;
            }
            else
            {
                AddNewTag(newTag);
            }
            var filterDefinition = Builders<User>.Filter.Eq(user => user.Id, userId);
            var updateDefinition = Builders<User>.Update.AddToSet(user => user.Tags, newTag);
            UsersCollection.UpdateOne(filterDefinition, updateDefinition);
        }

        public IEnumerable<Tag> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAllTagsInCategory(string categoryName)
        {
            var filterDefinition = Builders<Tag>.Filter.Eq(tag => tag.Category, categoryName);
            return TagsCollection.Find(filterDefinition).ToList();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Tag GetTag(string category, string value)
        {
            var filterDefinition = Builders<Tag>.Filter
                .Where(tag => tag.Category == category && tag.Value == value);
            return TagsCollection.Find(filterDefinition).FirstOrDefault();
        }

        public IEnumerable<Tag> GetTagsByUser(Guid userId)
        {
            var filterDefinition = Builders<User>.Filter
                .Eq(user => user.Id, userId);
            var projectionDefition = Builders<User>.Projection.Include(user => user.Tags);
            return UsersCollection.Find(filterDefinition).FirstOrDefault().Tags;
        }

        public User GetUser(Guid userId)
        {
            var filterDefinition = Builders<User>.Filter
                .Eq(user => user.Id, userId);
            return UsersCollection.Find(filterDefinition).FirstOrDefault();
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
