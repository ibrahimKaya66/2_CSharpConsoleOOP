namespace _5_OOPInheritanceOr
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public Employee(int id, string name, string surname, Gender gender) : this(id, name, surname)
        {
            this.Gender = gender;
        }
    }

    public enum Gender
    {
        UnKnow,
        Male,
        Female
    }
}