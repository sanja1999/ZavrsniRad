using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Customer(string firstName, string lastName, string company, string title, DateTime createTime, DateTime timeStamp, bool archived, int contactID, int creditAccountID, int customerTypeID, int discountID, int taxCategoryID)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            Title = title;
            CreateTime = createTime;
            TimeStamp = timeStamp;
            Archived = archived;
            ContactID = contactID;
            CreditAccountID = creditAccountID;
            CustomerTypeID = customerTypeID;
            DiscountID = discountID;
            TaxCategoryID = taxCategoryID;
        }
    }
}
