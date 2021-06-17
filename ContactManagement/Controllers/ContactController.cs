using ContactManagement.Models;
using ContactManagement.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactManagement.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class ContactController : ControllerBase

    {

        private IContactService _iContactService;

        public ContactController(IContactService iContactService)

        {

            _iContactService = iContactService;

        }

        // GET: api/Contact

        [HttpGet]

        public List<ContactDetails> Get()

        {

            List<ContactDetails> contactList = _iContactService.GetContactList();

            return contactList;

        }



        // GET: api/Contact/5

        [HttpGet("{id}", Name = "Get")]

        public ContactDetails Get(int id)

        {

            ContactDetails contactList = _iContactService.GetDetailsOfContact(id);

            return contactList;

        }



        // POST: api/Contact

        [HttpPost]

        public string Post([FromBody] ContactDetails value)

        {

            return _iContactService.AddUpdateContact(value);

        }

        // DELETE: api/ApiWithActions/5

        [HttpDelete("{id}")]

        public string Delete(int id)

        {

            return _iContactService.DeleteContact(id);

        }

    }
}
