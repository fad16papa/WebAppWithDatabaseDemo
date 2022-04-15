namespace WebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Employee()
        {
            Fullname = string.Empty;
            Department = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
        }
    }
}
