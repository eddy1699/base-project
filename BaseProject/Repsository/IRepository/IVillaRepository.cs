using BaseProject.Models;
namespace BaseProject.Repsository.IRepository
{
    public interface IVillaRepository:IRepository<Villa>
    {
        Task<Villa> Update(Villa entity);
    }
}
