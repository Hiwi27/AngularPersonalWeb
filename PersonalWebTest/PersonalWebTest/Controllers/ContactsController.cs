using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebTest.Data;
using PersonalWebTest.Models;
using PersonalWebTest.Models.Domain;

namespace PersonalWebTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsDbContext dbContext;
        public ContactsController(ContactsDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            return Ok(dbContext.Contacts.ToList());
        }

        [HttpPost]
        public IActionResult AddContact(AddContactRequestDTO _request)
        {
            var domainModelContact = new Contact
            {
                Id = Guid.NewGuid(),
                Name = _request.Name,
                Email = _request.Email,
                Phone = _request.Phone
            };

            dbContext.Contacts.Add(domainModelContact);
            dbContext.SaveChanges();

            return Ok(domainModelContact);
        }
    }
}
