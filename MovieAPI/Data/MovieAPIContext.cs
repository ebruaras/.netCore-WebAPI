using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Data
{
    //Data context, data model e hangi entity lerin dahil edileceğini belirtir
    //EF de bir entity set bir db table a, bir entity de tabloda bir satıra karşılık gelir 
    //MovieAPIContext controller daki her crud işleminde kullanılır
    public class MovieAPIContext : DbContext
    {
        public MovieAPIContext (DbContextOptions<MovieAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MovieAPI.Models.Movie> Movie { get; set; }
    }
}
