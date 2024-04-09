using UserAccountModel;

namespace UserAccountDataService
{
    public class UserDataService
    {
        List<User> dummyUsers = new List<User>();

        public UserDataService()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            User user1 = new User { username = "rodkirstenbayran", password = "rkb" };
            User user2 = new User { username = "rodkirsten", password = "isten" };
            User user3 = new User { username = "rod", password = "rkb1104" };

            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);

        }

        public User GetUser(string username, string password)
        {
            User foundUser = new User();

            foreach (var dummy in dummyUsers)
            {
                if (username == dummy.username && password == dummy.password)
                {
                    foundUser = dummy;
                }
            }

            return foundUser;
        }
    }
}

