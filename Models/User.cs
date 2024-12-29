namespace CodeFirstRelation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public string Emil { get; set; } = "";
        public List<Post> Posts { get; set; }=new List<Post>();//bir usureıb birden fazla postu olabilr
    }
}
