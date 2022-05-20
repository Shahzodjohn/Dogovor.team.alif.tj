using Entity.Roles;
namespace Repository.Interfaces
{
    public interface IRoleRepository
    {
        public Task<Role> GetRoleById(int Id);
    }
}
