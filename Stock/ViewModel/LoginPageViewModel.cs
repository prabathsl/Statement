using log4net;
using Stock.Helpers;
using Stock.Model;
using Stock.Repository;
using Stock.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Stock.ViewModel
{
    public class LoginPageViewModel :MvvmBase
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(LoginPageViewModel));

        private LoginModel _loginDetails { get; set; }
        public LoginModel LoginDetails
        {
            get { return _loginDetails; }
            set
            {
                _loginDetails = value;
                OnPropertyChanged("LoginDetails");
            }
        }
        public string UserName
        {
            get { return _loginDetails.UserName; }
            set
            {
                _loginDetails.UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        private UserRepository _userOperations { get; set; }

        #region Commands
        public ICommand LoginClick { get; set; }

        #endregion


        public LoginPageViewModel()
        {
            this.LoginClick = new CustomCommand(Login_Btn_Click);
            this._loginDetails = new LoginModel();
            this._userOperations = new UserRepository();
        }

        public async void Login_Btn_Click(object param)
        {
            _log.Info("Login Button clicked");
            string TempPassword= ((PasswordBox)param).Password;
            _loginDetails.PasswordHash = OneWayHash.SHA256(TempPassword);
            _log.Info(_loginDetails);


            Result = await _userOperations.UserLoginAsync(this._loginDetails);
        }
      
    }
}
