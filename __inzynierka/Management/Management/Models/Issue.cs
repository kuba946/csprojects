
namespace Management.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
        public Issue? Parent { get; set; }
        public int? ParentId { get; set; }
        public bool isProject { get; set; }
        public ApplicationUser? Assignee { get; set; }
        public string? AssigneeId { get; set; }
        public Issue(string name, DateTime? start, DateTime? end, int? duration, string? description, Status status, Issue? parent, ApplicationUser assignee)
        {
            Name = name;
            Created = DateTime.Now;
            Start = start;
            End = end;
            Duration = duration;
            Description = description;
            Status = status;
            Parent = parent;
            if (Parent != null) { isProject = true; }
            else { isProject = false; }
            Assignee = assignee;
        }
        public Issue() { }
        public Issue(string name)
        {
            Name = name;
        }
    }
}
