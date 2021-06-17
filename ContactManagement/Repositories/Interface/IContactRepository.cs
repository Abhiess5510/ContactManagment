using ContactManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Repositories.Interface
{
    /// <summary>

    /// Interface implemented by the contact repository class.

    /// </summary>

    public interface IContactRepository

    {

        /// <summary>Gets the contact list.</summary>

        /// <returns>

        ///  List of contacts

        /// </returns>

        List<ContactDetails> GetContactsListData();



        /// <summary>Gets the details of contact.</summary>

        /// <param name="number">The identifier.</param>

        /// <returns>

        ///  Single contact details

        /// </returns>

        ContactDetails GetContacData(int number);



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
