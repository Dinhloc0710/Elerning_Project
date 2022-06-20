using LearnSRSApi.Data;

namespace LearnSRSApi.Models
{
    public class SubjectService : ISubjectService
    {
        private readonly DataContext _context;
        public SubjectService(DataContext context)
        {
            _context = context;
        }
        public void Create(Subject s)
        {
            throw new NotImplementedException();
        }

        public void Delete(int SubjectId)
        {
            throw new NotImplementedException();
        }

        public Subject Get(int SubjectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> getAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Subject s)
        {
            throw new NotImplementedException();
        }
    }
}
