using CleanArch.Domain;

namespace CleanArch.Application
{
    public interface IMasterFieldRepository
    {
        List<MasterDetailsModel> GetDesignation();
        List<MasterDetailsModel> GetRole();
        List<MasterDetailsModel> GetBU();
   
    }
}
