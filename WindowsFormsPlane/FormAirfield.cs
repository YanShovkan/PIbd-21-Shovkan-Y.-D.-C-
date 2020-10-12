using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
	public partial class FormAirfield : Form
	{
		private readonly AirfieldCollection airfieldCollection;

		public FormAirfield()
		{
			InitializeComponent();
			airfieldCollection = new AirfieldCollection(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
			Draw();
		}

		private void ReloadLevels()
		{
			int index = listBoxAirfield.SelectedIndex;
			listBoxAirfield.Items.Clear();
			for (int i = 0; i < airfieldCollection.Keys.Count; i++)
			{
				listBoxAirfield.Items.Add(airfieldCollection.Keys[i]);
			}
			if (listBoxAirfield.Items.Count > 0 && (index == -1 || index >= listBoxAirfield.Items.Count))
			{
				listBoxAirfield.SelectedIndex = 0;
			}
			else if (listBoxAirfield.Items.Count > 0 && index > -1 && index < listBoxAirfield.Items.Count)
			{
				listBoxAirfield.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxAirfield.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
				Graphics gr = Graphics.FromImage(bmp);
				airfieldCollection[listBoxAirfield.SelectedItem.ToString()].Draw(gr);
				pictureBoxAirfield.Image = bmp;
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAirfieldName.Text))
			{
				MessageBox.Show("Введите название аэродрома", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			airfieldCollection.AddAirfield(textBoxAirfieldName.Text);
			ReloadLevels();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (listBoxAirfield.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить аэродром {listBoxAirfield.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					airfieldCollection.DelParking(textBoxAirfieldName.Text);
					ReloadLevels();
				}
			}
		}

		private void buttonPlane_Click(object sender, EventArgs e)
		{
			if (listBoxAirfield.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var plane = new Plane(100, 1000, dialog.Color);
					if (airfieldCollection[listBoxAirfield.SelectedItem.ToString()] + plane)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Аэродром переполнен");
					}
				}
			}
		}

		private void buttonSeaplane_Click(object sender, EventArgs e)
		{
			if (listBoxAirfield.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var plane = new SeaPlane(100, 1000, dialog.Color, dialogDop.Color, true, true);
						if (airfieldCollection[listBoxAirfield.SelectedItem.ToString()] + plane)
						{
							Draw();
						}
						else
						{
							MessageBox.Show("Аэродром переполнен");
						}
					}
				}
			}
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (listBoxAirfield.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var plane = airfieldCollection[listBoxAirfield.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				if (plane != null)
				{
					FormSeaplane form = new FormSeaplane();
					form.SetPlane(plane);
					form.ShowDialog();
				}
				Draw();
			}
		}

		private void listBoxAirfield_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}
	}
}

