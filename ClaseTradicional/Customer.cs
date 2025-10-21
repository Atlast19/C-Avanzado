namespace ClaseTradicional
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public Customer()  {}

        public Customer(int Id, string Name, string Email, DateTime CreatedAt)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.CreatedAt = CreatedAt;
        }
    }

}
