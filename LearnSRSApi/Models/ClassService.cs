using LearnSRSApi.Data;

namespace LearnSRSApi.Models
{
    public class ClassService : IClassService
    {
        private readonly DataContext _context;
        public ClassService(DataContext context)
        {
            _context = context;
        }
        public void Create(Class classes)
        {
            _context.Classes.Add(classes);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var de = _context.Classes.FirstOrDefault(d => d.ClassId == id);
            _context.Classes.Remove(de);
            _context.SaveChanges();
        }

        public Class Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> getAll()
        {
            return _context.Classes.ToList();
        }

        public void Update(Class classes)
        {
            _context.Classes.Update(classes);
            _context.SaveChanges();
        }
    }
}
