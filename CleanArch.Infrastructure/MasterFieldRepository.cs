using CleanArch.Application;
using CleanArch.Domain;
using CleanArch.Infrastructure.Data;

namespace CleanArch.Infrastructure
{
    public class MasterFieldRepository : IMasterFieldRepository
    {
        public List<MasterDetailsModel> GetBU()
        {
            using (DbContextFist _context = new DbContextFist())
            {
                try
                {
                    List<MasterDetailsModel> bu = _context.BuMasters.Select(a => new MasterDetailsModel
                    {
                        Id = a.BuId,
                        Name = a.BuName,
                    }).OrderBy(a => a.Name).ToList();
                    return bu;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            throw new NotImplementedException();
        }

        public List<MasterDetailsModel> GetDesignation()
        {
            using (DbContextFist _context = new DbContextFist())
            {
                try
                {
                    List<MasterDetailsModel> designation = _context.DesignationMasters.Select(a => new MasterDetailsModel
                    {
                        Id = a.DesignationId,
                        Name = a.DesignationName,
                    }).OrderBy(a => a.Name).ToList();
                    return designation;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }

        public List<MasterDetailsModel> GetRole()
        {
            throw new NotImplementedException();
        }

    }
}
