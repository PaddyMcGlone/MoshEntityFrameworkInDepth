using System.Collections.Generic;

namespace CodeFirstInDepth
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // A one-to-many relationship between author and courses
        public IList<Course> Courses { get; set; }
    }
}