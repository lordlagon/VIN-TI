using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    class Context : DbContext
    {
        public Context() : base("DbProduto") { }
        public DbSet<Produto> Podutos { get; set; }

    }
}