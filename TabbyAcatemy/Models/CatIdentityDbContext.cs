using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabbyAcatemy.Models
{
    public class CatIdentityDbContext : IdentityDbContext<CatUser>
    {
            public CatIdentityDbContext(DbContextOptions<CatIdentityDbContext> options)
     : base(options) { }
    }
}
