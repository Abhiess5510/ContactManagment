using ContactManagement.Models;
using ContactManagement.Repositories.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Repositories
{
    /// <summary>

    /// COntact repository class is responsible for all db actions and methods

    /// </summary>

    public class ContactRepository : IContactRepository

    {

        private ContactDetailsDBContext _DbContext;

        private ILogger _logger;

        public ContactRepository(ContactDetailsDBContext context)

        {

            _DbContext = context;

        }





        /// <summary>Gets the contacts list data.</summary>

        /// <returns>

        /// The contact list data

        /// </returns>

        public List<ContactDetails> GetContactsListData()

        {

            List<ContactDetails> contactList = new List<ContactDetails>();



            try

            {

                contactList = _DbContext.Contacts.ToList();

            }

            catch (Exception ex)

            {

                //Log exception

                _logger.LogError("Exception" + ex);

            }

            return contactList;

        }



        /// <summary>Adds the contact.</summary>

        /// <param name="contactInfo">The contact information.</param>

        /// <returns>

        ///  The string with id regarding the success/failure of the operation

        /// </returns>

        public string AddUpdateContact(ContactDetails contactInfo)

        {

            string msg = string.Empty;

            try

            {

                //insert query for contact details

                _DbContext.Contacts.Add(contactInfo);

                _DbContext.SaveChanges();



                msg = "Added Successfully";

            }

            catch (Exception ex)

            {

                //Log exception

                _logger.LogError("Exception" + ex);

                msg = "Please try again";

            }



            return msg;

        }



        /// <summary>Deletes the contact.</summary>

        /// <param name="id">The identifier.</param>

        /// <returns>

        ///  The string with id regarding the success/failure of the operation

        /// </returns>

        public string DeleteContact(int id)

        {

            string msg = string.Empty;

            try

            {

                ContactDetails contact = GetContacData(id);



                //delete query for contact details

                _DbContext.Contacts.Remove(contact);

                _DbContext.SaveChanges();



                msg = "Deleted Successfully";

            }



            catch (Exception ex)

            {

                //Log exception

                _logger.LogError("Exception" + ex);

                msg = "Please try again";

            }



            return msg;

        }



        /// <summary>Gets the contac data.</summary>

        /// <param name="number">The number.</param>

        /// <returns>

        ///  Single object of Contact type

        /// </returns>

        public ContactDetails GetContacData(int number)

        {

            ContactDetails contactList = null;

            try

            {

                contactList = _DbContext.Contacts.Where(w => w.Id == number).FirstOrDefault();

            }

            catch (Exception ex)

            {

                //log exception

                _logger.LogError("Exception" + ex);

            }

            return contactList;

        }

    }
}
