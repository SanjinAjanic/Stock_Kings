using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Model
{
    public class AuthDBContext: IdentityDbContext
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options): base(options)
        {

        }
    }
}
