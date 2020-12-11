namespace WindowsFormsPlane
{
	partial class FormAirfield
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
            this.pictureBoxAirfield = new System.Windows.Forms.PictureBox();
            this.buttonPlane = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelTake = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelAirfield = new System.Windows.Forms.Label();
            this.listBoxAirfield = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxAirfieldName = new System.Windows.Forms.TextBox();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).BeginInit();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirfield
            // 
            this.pictureBoxAirfield.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAirfield.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxAirfield.Name = "pictureBoxAirfield";
            this.pictureBoxAirfield.Size = new System.Drawing.Size(650, 426);
            this.pictureBoxAirfield.TabIndex = 0;
            this.pictureBoxAirfield.TabStop = false;
            // 
            // buttonPlane
            // 
            this.buttonPlane.Location = new System.Drawing.Point(658, 205);
            this.buttonPlane.Name = "buttonPlane";
            this.buttonPlane.Size = new System.Drawing.Size(131, 72);
            this.buttonPlane.TabIndex = 1;
            this.buttonPlane.Text = "Создать самолет";
            this.buttonPlane.UseVisualStyleBackColor = true;
            this.buttonPlane.Click += new System.EventHandler(this.buttonPlane_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(658, 416);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(130, 23);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(699, 371);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(89, 13);
            this.labelTake.TabIndex = 4;
            this.labelTake.Text = "Забрат самолет";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(699, 390);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 5;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(747, 387);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox.TabIndex = 6;
            // 
            // labelAirfield
            // 
            this.labelAirfield.AutoSize = true;
            this.labelAirfield.Location = new System.Drawing.Point(690, 9);
            this.labelAirfield.Name = "labelAirfield";
            this.labelAirfield.Size = new System.Drawing.Size(64, 13);
            this.labelAirfield.TabIndex = 7;
            this.labelAirfield.Text = "Аэродром: ";
            // 
            // listBoxAirfield
            // 
            this.listBoxAirfield.FormattingEnabled = true;
            this.listBoxAirfield.Location = new System.Drawing.Point(659, 80);
            this.listBoxAirfield.Name = "listBoxAirfield";
            this.listBoxAirfield.Size = new System.Drawing.Size(130, 95);
            this.listBoxAirfield.TabIndex = 8;
            this.listBoxAirfield.SelectedIndexChanged += new System.EventHandler(this.listBoxAirfield_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(658, 52);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 22);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить аэродром";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(659, 177);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 22);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить аэродром";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxAirfieldName
            // 
            this.textBoxAirfieldName.Location = new System.Drawing.Point(659, 26);
            this.textBoxAirfieldName.Name = "textBoxAirfieldName";
            this.textBoxAirfieldName.Size = new System.Drawing.Size(129, 20);
            this.textBoxAirfieldName.TabIndex = 13;
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(800, 24);
            this.menuStripMenu.TabIndex = 14;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(658, 284);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(131, 42);
            this.buttonSort.TabIndex = 15;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormAirfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxAirfieldName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxAirfield);
            this.Controls.Add(this.labelAirfield);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelTake);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonPlane);
            this.Controls.Add(this.pictureBoxAirfield);
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FormAirfield";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).EndInit();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAirfield;
		private System.Windows.Forms.Button buttonPlane;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.Label labelTake;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.Label labelAirfield;
		private System.Windows.Forms.ListBox listBoxAirfield;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxAirfieldName;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}