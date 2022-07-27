namespace EntityRelationship.Model
{
    public class Charecter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = string.Empty;
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
