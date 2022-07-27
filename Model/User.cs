namespace EntityRelationship.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = String.Empty;
        public List<Charecter> Charecters { get; set; }
    }
}
