using SchoolERP.Core.Models;

namespace SchoolERP.Business.Services.Interfaces
{
    public interface IStudentService
    {
        void Create (Student student);
        List<Student> GetAll ();
        Student GetStudent (int id);
        void Remove (int Id);
        Student GetStudentByTeacherId (int TeacherId);
        void RemoveStudentByTeacherId (int TeacherId);
        void AllRemoveStudentByTeacherId(int TeacherId);
    }
}
