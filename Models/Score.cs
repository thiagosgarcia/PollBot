using System;

namespace TollBot.Models
{
    public class Score : Entity
    {
        public User User { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}