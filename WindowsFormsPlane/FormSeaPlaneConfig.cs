using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormSeaPlaneConfig : Form
    {
        AirPlane plane = null;

        //private event PlaneDelegate eventAddPlane;
        private event Action<AirPlane> eventAddPlane;

        public FormSeaPlaneConfig()
        {
            InitializeComponent();
            foreach(var item in groupBoxColors.Controls)
            {
                if(item is Panel)
                {
                    ((Panel)item).MouseDown += panelColor_MouseDown;
                }
            }
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
       
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawPlane(gr);
                pictureBoxPlane.Image = bmp;
            }
        }
       
        public void AddEvent(Action<AirPlane> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<AirPlane>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }
       
        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
       
        private void labelSeaPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelSeaPlane.DoDragDrop(labelSeaPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
       
        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
       
        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    plane = new Plane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Green);
                    break;
                case "Гидролет":
                    plane = new SeaPlane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Green, Color.Black, checkBoxFloats.Checked, checkBoxLowerWing.Checked);
                    break;
            }
            DrawPlane();
        }
       
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            plane?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
            DrawPlane();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if(plane is SeaPlane)
            {
                SeaPlane thisPlane = (SeaPlane)plane;
                thisPlane.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                plane = thisPlane;
                DrawPlane();
            }
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}