namespace WebAppPractice.Models
{
    public class TodoContext
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
