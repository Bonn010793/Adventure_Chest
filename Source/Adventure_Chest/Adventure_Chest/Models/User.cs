using System;
namespace Adventure_Chest.Models
{
	public class User
	{
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }

        public User()
		{
		}
	}
}

