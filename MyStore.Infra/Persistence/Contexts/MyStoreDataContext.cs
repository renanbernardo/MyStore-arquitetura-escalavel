using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyStore.Infra.Persistence.Contexts
{
    public class MyStoreDataContext : DbContext
    {
        public MyStoreDataContext() : base()
        {
        }
    }
}
