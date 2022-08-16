using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniMongo
{
    public class Connection
    {
        public static string Mongodbconnection = "mongodb+srv://sanja:sanja@cluster0.fgyfo.mongodb.net/?retryWrites=true&w=majority";
        public static MongoClient client = new MongoClient(Mongodbconnection);
        public static IMongoDatabase db = client.GetDatabase("zavrsni_db");
    }
}
