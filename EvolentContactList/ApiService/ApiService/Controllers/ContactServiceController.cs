using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ECL.Common.Data;
using ECL.DataAccess;

namespace ApiService.Controllers
{
    public class ContactServiceController : ApiController
    {
        private IRepository<Contact> _contactRepository;
        public ContactServiceController()
        {

        }
        public ContactServiceController(IRepository<Contact> contactRepository)
        {
            this._contactRepository = contactRepository;
        }
        [HttpGet]
        public IQueryable<Contact> GetContacts()
        {
            return _contactRepository.Table;
        }
    }
}
