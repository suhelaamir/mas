using ECL.Common.Data;
using ECL.DataAccess;
using System.Linq;

namespace ECL.Service
{
    public class ContactService : IContactService
    {
        //services
        private IRepository<Contact> _contactRepository;
        public ContactService(IRepository<Contact> contactRepository)
        {
            this._contactRepository = contactRepository;
        }
        #region Operations
        public IQueryable<Contact> GetContacts()
        {
            return _contactRepository.Table;
        }
        public Contact GetContact(long id)
        {
            return _contactRepository.GetById(id);
        }
        public void InsertContact(Contact contact)
        {
            _contactRepository.Insert(contact);
        }
        public void UpdateContact(Contact contact)
        {
            _contactRepository.Update(contact);
        }
        public void DeleteContact(Contact contact)
        {
            _contactRepository.Delete(contact);
        }
        #endregion Operations
    }
}
