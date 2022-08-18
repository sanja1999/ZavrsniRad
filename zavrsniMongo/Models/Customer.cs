using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace zavrsniMongo.Models
{
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("customerID")]
        public int CustomerID { get; set; }
        [BsonElement("firstName")]
        public string FirstName { get; set; }
        [BsonElement("lastName")]
        public string LastName { get; set; }
        [BsonElement("company")]
        public string Company { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("createTime")]
        public DateTime CreateTime { get; set; }
        [BsonElement("timeStamp")]
        public DateTime TimeStamp { get; set; }
        [BsonElement("archived")]
        public bool Archived { get; set; }
        [BsonElement("contactID")]
        public int ContactID { get; set; }
        [BsonElement("creditAccountID")]
        public int CreditAccountID { get; set; }
        [BsonElement("customerTypeID")]
        public int CustomerTypeID { get; set; }
        [BsonElement("discountID")]
        public int DiscountID { get; set; }
        [BsonElement("taxCategoryID")]
        public int TaxCategoryID { get; set; }
    }
}
