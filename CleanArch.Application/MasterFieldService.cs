using CleanArch.Domain;

namespace CleanArch.Application
{
    public class MasterFieldService : IMasterFieldService
    {
        public readonly IMasterFieldRepository _repository;
        public MasterFieldService(IMasterFieldRepository repository)
        {
            _repository = repository;
        }
        
        public List<MasterDetailsModel> GetBu()
        {
            return _repository.GetBU();
        }
        public List<MasterDetailsModel> GetDesignation()
        {
            return _repository.GetDesignation();
        }
    }
}
