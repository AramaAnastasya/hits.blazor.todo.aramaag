namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int ID { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }
        public DateTime? CratedDate { get; set; }
        public DateTime? FInishdDate { get; set; }

    }
}
