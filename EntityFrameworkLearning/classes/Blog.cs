using System;

namespace EntityFrameworkLearning.classes
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public DateTime? CreateTime { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }

    }
}