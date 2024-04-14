using CleanArch.Domain;

namespace CleanArch.Application
{
    public interface IMasterFieldService
    {
        List<MasterDetailsModel> GetBu();
        List<MasterDetailsModel> GetDesignation();
    }
}
