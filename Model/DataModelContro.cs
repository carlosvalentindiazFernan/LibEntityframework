using libEtifyCon.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEtifyCon.Model
{
    public class DataModelContro : DbContext
    {
        public  DbSet<Animal> Animals { get; set; }
    }
}
