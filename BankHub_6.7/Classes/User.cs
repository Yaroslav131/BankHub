namespace BankHub_6._7
{
    public class User
    {
        public int Id { get; set; }
        public string AvatarImage { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool BlockStatus { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public User()
        {
        }

        public User(string name, string lastName, string mail, string phone, string password, string avatarImage)
        {
            BlockStatus = false;
            AvatarImage = avatarImage;
            Name = name;
            LastName = lastName;
            Mail = mail;
            Phone = phone;
            Password = password;
        }
    }
}
