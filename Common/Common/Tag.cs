using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Common
{
    public class Tag
    {
        [BsonId]
        public Guid Id;

        [BsonElement("category")]
        public string Category;

        [BsonElement("value")]
        public string Value;

        [BsonElement("description")]
        public string Description;
    }
}