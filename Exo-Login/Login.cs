using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Login
{
    internal class Login
    {
        private string _email;
        private string _password;

        public event EventHandler LoginOkEvent = null;
        public event EventHandler LoginNotOkEvent = null;

        public Login(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public void CheckLogin(string email, string password)
        {
            if (_email == email && _password == password) LoginOkEvent?.Invoke(this, EventArgs.Empty);
            else LoginNotOkEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
