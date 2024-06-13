namespace _5pks.models
{
    public class Performance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Semester { get; set; }
        public string Subject { get; set; }
        public string Grade { get; set; }

        public Student Student { get; set; }
    }
}
