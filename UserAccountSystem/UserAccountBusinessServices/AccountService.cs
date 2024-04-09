using UserAccountDataService;

namespace UserAccountBusinessServices
{
    public class AccountService
    {
        public bool VerifyUser (string username, string password)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetUser(username, password);
                
            return result.username != null ? true : false;
            return result.password != null ? true : false;  

        }
    }
}
