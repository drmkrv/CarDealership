using System;
using System.Windows.Forms;
using CarDealership.Properties;

namespace CarDealership
{
    public partial class Auth : Form
    {
        static public string login;
        static public string password;
        public Auth()
        {
            InitializeComponent();
        }

        // Функция обработки события нажатия кнопки "Авторизация".
        private void LogInButton_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Пожалуйста, введите логин и/или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClassLibrary.Auth cl_auth = new ClassLibrary.Auth();
                object IDclient = cl_auth.LogInFunc(login, password);

                if (IDclient != null)
                {
                    this.Hide();
                    Cars window = new Cars(Convert.ToInt32(IDclient));
                    window.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Функция обработки события нажатия кнопки "Посмотреть/скрыть пароль"
        private void VisiblePassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                VisiblePassBtn.BackgroundImage = Resources.passVis;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                VisiblePassBtn.BackgroundImage = Resources.passInvis;
            }
        }

        // Функция обработки события нажатия кнопки "Зарегистрироваться".
        public void RegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg window = new Reg();
            window.Show();
        }

        // Функция обработки события закрытия формы нажатием кнопки "Х".
        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
