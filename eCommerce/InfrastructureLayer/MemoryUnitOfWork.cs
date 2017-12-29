using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Repository;

namespace eCommerce.InfrastructureLayer
{
    public class MemoryUnitOfWork : IUnitOfWork
    {
        public void Commit()
        {
            //
        }

        public void Dispose()
        {
            //
        }

        public void Rollback()
        {
            //
        }
    }
}
