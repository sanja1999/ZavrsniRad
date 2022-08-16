using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniMongo.Models
{
    public class Item
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("itemID")]
        public int ItemID { get; set; }
        [BsonElement("systemSku")]
        public double SystemSku { get; set; }
        [BsonElement("defaultCost")]
        public double DefaultCost { get; set; }
        [BsonElement("discountable")]
        public bool Discountable { get; set; }
        [BsonElement("tax")]
        public bool Tax { get; set; }
        [BsonElement("archived")]
        public bool Archived { get; set; }
        [BsonElement("itemType")]
        public string ItemType { get; set; }
        [BsonElement("serialized")]
        public bool Serialized { get; set; }
        [BsonElement("description")]
        public string Description { get; set; }
        [BsonElement("modelYear")]
        public int ModelYear { get; set; }
        [BsonElement("upc")]
        public double Upc { get; set; }
        [BsonElement("ean")]
        public double Ean { get; set; }
        [BsonElement("customSku")]
        public string CustomSku { get; set; }
        [BsonElement("manufacturerSku")]
        public string ManufacturerSku { get; set; }
        [BsonElement("createTime")]
        public DateTime CreateTime { get; set; }
        [BsonElement("timeStamp")]
        public DateTime TimeStamp { get; set; }
        [BsonElement("publishToEcom")]
        public bool PublishToEcom { get; set; }
        [BsonElement("categoryID")]
        public ObjectId CategoryID { get; set; }
        [BsonElement("taxClassID")]
        public int TaxClassID { get; set; }
        [BsonElement("departmentID")]
        public int DepartmentID { get; set; }
        [BsonElement("itemMatrixID")]
        public int ItemMatrixID { get; set; }
        [BsonElement("manufacturerID")]
        public int ManufacturerID { get; set; }
        [BsonElement("seasonID")]
        public int SeasonID { get; set; }
        [BsonElement("defaultVendorID")]
        public int DefaultVendorID { get; set; }
        [BsonElement("Prices/ItemPrice/1/amount")]
        public decimal PriceForItem1Amount { get; set; }
        [BsonElement("Prices/ItemPrice/2/amount")]
        public decimal PriceForItem2Amount { get; set; }
    }
}
