using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabbyAcatemy.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Linear Algebra",
                    PhotoPath = ""
                }
                );
        }
    }
}
