using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSwap.Shared.Domain
{
    public class ChatMessage : BaseDomainModel
    {
        public string? Sender { get; set; }
        public string? Message { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? ConversationId { get; set; }
        public virtual Conversation? Coversation { get; set; }
    }
}
