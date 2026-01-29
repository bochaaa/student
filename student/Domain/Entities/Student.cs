namespace student.Domain.Entities;

    public class Student
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
