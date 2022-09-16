
namespace Management.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Issue>? Issues { get; set; }

        public Status(string name)
        {
            Name = name;
        }
        public Status() { }
    }
}
