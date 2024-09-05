namespace bmsgateway.models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}