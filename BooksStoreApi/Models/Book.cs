using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BooksStoreApi.Models
{
    [DataContract]
    public class Book
    {
        [BsonId]
        [DataMember(Name = "Id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string BookName { get; set; }
        [DataMember(Name = "Price")]
        public decimal Price { get; set; }
        [DataMember(Name = "Category")]
        public string Category { get; set; }
        [DataMember(Name = "Author")]
        public string Author { get; set; }
    }
}
