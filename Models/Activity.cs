
namespace TollBot.Models
{
    public class Activity : Entity
    {
        public bool Inbox { get; set; }
        public int mentions { get; set; }
        public bool Chat { get; set; }

        // "activity": {
        //   "inbox": false,
        //   "mentions": 0,
        //   "chat": false
        // },
    }
}