namespace Website.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string TextMessage { get; set; }
        public int RecipientId { get; set; }
        public int SenderId { get; set; }
        public System.DateTime SendingDate { get; set; }
        public bool IsRead { get; set; }
        public string Attachment { get; set; }
    }
}
