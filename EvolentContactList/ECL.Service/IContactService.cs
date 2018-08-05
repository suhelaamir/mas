using ECL.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECL.Service
{
    public interface IContactService
    {
        IQueryable<Contact> GetContacts();
        Contact GetContact(long id);
        void InsertContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
    }
}
