using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Common
{
    public class User
    {
        [BsonId]
        public Guid Id;

        [BsonElement("firstName")]
        public string FirstName;

        [BsonElement("lastName")]
        public string LastName;

        [BsonElement("birthTime")]
        public DateTime BirthTime;

        [BsonElement("dischargeTime")]
        public DateTime DischargeTime;

        [BsonElement("sex")]
        public string Sex;

        [BsonElement("tags")]
        public List<Tag> Tags;
    }
}