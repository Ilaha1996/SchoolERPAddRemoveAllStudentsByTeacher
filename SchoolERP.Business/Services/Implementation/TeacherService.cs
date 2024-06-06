using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System.ComponentModel;

namespace SchoolERP.Business.Services.Implementation
{
    public class TeacherService : ITeacherService  
    {
        public void Create(Teacher teacher)
        {
            SchoolERPDataBase.Teachers.Add(teacher);
        }

        public List<Teacher> GetAll()
        {
            return SchoolERPDataBase.Teachers;
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacher(int id)
        {
            Teacher? wantedTeacher = SchoolERPDataBase.Teachers.Find(x => x.Id == id);

            if (wantedTeacher is not null)
            {
                return wantedTeacher;
            }
            else 
            
            { throw new NullReferenceException("Teacher is not found!"); }
        }

        public void Remove(int Id)
        {
            Teacher? wantedTeacher = SchoolERPDataBase.Teachers.Find(x => x.Id == Id);

            if (wantedTeacher is not null)
            {
                SchoolERPDataBase.Teachers.Remove(wantedTeacher);
            }
            else 
            
            { throw new NullReferenceException("Teacher is not found!"); }
        }

        //public void RemoveAllStudents(int teacherId)
        //{
        //    Student 
        //}
    }
}
