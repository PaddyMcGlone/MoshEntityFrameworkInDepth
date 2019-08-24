namespace CodeFirstInDepth.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstInDepth.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstInDepth.PlutoContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name, new Author
            {
                Name = "Paddy",
                Courses = new List<Course>{
                    new Course() { Title = "Moriston river", Description="Lovely river", Level = CourseLevel.Intermediate, DatePublished = DateTime.Today} }
            });
        }
    }
}
