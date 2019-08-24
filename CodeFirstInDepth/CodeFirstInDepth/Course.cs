﻿using System;
using System.Collections.Generic;

namespace CodeFirstInDepth
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author  { get; set; }
        public IList<Tag> Tags { get; set; }        
        public DateTime DatePublished { get; set; }
    }
}