using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UsersController(DataContext context)
        {
           _dataContext = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _dataContext.Users.ToList();
            return users;
        }


        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Id == id); 
            return user;
        }

    }
}
