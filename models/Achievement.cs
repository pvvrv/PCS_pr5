namespace _5pks.models
{
    public class Achievement
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public Student Student { get; set; }
    }
}
