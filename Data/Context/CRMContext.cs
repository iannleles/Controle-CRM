using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class CRMContext : DbContext
    {
        public CRMContext() : base("ControleCRMConnectionString")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }



    }
}
