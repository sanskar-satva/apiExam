using DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerServices: ICustomerInterface
    {
        public string ConnectionString { get; set; } = string.Empty;
        public CustomerServices(string connectionString)
        {
            ConnectionString = connectionString;
        }

    }
}
