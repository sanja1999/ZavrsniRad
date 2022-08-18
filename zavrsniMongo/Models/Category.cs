using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace zavrsniMongo.Models
{
    public class Category
    {
        public Category(int categoryId, string name, int nodeDepth, string fullPathName, int leftNode, int rightNode, int parentID, DateTime createTime, DateTime timeStamp)
        {
            CategoryId = categoryId;
            Name = name;
            NodeDepth = nodeDepth;
            FullPathName = fullPathName;
            LeftNode = leftNode;
            RightNode = rightNode;
            ParentID = parentID;
            CreateTime = createTime;
            TimeStamp = timeStamp;
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("categoryID")]
        public int CategoryId { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("nodeDepth")]
        public int NodeDepth { get; set; }
        [BsonElement("fullPathName")]
        public string FullPathName { get; set; }
        [BsonElement("leftNode")]
        public int LeftNode { get; set; }
        [BsonElement("rightNode")]
        public int RightNode { get; set; }
        [BsonElement("parentID")]
        public int ParentID { get; set; }
        [BsonElement("createTime")]
        public DateTime CreateTime { get; set; }
        [BsonElement("timeStamp")]
        public DateTime TimeStamp { get; set; }
    }
}
