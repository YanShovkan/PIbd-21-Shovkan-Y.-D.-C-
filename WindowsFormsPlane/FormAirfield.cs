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
                    airfieldCollection.DelParking(listBoxAirfield.SelectedItem.ToString());
                    ReloadLevels();
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

        private void buttonPlane_Click(object sender, EventArgs e)
        {
            var seaPlaneConfig = new FormSeaPlaneConfig();
            seaPlaneConfig.AddEvent(AddPlane);
            seaPlaneConfig.AddEvent(complateMessage);
            seaPlaneConfig.Show();
        }

        private void AddPlane(AirPlane plane)
        {
            if (plane != null && listBoxAirfield.SelectedIndex > -1)
            {
                if ((airfieldCollection[listBoxAirfield.SelectedItem.ToString()]) + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолет не удалось поставить");
                }
            }
        }

        public void complateMessage(AirPlane plane)
        {
            if(plane != null)
            {
                MessageBox.Show("Все ок");
            }
        }
    }
}