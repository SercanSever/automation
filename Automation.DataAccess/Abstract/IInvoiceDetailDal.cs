﻿using Automation.Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DataAccess.Abstract
{
    public interface IInvoiceDetailDal : IEntityRepository<InvoiceDetail>
    {
    }
}
