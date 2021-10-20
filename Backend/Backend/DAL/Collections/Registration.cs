using System.Collections.Generic;

namespace Backend.DAL.Collections
{
    public class Registration: Document
    {
        public IList<Question> Questions { get; set; }
    }

    public class Question : Document
    {
        public string Name { get; set; }
        public string AnswerId { get; set; }

        public IList<Option> Options { get; set; }
    }

    public class Option : Document
    {
        public string Name { get; set; }
    }
}
