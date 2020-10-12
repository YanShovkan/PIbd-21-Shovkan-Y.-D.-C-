using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormAirfield : Form
    {

        private readonly Airfield<Plane> airfield;

        public FormAirfield()
        {
            InitializeComponent();
            airfield = new Airfield<Plane>(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirfield.Width, pictureBoxAirfield.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airfield.Draw(gr);
            pictureBoxAirfield.Image = bmp;
        }

        private void buttonPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);

                if (airfield + plane != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSeaplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new SeaPlane(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (airfield + plane != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = airfield - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormSeaplane form = new FormSeaplane();
                    form.SetCar(plane);

                    form.ShowDialog();
                }
            }
            Draw();
        }
    }
}