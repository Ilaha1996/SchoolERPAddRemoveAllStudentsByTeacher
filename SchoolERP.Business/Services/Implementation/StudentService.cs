using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Services.Implementation
{
    public class StudentService : IStudentService
    {
        public void AllRemoveStudentByTeacherId(int TeacherId)
        {           
            SchoolERPDataBase.Students.RemoveAll(x => x.Teacher.Id == TeacherId);          
        }

        public void Create(Student student)
        {
            SchoolERPDataBase.Students.Add(student);
        }

        public List<Student> GetAll()
        {
            return SchoolERPDataBase.Students;
        }

        public Student GetStudent(int id)
        {
            Student? wantedStudent = SchoolERPDataBase.Students.Find(x => x.Id == id);

            if (wantedStudent is not null)
            {
                return wantedStudent;
            }
            else 
            
            { throw new NullReferenceException("Student is not found!"); }
        }

        public Student GetStudentByTeacherId(int TeacherId)
        {
            Student? wantedStudent = SchoolERPDataBase.Students.Find(x => x.Teacher.Id == TeacherId);

            if (wantedStudent is not null)
            {
                return wantedStudent;
            }
            else

            { throw new NullReferenceException("Student is not found!"); }
        }

        public void Remove(int Id)
        {
            Student? wantedStudent = SchoolERPDataBase.Students.Find(x => x.Id == Id);

            if (wantedStudent is not null)
            {
                SchoolERPDataBase.Students.Remove(wantedStudent);
            }
            else 
            
            { throw new NullReferenceException("Student is not found!"); }
        }

        public void RemoveStudentByTeacherId(int TeacherId)
        {
            Student? wantedStudent = SchoolERPDataBase.Students.Find(x => x.Teacher.Id == TeacherId);

            if (wantedStudent is not null)
            {
                SchoolERPDataBase.Students.Remove(wantedStudent);
            }
            else

            { throw new NullReferenceException("Student is not found!"); }


            
        }
    }
}
