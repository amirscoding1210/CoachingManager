using Coaching_Manager;
using CoachingCenterApp.Services;
using CoachingCenterApp.Helpers;
using System.Windows.Input;

namespace CoachingCenterApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly AuthService _authService;

        public LoginViewModel()
        {
            _authService = new AuthService();
            LoginCommand = new RelayCommand(Login);
        }

        private string _username = string.Empty;
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        private string _errorMessage = string.Empty;
        public string ErrorMessage
        {
            get => _errorMessage;
            set { _errorMessage = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }

        private void Login(object obj)
        {
            if (_authService.ValidateCredentials(Username, Password))
            {
                ErrorMessage = string.Empty;

                var mainWindow = new MainWindow();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = mainWindow;
                mainWindow.Show();
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
        }
    }
}
