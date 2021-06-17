using ContactManagement.Models;
using ContactManagement.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestContact
{
    [TestClass]
    public class UnitTest1

    {

        private ContactRepository _contactRepository;

        public UnitTest1()

        {

            DbContextOptions<ContactDetailsDBContext> options;

            var builder = new DbContextOptionsBuilder<ContactDetailsDBContext>();

            builder.UseSqlServer("server=localdb\\SQLEXPRESS2012; database=EmployeeDB;Trusted_Connection=True;");

            options = builder.Options;

            var context = new ContactDetailsDBContext(options);

            _contactRepository = new ContactRepository(context);

        }

        [TestMethod]

        public void CheckContactListIsNull()

        {

            var contactList = _contactRepository.GetContactsListData();

            Assert.AreEqual(contactList.Count, 0, "Expected 0");

        }

    }
}
