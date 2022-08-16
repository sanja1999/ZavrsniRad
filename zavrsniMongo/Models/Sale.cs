using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniMongo.Models
{
    public class Sale
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("companyid")]
        public int Companyid { get; set; }
        [BsonElement("saleid")]
        public int saleid { get; set; }
        [BsonElement("sequentialId")]
        public int SequentialId { get; set; }
        [BsonElement("sequenceNumber")]
        public int SequenceNumber { get; set; }
        [BsonElement("uuid")]
        public string Uuid { get; set; }
        [BsonElement("parentId")]
        public int ParentId { get; set; }
        [BsonElement("floorId")]
        public int FloorId { get; set; }
        [BsonElement("tableId")]
        public int TableId { get; set; }
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }
        [BsonElement("userId")]
        public int UserId { get; set; }
        [BsonElement("status")]
        public string Status { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        [BsonElement("creationDate")]
        public DateTime CreationDate { get; set; }
        [BsonElement("modificationDate")]
        public DateTime ModificationDate { get; set; }
        [BsonElement("closingDate")]
        public DateTime ClosingDate { get; set; }
        [BsonElement("deliveryDate")]
        public DateTime DeliveryDate { get; set; }
        [BsonElement("printDate")]
        public DateTime PrintDate { get; set; }
        [BsonElement("total")]
        public float Total { get; set; }
        [BsonElement("totalwithouttax")]
        public float Totalwithouttax { get; set; }
        [BsonElement("tumberOfCustomers")]
        public int TumberOfCustomers { get; set; }
        [BsonElement("numberOfCustomers")]
        public int NumberOfCustomers { get; set; }
        [BsonElement("currentCourse")]
        public int CurrentCourse { get; set; }
        [BsonElement("taxtotal")]
        public float TaxTotal { get; set; }
    }
}
