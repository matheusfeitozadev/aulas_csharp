using LogicaProgramacao.Classes.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WinForms.Classes.Entity;

namespace WebAPI.Controllers
{
    public class CustomersController : ApiController
    {
        private EntityCustomer entityCustomer;

        public CustomersController()
        {
            entityCustomer = new EntityCustomer();
        }

        public List<CustomerViewModel> Get()
        {
            var list = entityCustomer.List();

            return list;
        }
    }
}
