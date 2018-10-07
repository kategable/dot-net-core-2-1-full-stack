using multi.layer.dataaccess;

namespace multy.layer.services
{
    public class ValuesService : IValuesService
    {
        private readonly IValuesRepository _repository;

        public ValuesService(IValuesRepository repository)
        {
            _repository = repository;
        }
        public string GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
