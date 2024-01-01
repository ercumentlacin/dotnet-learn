namespace LMS.Data.Repositories.User;

public class UserRepository : IUserRepository
{

    private readonly IGenericRepository<Entities.User> _repository;

    public UserRepository(IGenericRepository<Entities.User> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Entities.User>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Entities.User?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Entities.User> InsertAsync(Entities.User entity)
    {
        return await _repository.InsertAsync(entity);
    }

    public async Task<Entities.User> UpdateAsync(Entities.User entity)
    {
        return await _repository.UpdateAsync(entity);
    }

    public async Task<Entities.User?> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}