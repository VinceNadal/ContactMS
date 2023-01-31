namespace API.DTOs
{
    public class CreateContactDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BillingAddress { get; set; }
        public string PhysicalAddress { get; set; }
    }
}
