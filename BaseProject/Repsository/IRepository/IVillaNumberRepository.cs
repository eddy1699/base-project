using BaseProject.Models;
namespace BaseProject.Repsository.IRepository
{
    public interface INumberVillaRepository:IRepository<NumberVilla>
    {
        Task<NumberVilla> Update(NumberVilla entity);
    }
}
