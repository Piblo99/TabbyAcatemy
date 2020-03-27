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
                    PhotoPath = null
                },
                new Course
                {
                    Id = 2,
                    Name = "Theory of Computation",
                    PhotoPath = null
                },
                new Course
                {
                    Id = 3,
                    Name = "Operating Systems",
                    PhotoPath = null
                },
                new Course
                {
                    Id = 4,
                    Name = "Cloud Computing",
                    PhotoPath = null
                },
                new Course
                {
                    Id = 5,
                    Name = "Numerical Analysis",
                    PhotoPath = null
                }
                );
        }
    }
}
