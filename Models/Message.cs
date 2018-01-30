using System;
using System.Collections.Generic;

namespace TollBot.Models
{
    public class Message : Entity{
        public string App { get; set; }
        public long Sent { get; set; }
        public string Uuid { get; set; }
        public List<Tag> Tags { get; set; }
        public int To { get; set; }
        public string Event { get; set; }
        public string Content { get; set; }
        public List<Attachment> Attachments { get; set; }
        public int User { get; set; }
        public DateTime Created_at { get; set; }

//         {
//   "event": "message",
//   "content": "Howdy-Doo @Jackie #awesome"
// }

    // "app": "chat",
    // "sent": 1317397485508,
    // "uuid": "odHapx1VWp7WTrdQ",
    // "tags": [],
    // "to": "42",
    // "id": 3816534,
    // "event": "message",
    // "content": "Secret message",
    // "attachments": [],
    // "user": "2",
    // "created_at": "2011-09-30T15:44:45.507Z"
    }
}