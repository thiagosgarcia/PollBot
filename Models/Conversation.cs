

using System.Collections.Generic;

namespace TollBot.Models
{
    public class Conversation : Entity
    {

        public string Url { get; set; }
        public string Name { get; set; }
        public bool Open { get; set; }
        public Activity Activity { get; set; }
        public List<User> Users { get; set; }

        public Conversation()
        {
            Users = new List<User>();
        }

        //  "id": 42,
        // "url": "https://api.flowdock.com/private/42",
        // "name": "@Hubot",
        // "open": true,
        // "activity": {
        //   "inbox": false,
        //   "mentions": 0,
        //   "chat": false
        // },
        // "users": [{
        //   "id": 2,
        //   "nick": "Antti",
        //   "email": "antti@flowdock.com",
        //   "avatar": "https://api.flowdock.com/avatars/667bc62d0ba333c684f0466d7a30a724/",
        //   "name": "Antti Pitkänen"
        // }, {
        //   "id": 42,
        //   "nick": "Hubot",
        //   "email": "hubot@flowdock.com",
        //   "avatar": "https://api.flowdock.com/avatars/821d585f52de5455c26dca68e9e70e77/",
        //   "name": "Hubot Hubot"
        // }]
    }
}