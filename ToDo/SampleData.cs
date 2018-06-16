using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo
{
    public class SampleData
    {
        public static void Initialize(ListContext context)
        {
            if (!context.Lists.Any())
            {
                context.Lists.AddRange(
                    new List
                    {
                        Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Time_start = DateTime.Now,
                        Time_end = DateTime.Parse("25/10/2018"),
                        category_id = 0
                    },
                    new List
                    {
                        Name = "Aliquam sagittis neque ac dui mollis, nec sagittis sem varius.",
                        Time_start = DateTime.Now,
                        Time_end = DateTime.Parse("25/10/2018"),
                        category_id = 0
                    },
                    new List
                    {
                        Name = "Maecenas finibus nisi vel mi dignissim rhoncus.",
                        Time_start = DateTime.Now,
                        Time_end = DateTime.Parse("25/10/2018"),
                        category_id = 0
                    }
                );
                context.SaveChanges();
            }
          /*  if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Lorem",                        
                    },
                    new Category
                    {
                        Name = "Aliquam",
                    },
                    new Category
                    {
                        Name = "Maecenas",                        
                    }
                );
                context.SaveChanges();
            }*/
        }
    }
}
