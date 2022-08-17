using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public SalePayment(int amount, int companyid, string deviceId, int salePaymentId, int paymentTypeCategoryId, int paymentTypeId, int restitution, ObjectId saleid, string statusId, int tips, string type)
        {
            Amount = amount;
            CompanyId = companyid;
            DeviceId = deviceId;
            SalePaymentId = salePaymentId;
            PaymentTypeCategoryId = paymentTypeCategoryId;
            PaymentTypeId = paymentTypeId;
            Restitution = restitution;
            Saleid = saleid;
            StatusId = statusId;
            Tips = tips;
            Type = type;
        }
    }
}
