namespace TollBot.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Avatar { get; set; }

        //     "id": 2,
        //   "nick": "Antti",
        //   "email": "antti@flowdock.com",
        //   "avatar": "https://api.flowdock.com/avatars/667bc62d0ba333c684f0466d7a30a724/",
        //   "name": "Antti Pitkänen"
    }
}