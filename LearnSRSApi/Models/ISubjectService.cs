namespace LearnSRSApi.Models
{
    public interface ISubjectService
    {
        IEnumerable<Subject> getAll();
        Subject Get(int SubjectId);
        public void Delete(int SubjectId);
        public void Update(Subject s);
        public void Create(Subject s);
    }
}
