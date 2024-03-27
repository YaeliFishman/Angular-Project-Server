using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace final_project.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {


    public static List<User> users = new List<User>
        {
            new User{Id= 1, Name="chana", Mail="d@g",Address="th",Password="77776"},
            new User{Id= 2, Name="sara", Mail="fgh@rgdr",Address="mafghimon",Password="678"},
            new User{Id= 3, Name="rivka", Mail="e@rgd",Address="maimon",Password="75"}
        };

    // GET: api/<UserController>
    [HttpGet]
    public IEnumerable<User> Get()
    {
      return users;
    }


    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public User Get(int id)
    {
      var user = users.Find(x => x.Id == id);

      return user;
    }

        [HttpGet]
        [Route("login/{name}/{password}")]
        public User Login(string name , string password)
        {
            User user = users.SingleOrDefault(user => user.Name == name && user.Password == password);
            return user;
        }





    // POST api/<UserController>
    [HttpPost]
    public bool Post([FromBody] User user)

    {
      //if (!ModelState(user))
      //  return false;
      users.Add(user);
      return true;
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] User user)
    {
      //id - מציאת אוביקט עפי ה
      var a = users.Find(x => x.Id == id);

      //עדכון המשתנים
      a.Address = user.Address;
      a.Name = user.Name;
      a.Mail = user.Mail;
      a.Password = user.Password;
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var a = users.Find(x => x.Id == id);
      users.Remove(a);
    }
  }
}
