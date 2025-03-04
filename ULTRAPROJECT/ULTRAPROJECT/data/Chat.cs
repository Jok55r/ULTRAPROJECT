public class Chat
{
    public string name {get; set;}
    public List<User> participants = new List<User>();
    public List<Message> messages = new List<Message>();
}