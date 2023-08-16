namespace Website.BLL.Dto
{
    using System.ComponentModel.DataAnnotations;
    using System.Security.Permissions;

    public class MessageDto
    {
        [Key]
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
