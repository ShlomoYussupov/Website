namespace Website.BLL.Helpers
{
    using Dto;
    using DAL.EF;
    using System.Linq;
    using DAL.Entities;
    using System.Collections.Generic;

    public class FillObject
    {
        public Message Message(MessageDto dto)
        {
            return new Message
            {
                Id = dto.Id,
                Attachment = dto.Attachment,
                IsRead = dto.IsRead,
                SenderId = dto.SenderId,
                RecipientId = dto.RecipientId,
                SendingDate = dto.SendingDate,
                Subject = dto.Subject,
                TextMessage = dto.TextMessage,
                Title = dto.Title
            };
        }

        public IEnumerable<Message> MessageList()
        {
            var list = db.Messages.ToList();
        }
    }
}
