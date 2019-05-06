namespace Session08.StateManager
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
