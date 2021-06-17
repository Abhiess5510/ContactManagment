using ContactManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Services.Interface
{
    /// <summary>

    /// Interface implemented by the contact service class

    /// </summary>

    public interface IContactService

    {

        /// <summary>Gets the contact list.</summary>

        /// <returns>

        ///  List of contacts

        /// </returns>

        List<ContactDetails> GetContactList();



        /// <summary>Gets the details of contact.</summary>

        /// <param name="id">The identifier.</param>

        /// <returns>

        ///  Single contact details

        /// </returns>

        ContactDetails GetDetailsOfContact(int id);



        /// <summary>Adds the contact.</summary>

        /// <param name="contactInfo">The contact information.</param>

        /// <returns>

        /// Operation message success/failure

        /// </returns>

        string AddUpdateContact(ContactDetails contactInfo);



        /// <summary>Deletes the contact.</summary>

        /// <param name="id">The identifier.</param>

        /// <returns>

        ///  Operation message success/failure

        /// </returns>

        string DeleteContact(int id);

    }
}
