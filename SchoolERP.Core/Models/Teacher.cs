namespace SchoolERP.Core.Models
{
    public class Teacher: BaseModel
    {
        private static int _counter;
        public string FullName { get; set; }
        public double Salary { get; set; }

        public List<Student> Students = new List<Student>();

        public Teacher()
        {
            Id = ++_counter;
        }

        public override string ToString()
        {
            return $"{Id} - {FullName} - {Salary}";
        }
    }
}
