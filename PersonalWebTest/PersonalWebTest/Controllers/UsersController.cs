using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebTest.Data;
using PersonalWebTest.Models;
using PersonalWebTest.Models.Domain;

namespace PersonalWebTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly PersonalWebDbContext dbContext;
        public UsersController(PersonalWebDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            return Ok(dbContext.Users.ToList());
        }

        [HttpPost]
        public IActionResult AddContact(AddUserRequestDTO _request)
        {
            User domainModelContact = new User
            {
                Id = Guid.NewGuid(),
                Name = _request.Name,
                Email = _request.Email,
                Password = _request.Pasword,
                Phone = _request.Phone
            };

            dbContext.Users.Add(domainModelContact);
            dbContext.SaveChanges();

            return Ok(domainModelContact);
        }
    }
}
