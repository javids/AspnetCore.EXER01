namespace Session08.StateManager
{
    public class JobData
    {
        public int JobDataId { get; set; }
        public string Title { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
