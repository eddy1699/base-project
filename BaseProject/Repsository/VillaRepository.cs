using BaseProject.Data;
using BaseProject.Models;
using BaseProject.Repsository.IRepository;

namespace BaseProject.Repsository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        public async Task<Villa> Update(Villa entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
