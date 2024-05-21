namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager("1", "Ahmet", false);

    }

    public class Musteri
    {
        public class Musteri
        {
            
        }
        public Musteri(string id, string name, bool isDeleted)
        {
            this.Id = id;
            this.Name = name;
            this.isDeleted = isDeleted;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
    }
}