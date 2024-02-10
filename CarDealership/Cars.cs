using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class Cars : Form
    {
        string pic;
        string brand;
        string model;
        string color;
        string colorinterior;
        int Client;
        public Cars(int IDClient)
        {
            Client = IDClient;
            InitializeComponent();
        }

        // Функция обработки события загрузки формы.
        private void Cars_Load(object sender, EventArgs e)
        {
            this.carTableAdapter.Fill(this.carDealershipDataSet.Car);
            GetInfo();
        }

        // Функция обработки события нажатия кнопок переключения.
        private void bindingNavigatorMove_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        // Функция обработки события нажатия кнопки "Купить".
        private void BuyBtn_Click(object sender, EventArgs e)
        {
            ClassLibrary.Cars Cars = new ClassLibrary.Cars();
            Cars.SoldCar(Client, iD_CarTextBox.Text);
            this.Cars_Load(sender, e);
            MessageBox.Show("Покупка оформлена!", "Внимание!", MessageBoxButtons.OK);
        }

        // Функция обработки события нажатия кнопки "Заказать".
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Order window = new Order(Client);
            window.ShowDialog();
        }

        // Функция обработки события закрытия формы нажатием кнопки "Х".
        private void Cars_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Auth window = new Auth();
            window.Show();
        }

        // Функция получения информации об автомобиле.
        private void GetInfo()
        {
            ClassLibrary.Cars Cars = new ClassLibrary.Cars();

            pic = this.photoTextBox.Text;
            if (this.photoTextBox.Text == "")
            {
                this.photoPictureBox.Image = Properties.Resources.errorPhoto;
            }
            else
            {
                this.photoPictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + pic);
            }

            brand = this.brandTextBox.Text;
            model = this.modelTextBox.Text;
            color = this.colorTextBox.Text;
            colorinterior = this.colorInteriorTextBox.Text;
            if (Cars.GetBrand(brand) != null)
            {
                this.brandTextBox.Text = Cars.GetBrand(brand);
            }
            if (Cars.GetModel(model) != null)
            {
                this.modelTextBox.Text = Cars.GetModel(model);
            }
            this.colorTextBox.Text = Cars.GetColor(color);
            this.colorInteriorTextBox.Text = Cars.GetColorInterior(colorinterior);

            if (this.conditionerTextBox.Text == "0")
            {
                this.conditionerTextBox.Text = "Нет";
            }
            else
            {
                this.conditionerTextBox.Text = "Да";
            }
            if (this.powerWindowsTextBox.Text == "0")
            {
                this.powerWindowsTextBox.Text = "Нет";
            }
            else
            {
                this.powerWindowsTextBox.Text = "Да";
            }
        }
    }
}
