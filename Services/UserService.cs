using HomeWork.Models;

namespace HomeWork.Services
{
    public class UserService
    {
        public UserService()
        {
            Init();
        }

        public User User { get; private set; }

        private void Init()
        {
            User = new User()
            {
                FullName = "John Smith",
                Phone = "0505555050",
                Email = "email@gmail.com"
            };
        }
    }
}