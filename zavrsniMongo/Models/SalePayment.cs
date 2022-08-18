using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace zavrsniMongo.Models
{
    public class SalePayment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("amount")]
        public int Amount { get; set; }
        [BsonElement("companyid")]
        public int CompanyId { get; set; }
        [BsonElement("deviceId")]
        public string DeviceId { get; set; }
        [BsonElement("id")]
        public int SalePaymentId { get; set; }
        [BsonElement("paymentTypeCategoryId")]
        public int PaymentTypeCategoryId { get; set; }
        [BsonElement("paymentTypeId")]
        public int PaymentTypeId { get; set; }
        [BsonElement("restitution")]
        public int Restitution { get; set; }
        [BsonElement("saleid")]
        public ObjectId Saleid { get; set; }
        [BsonElement("statusId")]
        public string StatusId { get; set; }
        [BsonElement("tips")]
        public int Tips { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
    }
}
