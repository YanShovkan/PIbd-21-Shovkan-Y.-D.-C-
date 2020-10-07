namespace WindowsFormsPlane
{
	partial class FormSeaplane
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
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
			this.buttonCreateSeaPlane = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(12, 12);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(143, 23);
			this.buttonCreate.TabIndex = 1;
			this.buttonCreate.Text = "Создать самолет";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.arrowDown;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(806, 419);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(30, 30);
			this.buttonDown.TabIndex = 3;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.arrowRight;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(842, 419);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(30, 30);
			this.buttonRight.TabIndex = 4;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackColor = System.Drawing.SystemColors.Control;
			this.buttonUp.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.arrowUp;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(807, 384);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(30, 30);
			this.buttonUp.TabIndex = 5;
			this.buttonUp.UseVisualStyleBackColor = false;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::WindowsFormsPlane.Properties.Resources.arrowLeft;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(770, 419);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(30, 30);
			this.buttonLeft.TabIndex = 2;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// pictureBoxPlane
			// 
			this.pictureBoxPlane.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxPlane.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxPlane.Name = "pictureBoxPlane";
			this.pictureBoxPlane.Size = new System.Drawing.Size(884, 461);
			this.pictureBoxPlane.TabIndex = 0;
			this.pictureBoxPlane.TabStop = false;
			// 
			// buttonCreateSeaPlane
			// 
			this.buttonCreateSeaPlane.Location = new System.Drawing.Point(161, 12);
			this.buttonCreateSeaPlane.Name = "buttonCreateSeaPlane";
			this.buttonCreateSeaPlane.Size = new System.Drawing.Size(179, 23);
			this.buttonCreateSeaPlane.TabIndex = 6;
			this.buttonCreateSeaPlane.Text = "Создать гидросамолет";
			this.buttonCreateSeaPlane.UseVisualStyleBackColor = true;
			this.buttonCreateSeaPlane.Click += new System.EventHandler(this.buttonCreateSeaPlane_Click);
			// 
			// FormSeaplane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.buttonCreateSeaPlane);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.pictureBoxPlane);
			this.Name = "FormSeaplane";
			this.Text = "Гидросамолет";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPlane;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonCreateSeaPlane;
	}
}

