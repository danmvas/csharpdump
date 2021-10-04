using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        public static List<User> _users = new List<User>();

        // GET api/<CrudController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _users.Find(f => f.Id == id);

        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        // POST api/<CrudController>
        [HttpPost]
        public ActionResult Add(User user)
        {
            if (!CheckUsers.ExistentUsers(user.Id))
            {
                _users.Add(user);
                SaveUsers.WriteBD();
                return Ok();
            }

            return BadRequest();
        }

        // PUT api/<CrudController>/5
        [HttpPut("{id}")]
        public ActionResult Edit(int id, User users)
        {
            var userDb = _users.Find(f => f.Id == id);

            if(userDb == null)
            {
                return BadRequest();
            }

            userDb.NameUser = users.NameUser;
            userDb.Surname = users.Surname;
            userDb.Passport = users.Passport;
            userDb.Email = users.Email;
            userDb.Phone = users.Phone;
            userDb.Birthday = users.Birthday;

            SaveUsers.WriteBD();

            return Ok();

        }

        // DELETE api/<CrudController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            var userDb = _users.Find(f => f.Id == id);

            if (userDb == null)
            {
                return BadRequest();
            }

            _users.Remove(userDb);
            SaveUsers.WriteBD();

            return Ok();


        }
    }
}
