namespace CarDealership
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label colorInteriorLabel;
            System.Windows.Forms.Label conditionerLabel;
            System.Windows.Forms.Label powerWindowsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.carDealershipDataSet = new CarDealership.CarDealershipDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new CarDealership.CarDealershipDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new CarDealership.CarDealershipDataSetTableAdapters.TableAdapterManager();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorInteriorComboBox = new System.Windows.Forms.ComboBox();
            this.conditionerComboBox = new System.Windows.Forms.ComboBox();
            this.powerWindowsComboBox = new System.Windows.Forms.ComboBox();
            this.OrderAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            colorInteriorLabel = new System.Windows.Forms.Label();
            conditionerLabel = new System.Windows.Forms.Label();
            powerWindowsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.BackColor = System.Drawing.Color.Transparent;
            brandLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            brandLabel.Location = new System.Drawing.Point(33, 61);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(70, 22);
            brandLabel.TabIndex = 23;
            brandLabel.Text = "Марка:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelLabel.Location = new System.Drawing.Point(33, 99);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(80, 22);
            modelLabel.TabIndex = 24;
            modelLabel.Text = "Модель:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            colorLabel.Location = new System.Drawing.Point(33, 137);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(114, 22);
            colorLabel.TabIndex = 25;
            colorLabel.Text = "Цвет кузова:";
            // 
            // colorInteriorLabel
            // 
            colorInteriorLabel.AutoSize = true;
            colorInteriorLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            colorInteriorLabel.Location = new System.Drawing.Point(33, 175);
            colorInteriorLabel.Name = "colorInteriorLabel";
            colorInteriorLabel.Size = new System.Drawing.Size(122, 22);
            colorInteriorLabel.TabIndex = 26;
            colorInteriorLabel.Text = "Цвет салона:";
            // 
            // conditionerLabel
            // 
            conditionerLabel.AutoSize = true;
            conditionerLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            conditionerLabel.Location = new System.Drawing.Point(33, 213);
            conditionerLabel.Name = "conditionerLabel";
            conditionerLabel.Size = new System.Drawing.Size(133, 22);
            conditionerLabel.TabIndex = 27;
            conditionerLabel.Text = "Кондиционер:";
            // 
            // powerWindowsLabel
            // 
            powerWindowsLabel.AutoSize = true;
            powerWindowsLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            powerWindowsLabel.Location = new System.Drawing.Point(33, 251);
            powerWindowsLabel.Name = "powerWindowsLabel";
            powerWindowsLabel.Size = new System.Drawing.Size(170, 22);
            powerWindowsLabel.TabIndex = 28;
            powerWindowsLabel.Text = "Стеклоподъёмник:";
            // 
            // carDealershipDataSet
            // 
            this.carDealershipDataSet.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ColorInteriorTableAdapter = null;
            this.tableAdapterManager.ColorTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarDealership.CarDealershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brandComboBox
            // 
            this.brandComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Brand", true));
            this.brandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandComboBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(209, 56);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(181, 30);
            this.brandComboBox.TabIndex = 2;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Model", true));
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelComboBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(209, 94);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(181, 30);
            this.modelComboBox.TabIndex = 4;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // colorComboBox
            // 
            this.colorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Color", true));
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorComboBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(209, 132);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(181, 30);
            this.colorComboBox.TabIndex = 6;
            // 
            // colorInteriorComboBox
            // 
            this.colorInteriorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ColorInterior", true));
            this.colorInteriorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorInteriorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorInteriorComboBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.colorInteriorComboBox.FormattingEnabled = true;
            this.colorInteriorComboBox.Location = new System.Drawing.Point(209, 170);
            this.colorInteriorComboBox.Name = "colorInteriorComboBox";
            this.colorInteriorComboBox.Size = new System.Drawing.Size(181, 30);
            this.colorInteriorComboBox.TabIndex = 8;
            // 
            // conditionerComboBox
            // 
            this.conditionerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Conditioner", true));
            this.conditionerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionerComboBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.conditionerComboBox.FormattingEnabled = true;
            this.conditionerComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.conditionerComboBox.Location = new System.Drawing.Point(209, 208);
            this.conditionerComboBox.Name = "conditionerComboBox";
            this.conditionerComboBox.Size = new System.Drawing.Size(181, 30);
            this.conditionerComboBox.TabIndex = 10;
            this.conditionerComboBox.SelectedIndexChanged += new System.EventHandler(this.conditionerComboBox_SelectedIndexChanged);
            // 
            // powerWindowsComboBox
            // 
            this.powerWindowsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "PowerWindows", true));
            this.powerWindowsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.powerWindowsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerWindowsComboBox.Font = new System.Drawing.Font("Montserrat", 12F);
            this.powerWindowsComboBox.FormattingEnabled = true;
            this.powerWindowsComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.powerWindowsComboBox.Location = new System.Drawing.Point(209, 246);
            this.powerWindowsComboBox.Name = "powerWindowsComboBox";
            this.powerWindowsComboBox.Size = new System.Drawing.Size(181, 30);
            this.powerWindowsComboBox.TabIndex = 12;
            this.powerWindowsComboBox.SelectedIndexChanged += new System.EventHandler(this.powerWindowsComboBox_SelectedIndexChanged);
            // 
            // OrderAddBtn
            // 
            this.OrderAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderAddBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderAddBtn.Location = new System.Drawing.Point(113, 347);
            this.OrderAddBtn.Name = "OrderAddBtn";
            this.OrderAddBtn.Size = new System.Drawing.Size(191, 56);
            this.OrderAddBtn.TabIndex = 13;
            this.OrderAddBtn.Text = "Заказать";
            this.OrderAddBtn.UseVisualStyleBackColor = true;
            this.OrderAddBtn.Click += new System.EventHandler(this.OrderAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "___________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "___________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "___________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "___________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "___________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mont Heavy DEMO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Стоимость:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Mont Heavy DEMO", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(153, 298);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(21, 22);
            this.costLabel.TabIndex = 35;
            this.costLabel.Text = "0";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 458);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.colorInteriorComboBox);
            this.Controls.Add(this.conditionerComboBox);
            this.Controls.Add(this.powerWindowsComboBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(modelLabel);
            this.Controls.Add(colorLabel);
            this.Controls.Add(colorInteriorLabel);
            this.Controls.Add(conditionerLabel);
            this.Controls.Add(powerWindowsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderAddBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ автомобиля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarDealershipDataSet carDealershipDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private CarDealershipDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private CarDealershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox colorInteriorComboBox;
        private System.Windows.Forms.ComboBox conditionerComboBox;
        private System.Windows.Forms.ComboBox powerWindowsComboBox;
        private System.Windows.Forms.Button OrderAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label costLabel;
    }
}