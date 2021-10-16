using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Backend.DAL.Collections
{
    public class Question: Document
    {
        public string Name { get; set; }
        public ObjectId AnswerId { get; set; }

        public List<ObjectId> OptionIds { get; set; }
    }
}
