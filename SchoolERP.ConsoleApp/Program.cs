using SchoolERP.Business.Services.Implementation;
using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using System.Threading.Channels;

namespace SchoolERP.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ITeacherService teacherService = new TeacherService();
            //Teacher teacher = new Teacher();
            //teacher.FullName = "Lale Namazova";
            //teacher.Id = 1;
            //teacher.Salary = 1000;
            //Teacher teacher1 = new Teacher();
            //teacher1.FullName = "Arif Aliyev";
            //teacher1.Id = 2;
            //teacher1.Salary = 2000;
            //teacherService.Create(teacher);
            //teacherService.Create(teacher1);

            //teacherService.GetAll().ForEach(x => Console.WriteLine(x.FullName));

            //Console.WriteLine("After Remove");
            //teacherService.Remove(2);
            //teacherService.GetAll().ForEach(x => Console.WriteLine(x.FullName));

            //Console.WriteLine(teacherService.GetTeacher(1).FullName);

            ITeacherService teacherService = new TeacherService();
            IStudentService studentService = new StudentService();

            teacherService.Create(new Teacher() { FullName = "Lale Namazova", Salary = 1000 });
            Teacher teacher = null;
            try
            {
                teacher = teacherService.GetTeacher(1);
                Console.WriteLine(teacher);
            }
            catch (NullReferenceException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //try
            //{
            //    teacherService.Remove(1);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            Student student = new Student()
            {
                FullName = "Ilaha Hasanova",
                Grade = 100,
                Teacher = teacher,

            };

            studentService.Create(student);
            studentService.GetAll().ForEach(x => Console.WriteLine(x));
            teacher.Students.Add(student);
            teacherService.Remove(1);
            Console.WriteLine("Teacher's students");
            teacher.Students.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Students' teacher even after removing");
            Console.WriteLine(student.Teacher.FullName);
            Console.WriteLine(studentService.GetStudentByTeacherId(1));
            Console.WriteLine("I did it at the end!");
            studentService.AllRemoveStudentByTeacherId(1);
            
            try
            {
                studentService.Remove(1);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
