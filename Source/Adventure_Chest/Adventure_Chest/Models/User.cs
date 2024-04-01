using System;
namespace Adventure_Chest.Models
{
	public class User
	{
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime Birthday { get; set; }

        public User()
		{
		}
	}
}

