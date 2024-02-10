namespace CarDealership
{
    partial class Cars
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_CarLabel;
            System.Windows.Forms.Label powerWindowsLabel;
            System.Windows.Forms.Label conditionerLabel;
            System.Windows.Forms.Label colorInteriorLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.carDealershipDataSet = new CarDealership.CarDealershipDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.carTableAdapter = new CarDealership.CarDealershipDataSetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new CarDealership.CarDealershipDataSetTableAdapters.TableAdapterManager();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.iD_CarTextBox = new System.Windows.Forms.TextBox();
            this.powerWindowsTextBox = new System.Windows.Forms.TextBox();
            this.conditionerTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorInteriorTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            iD_CarLabel = new System.Windows.Forms.Label();
            powerWindowsLabel = new System.Windows.Forms.Label();
            conditionerLabel = new System.Windows.Forms.Label();
            colorInteriorLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).BeginInit();
            this.carBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CarLabel
            // 
            iD_CarLabel.AutoSize = true;
            iD_CarLabel.Location = new System.Drawing.Point(22, -48);
            iD_CarLabel.Name = "iD_CarLabel";
            iD_CarLabel.Size = new System.Drawing.Size(40, 13);
            iD_CarLabel.TabIndex = 1;
            iD_CarLabel.Text = "ID Car:";
            // 
            // powerWindowsLabel
            // 
            powerWindowsLabel.AutoSize = true;
            powerWindowsLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            powerWindowsLabel.Location = new System.Drawing.Point(26, 303);
            powerWindowsLabel.Name = "powerWindowsLabel";
            powerWindowsLabel.Size = new System.Drawing.Size(170, 22);
            powerWindowsLabel.TabIndex = 13;
            powerWindowsLabel.Text = "Стеклоподъёмник:";
            // 
            // conditionerLabel
            // 
            conditionerLabel.AutoSize = true;
            conditionerLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            conditionerLabel.Location = new System.Drawing.Point(26, 265);
            conditionerLabel.Name = "conditionerLabel";
            conditionerLabel.Size = new System.Drawing.Size(133, 22);
            conditionerLabel.TabIndex = 11;
            conditionerLabel.Text = "Кондиционер:";
            // 
            // colorInteriorLabel
            // 
            colorInteriorLabel.AutoSize = true;
            colorInteriorLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            colorInteriorLabel.Location = new System.Drawing.Point(26, 227);
            colorInteriorLabel.Name = "colorInteriorLabel";
            colorInteriorLabel.Size = new System.Drawing.Size(122, 22);
            colorInteriorLabel.TabIndex = 9;
            colorInteriorLabel.Text = "Цвет салона:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            colorLabel.Location = new System.Drawing.Point(26, 189);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(114, 22);
            colorLabel.TabIndex = 7;
            colorLabel.Text = "Цвет кузова:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            modelLabel.Location = new System.Drawing.Point(26, 151);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(80, 22);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Модель:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.BackColor = System.Drawing.Color.Transparent;
            brandLabel.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            brandLabel.Location = new System.Drawing.Point(26, 113);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(70, 22);
            brandLabel.TabIndex = 3;
            brandLabel.Text = "Марка:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(72, -48);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 16;
            photoLabel.Text = "Photo:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(116, -42);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 25;
            statusLabel.Text = "Status:";
            // 
            // carDealershipDataSet
            // 
            this.carDealershipDataSet.DataSetName = "CarDealershipDataSet";
            this.carDealershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carDealershipDataSet;
            // 
            // carBindingNavigator
            // 
            this.carBindingNavigator.AddNewItem = null;
            this.carBindingNavigator.BindingSource = this.carBindingSource;
            this.carBindingNavigator.CountItem = null;
            this.carBindingNavigator.DeleteItem = null;
            this.carBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.carBindingNavigator.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.carBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.carBindingNavigator.Location = new System.Drawing.Point(552, 379);
            this.carBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carBindingNavigator.Name = "carBindingNavigator";
            this.carBindingNavigator.PositionItem = null;
            this.carBindingNavigator.Size = new System.Drawing.Size(93, 23);
            this.carBindingNavigator.TabIndex = 0;
            this.carBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ColorInteriorTableAdapter = null;
            this.tableAdapterManager.ColorTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarDealership.CarDealershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.carBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(447, 62);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(300, 300);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 16;
            this.photoPictureBox.TabStop = false;
            // 
            // iD_CarTextBox
            // 
            this.iD_CarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "ID_Car", true));
            this.iD_CarTextBox.Location = new System.Drawing.Point(115, -51);
            this.iD_CarTextBox.Name = "iD_CarTextBox";
            this.iD_CarTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CarTextBox.TabIndex = 2;
            // 
            // powerWindowsTextBox
            // 
            this.powerWindowsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.powerWindowsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "PowerWindows", true));
            this.powerWindowsTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerWindowsTextBox.Location = new System.Drawing.Point(197, 303);
            this.powerWindowsTextBox.Name = "powerWindowsTextBox";
            this.powerWindowsTextBox.ReadOnly = true;
            this.powerWindowsTextBox.Size = new System.Drawing.Size(180, 21);
            this.powerWindowsTextBox.TabIndex = 14;
            // 
            // conditionerTextBox
            // 
            this.conditionerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditionerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Conditioner", true));
            this.conditionerTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionerTextBox.Location = new System.Drawing.Point(197, 265);
            this.conditionerTextBox.Name = "conditionerTextBox";
            this.conditionerTextBox.ReadOnly = true;
            this.conditionerTextBox.Size = new System.Drawing.Size(180, 21);
            this.conditionerTextBox.TabIndex = 12;
            // 
            // brandTextBox
            // 
            this.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Brand", true));
            this.brandTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandTextBox.Location = new System.Drawing.Point(197, 113);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(180, 21);
            this.brandTextBox.TabIndex = 4;
            // 
            // modelTextBox
            // 
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(197, 151);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(180, 21);
            this.modelTextBox.TabIndex = 6;
            // 
            // colorInteriorTextBox
            // 
            this.colorInteriorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorInteriorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "ColorInterior", true));
            this.colorInteriorTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorInteriorTextBox.Location = new System.Drawing.Point(197, 227);
            this.colorInteriorTextBox.Name = "colorInteriorTextBox";
            this.colorInteriorTextBox.ReadOnly = true;
            this.colorInteriorTextBox.Size = new System.Drawing.Size(180, 21);
            this.colorInteriorTextBox.TabIndex = 10;
            // 
            // colorTextBox
            // 
            this.colorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Color", true));
            this.colorTextBox.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTextBox.Location = new System.Drawing.Point(197, 189);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(180, 21);
            this.colorTextBox.TabIndex = 8;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(116, -51);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(100, 20);
            this.photoTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "___________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "___________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "___________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "___________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "___________________________________________________________";
            // 
            // BuyBtn
            // 
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F);
            this.BuyBtn.Location = new System.Drawing.Point(30, 357);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(166, 33);
            this.BuyBtn.TabIndex = 23;
            this.BuyBtn.Text = "Купить";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Mont ExtraLight DEMO", 12F);
            this.OrderBtn.Location = new System.Drawing.Point(218, 357);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(166, 33);
            this.OrderBtn.TabIndex = 24;
            this.OrderBtn.Text = "Заказать";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(162, -45);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 26;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(iD_CarLabel);
            this.Controls.Add(this.iD_CarTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(colorInteriorLabel);
            this.Controls.Add(this.colorInteriorTextBox);
            this.Controls.Add(conditionerLabel);
            this.Controls.Add(this.conditionerTextBox);
            this.Controls.Add(powerWindowsLabel);
            this.Controls.Add(this.powerWindowsTextBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.carBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(819, 489);
            this.MinimumSize = new System.Drawing.Size(819, 489);
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cars_FormClosing);
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDealershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingNavigator)).EndInit();
            this.carBindingNavigator.ResumeLayout(false);
            this.carBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarDealershipDataSet carDealershipDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.BindingNavigator carBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private CarDealershipDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private CarDealershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox iD_CarTextBox;
        private System.Windows.Forms.TextBox powerWindowsTextBox;
        private System.Windows.Forms.TextBox conditionerTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox colorInteriorTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

