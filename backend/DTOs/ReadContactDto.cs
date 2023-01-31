namespace API.DTOs
{
    public class ReadContactDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BillingAddress { get; set; }
        public string PhysicalAddress { get; set; }
    }
}
