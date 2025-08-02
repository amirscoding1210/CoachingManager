using Coaching_Manager;
using CoachingCenterApp.Services;
using CoachingCenterApp.Helpers;
using CoachingCenterApp.Views.Login;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoachingCenterApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly AuthService _authService;
        private PasswordBox _passwordBox;

        public LoginViewModel()
        {
            _authService = new AuthService();
            LoginCommand = new RelayCommand(Login);
            TogglePasswordCommand = new RelayCommand(_ => TogglePassword());
            ForgotPasswordCommand = new RelayCommand(_ => { /* Implementation */ });
            SignUpCommand = new RelayCommand(_ => { /* Implementation */ });
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

        private bool _rememberMe;
        public bool RememberMe
        {
            get => _rememberMe;
            set { _rememberMe = value; OnPropertyChanged(); }
        }

        private bool _isPasswordVisible;
        public bool IsPasswordVisible
        {
            get => _isPasswordVisible;
            set
            {
                _isPasswordVisible = value;
                OnPropertyChanged();
                if (value && _passwordBox != null)
                {
                    Password = _passwordBox.Password;
                }
            }
        }

        public PasswordBox PasswordBox
        {
            get => _passwordBox;
            set
            {
                _passwordBox = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand TogglePasswordCommand { get; }
        public ICommand ForgotPasswordCommand { get; }
        public ICommand SignUpCommand { get; }

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

        private void TogglePassword()
        {
            IsPasswordVisible = !IsPasswordVisible;
        }
    }
}