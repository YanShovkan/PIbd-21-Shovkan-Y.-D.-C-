using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
	public partial class FormSeaplane : Form
	{
		private IAirTransport plane;
		public FormSeaplane()
		{
			InitializeComponent();
		}
		public void SetCar(IAirTransport plane)
		{
			this.plane = plane;
			Draw();
		}
			private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
			Graphics gr = Graphics.FromImage(bmp);
			plane.DrawPlane(gr);
			pictureBoxPlane.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			plane = new Plane(rnd.Next(400, 600), rnd.Next(1000, 2000), Color.Green);
			plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width,
		   pictureBoxPlane.Height);
			Draw();
		}

		private void buttonCreateSeaPlane_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			plane = new SeaPlane(rnd.Next(400, 600), rnd.Next(1000, 2000), Color.Green, Color.Red, true, true);
			plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width,
		   pictureBoxPlane.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					plane.MovePlane(Direction.Up);
					break;
				case "buttonDown":
					plane.MovePlane(Direction.Down);
					break;
				case "buttonLeft":
					plane.MovePlane(Direction.Left);
					break;
				case "buttonRight":
					plane.MovePlane(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
