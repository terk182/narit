using App.Accounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Accounting
{
    public class Service : IService
    {
        public Tesk GetAll(Tesk rq)
        {
            return rq;
        }
    }
}
