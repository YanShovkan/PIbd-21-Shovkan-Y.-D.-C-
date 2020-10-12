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
			this.buttonSeaplane = new System.Windows.Forms.Button();
			this.buttonTake = new System.Windows.Forms.Button();
			this.labelTake = new System.Windows.Forms.Label();
			this.labelPlace = new System.Windows.Forms.Label();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxAirfield
			// 
			this.pictureBoxAirfield.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxAirfield.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAirfield.Name = "pictureBoxAirfield";
			this.pictureBoxAirfield.Size = new System.Drawing.Size(650, 450);
			this.pictureBoxAirfield.TabIndex = 0;
			this.pictureBoxAirfield.TabStop = false;
			// 
			// buttonPlane
			// 
			this.buttonPlane.Location = new System.Drawing.Point(657, 13);
			this.buttonPlane.Name = "buttonPlane";
			this.buttonPlane.Size = new System.Drawing.Size(131, 72);
			this.buttonPlane.TabIndex = 1;
			this.buttonPlane.Text = "Создать самолет";
			this.buttonPlane.UseVisualStyleBackColor = true;
			this.buttonPlane.Click += new System.EventHandler(this.buttonPlane_Click);
			// 
			// buttonSeaplane
			// 
			this.buttonSeaplane.Location = new System.Drawing.Point(656, 91);
			this.buttonSeaplane.Name = "buttonSeaplane";
			this.buttonSeaplane.Size = new System.Drawing.Size(131, 72);
			this.buttonSeaplane.TabIndex = 2;
			this.buttonSeaplane.Text = "Создать гидро самолет";
			this.buttonSeaplane.UseVisualStyleBackColor = true;
			this.buttonSeaplane.Click += new System.EventHandler(this.buttonSeaplane_Click);
			// 
			// buttonTake
			// 
			this.buttonTake.Location = new System.Drawing.Point(657, 224);
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
			this.labelTake.Location = new System.Drawing.Point(698, 179);
			this.labelTake.Name = "labelTake";
			this.labelTake.Size = new System.Drawing.Size(89, 13);
			this.labelTake.TabIndex = 4;
			this.labelTake.Text = "Забрат самолет";
			// 
			// labelPlace
			// 
			this.labelPlace.AutoSize = true;
			this.labelPlace.Location = new System.Drawing.Point(698, 198);
			this.labelPlace.Name = "labelPlace";
			this.labelPlace.Size = new System.Drawing.Size(42, 13);
			this.labelPlace.TabIndex = 5;
			this.labelPlace.Text = "Место:";
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(746, 195);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(41, 20);
			this.maskedTextBox.TabIndex = 6;
			// 
			// FormAirfield
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.maskedTextBox);
			this.Controls.Add(this.labelPlace);
			this.Controls.Add(this.labelTake);
			this.Controls.Add(this.buttonTake);
			this.Controls.Add(this.buttonSeaplane);
			this.Controls.Add(this.buttonPlane);
			this.Controls.Add(this.pictureBoxAirfield);
			this.Name = "FormAirfield";
			this.Text = "Аэродром";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAirfield;
		private System.Windows.Forms.Button buttonPlane;
		private System.Windows.Forms.Button buttonSeaplane;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.Label labelTake;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
	}
}