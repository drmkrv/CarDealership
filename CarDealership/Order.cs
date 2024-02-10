using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class Order : Form
    {
        int cost = 0;
        int index1 = 0;
        int index2 = 0;
        int IDClient;
        public Order(int Client)
        {
            IDClient = Client;
            InitializeComponent();
        }

        // Функция обработки события загрузки формы.
        private void Order_Load(object sender, EventArgs e)
        {
            ClassLibrary.Order Order = new ClassLibrary.Order();
            List<string> brands = Order.Brand();
            List<string> colors = Order.Color();
            List<string> colorsinterior = Order.ColorInterior();

            for (int i = 0; i < brands.Count; i++) this.brandComboBox.Items.Add(brands[i]);
            for (int i = 0; i < colors.Count; i++) this.colorComboBox.Items.Add(colors[i]);
            for (int i = 0; i < colorsinterior.Count; i++) this.colorInteriorComboBox.Items.Add(colorsinterior[i]);
        }
        
        // Функция обработки события выбора марки в комбобоксе.
        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modelComboBox.Items.Clear();

            ClassLibrary.Order Order = new ClassLibrary.Order();
            List<string> models = Order.Model(this.brandComboBox.Text);
            for (int i = 0; i < models.Count; i++) this.modelComboBox.Items.Add(models[i]);
        }

        // Функция обработки события нажатия кнопки "Заказать".
        private void OrderAddBtn_Click(object sender, EventArgs e)
        {
            ClassLibrary.Order Order = new ClassLibrary.Order();
            int conditioner;
            int powerwindows;

            if (brandComboBox.Text != "" || modelComboBox.Text != "")
            {
                if (conditionerComboBox.Text == "Да") conditioner = 1;
                else conditioner = 0;
                if (powerWindowsComboBox.Text == "Да") powerwindows = 1;
                else powerwindows = 0;
                Order.NewOrder(Order.GetBrand(brandComboBox.Text), Order.GetModel(modelComboBox.Text), Order.GetColor(colorComboBox.Text), Order.GetColorInterior(colorInteriorComboBox.Text), conditioner, powerwindows, cost, IDClient);
            }
        }

        // Функция обработки события выбора модели в комбобоксе.
        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassLibrary.Order Order = new ClassLibrary.Order();
            cost = Order.GetCost(modelComboBox.Text);
            if (conditionerComboBox.Text == "Да") cost += 50000;
            if (powerWindowsComboBox.Text == "Да") cost += 5000;
            costLabel.Text = cost + " руб.";
        }

        // Функция обработки события выбора наличия кондиционера в комбобоксе.
        private void conditionerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conditionerComboBox.Text == "Да")
            {
                index1 = 1;
                cost += 50000;
            }
            else
            {
                if (index1 != 1) cost = cost;
                else cost -= 50000;
            }
            costLabel.Text = cost + " руб.";
        }

        // Функция обработки события выбора наличия стеклоподъёмников в комбобоксе.
        private void powerWindowsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (powerWindowsComboBox.Text == "Да")
            {
                index2 = 1;
                cost += 5000;
            }
            else
            {
                if (index2 != 1) cost = cost;
                else cost -= 5000;
            }
            costLabel.Text = cost + " руб.";
        }

        // Функция обработки события закрытия формы нажатием кнопки "X".
        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
