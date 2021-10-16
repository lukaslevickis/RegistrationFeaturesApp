using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Backend.DAL.Collections
{
    public class Registration: Document
    {
        public List<ObjectId> QuestionsIds { get; set; }
    }
}
