using LMS.Data.Entities;
using LMS.Data.Repositories.User;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // private readonly LMSDBContext _context;
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<User?> Get(int id)
        {
            return  await _repository.GetByIdAsync(id)!;
        }

        [HttpPost]
        public async Task<User> Post([FromBody] User user)
        {
            return await _repository.InsertAsync(user);
        }

        [HttpPut]
        public async Task<User> Put([FromBody] User user)
        {
            return await _repository.UpdateAsync(user);
        }

        [HttpDelete("{id}")]
        public async Task<User?> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
} 
