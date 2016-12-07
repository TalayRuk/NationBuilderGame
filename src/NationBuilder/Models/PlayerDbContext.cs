using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    public class PlayerDbContext : IdentityDbContext<Player>
    {
        public PlayerDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
