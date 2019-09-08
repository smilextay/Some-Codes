using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace mongodb_project.App.models
{
    public class AccountInfo
    {
         /// <summary>
        /// key
        /// </summary>
        [BsonId]
        public ObjectId Id { get; set; }
 
        public string Name { get; set; }

        public string FullName { get; set; }

        public string NickName { get; set; }
    }
}
