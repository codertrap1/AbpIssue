using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest.EntityFramework
{
    public class SpeedTestConfiguration : DbConfiguration
    {
        public SpeedTestConfiguration()
        {
            var path = Path.GetDirectoryName(this.GetType().Assembly.Location);
            SetModelStore(new DefaultDbModelStore(path));
        }
    }
}
