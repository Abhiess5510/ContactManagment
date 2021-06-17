using ContactManagement.Models;
using ContactManagement.Repositories.Interface;
using ContactManagement.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Services
{
    /// <summary>

    ///  Service layer class for contact

    /// </summary>

    public class ContactService : IContactService

    {

        private IContactRepository _iContactRepository;



        public ContactService(IContactRepository iContactRepository)

        {

            _iContactRepository = iContactRepository;

        }



        /// <summary>Adds the contact.</summary>

        /// <param name="contactInfo">The contact information.</param>

        /// <returns>Operation message success/failure</returns>

        public string AddUpdateContact(ContactDetails contactInfo)

        {

            return _iContactRepository.AddUpdateContact(contactInfo);



        }



        /// <summary>Deletes the contact.</summary>

        /// <param name="id">The identifier.</param>

        /// <returns>Operation message success/failure</returns>

        public string DeleteContact(int id)

        {

            return _iContactRepository.DeleteContact(id);

        }



        /// <summary>Gets the contact list.</summary>

        /// <returns>List of contacts</returns>

        public List<ContactDetails> GetContactList()

        {

            List<ContactDetails> contactList = _iContactRepository.GetContactsListData();

            return contactList;

        }



        /// <summary>Gets the details of contact.</summary>

        /// <param name="id">The identifier.</param>

        /// <returns>Single contact details</returns>

        public ContactDetails GetDetailsOfContact(int id)

        {

            ContactDetails contactList = _iContactRepository.GetContacData(id);

            return contactList;

        }

    }
}
