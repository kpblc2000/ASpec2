using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.Models.Data
{
    public partial class NPConEntities : DbContext
    {
        public NPConEntities(string ConnectionString) : base(ConnectionString) { }
    }
}
