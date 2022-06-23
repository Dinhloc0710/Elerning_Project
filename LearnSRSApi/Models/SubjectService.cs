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
            _context.Subjects.Add(s);
            _context.SaveChanges();
        }

        public void Delete(int SubjectId)
        {
            var p = _context.Subjects.FirstOrDefault(c => c.SubjectId == SubjectId);

            _context.Subjects.Remove(p);
            _context.SaveChanges();
        }

        public Subject Get(int SubjectId)
        {
            return _context.Subjects.FirstOrDefault(x => x.SubjectId == SubjectId);
        }

        public IEnumerable<Subject> getAll()
        {
            return _context.Subjects.ToList();
        }

        public void Update(Subject s)
        {
            _context.Subjects.Update(s);
            _context.SaveChanges();
        }
    }
}
