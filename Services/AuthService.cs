namespace CoachingCenterApp.Services
{
    public class AuthService
    {
        public bool ValidateCredentials(string username, string password)
        {
            // Temporary logic — later replace with DB call
            return username == "admin" && password == "1234";
        }
    }
}
