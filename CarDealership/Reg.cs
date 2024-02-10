using System;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class Reg : Form
    {
        string surname;
        string name;
        string last_name;
        string phone;
        string email;
        string login;
        string password1;
        string password2;
        public Reg()
        {
            InitializeComponent();
        }

        // Функция обработки события закрытия формы нажатием кнопки "Х".
        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Auth window = new Auth();
            window.Show();
        }

        // Функция обработки события нажатия кнопки "Зарегистрироваться".
        private void RegButton_Click(object sender, EventArgs e)
        {
            surname = surnameTextBox.Text;
            name = nameTextBox.Text;
            last_name = lastnameTextBox.Text;
            phone = phoneTextBox.Text;
            email = emailTextBox.Text;
            login = loginTextBox.Text;
            password1 = password1TextBox.Text;
            password2 = password2TextBox.Text;

            ClassLibrary.Reg Reg = new ClassLibrary.Reg();

            if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool log = Reg.GetClientExistence(login, phone, email);
                if (surname == "" || name == "" || last_name == "" || phone == "+7 (   )    -" || email == "" || login == "" || password1 == "" || password2 == "")
                {
                    MessageBox.Show("Пожалуйста, введите все данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (log == false)
                {
                    MessageBox.Show("Такой пользователь уже существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Reg.InsertClient(surname, name, last_name, phone, email, login, password1);
                    MessageBox.Show("Вы зарегистрированы!", "Внимание!", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
