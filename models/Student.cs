namespace _5pks.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Performance> Performances { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
    }
}
