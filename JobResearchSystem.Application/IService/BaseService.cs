using JobResearchSystem.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobResearchSystem.Application.IService
{
    // not needed (we use generic service)
    public class BaseService
    {
        #region CTOR
        public readonly IUnitOfWork _uow;

        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        #endregion
    }
}
