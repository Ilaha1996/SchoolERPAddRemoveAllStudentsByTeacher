namespace SchoolERP.Core.Models
{
    public class Student: BaseModel
    {
        private static int _counter;
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public double Grade { get; set; }
        public Teacher Teacher = new Teacher();

        public Student()
        {
            Id = ++_counter;
        }

        public override string ToString()
        {
            return $"{Id} - {FullName} - {Grade} - {Teacher.FullName}";
        }
    }
}
