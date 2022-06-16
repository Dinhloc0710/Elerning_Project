namespace LearnSRSApi.Models
{
    public interface IClassService
    {
        IEnumerable<Class> getAll();
        Class Get(int id);
        public void Create(Class classes);

        public void Update(Class classes);
        public void Delete(int id);
        
        
    }
}
