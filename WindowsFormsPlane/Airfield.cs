using System;
using System.Drawing;

namespace WindowsFormsPlane
{
	public class Airfield<T> where T : class, IAirTransport
	{
		private readonly T[] _places;

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		private readonly int _placeSizeWidth = 210;

		private readonly int _placeSizeHeight = 80;


		public Airfield(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height]; pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static int operator +(Airfield<T> p, T plane)
		{
			for (int i = 0; i < p._places.Length; i++)
			{
				if (p._places[i] == null)
				{
					p._places[i] = plane;
					return i;
				}
			}
			return -1;
		}


		public static T operator -(Airfield<T> p, int index)
		{
			if (index < 0 || index > p._places.Length)
			{
				return null;
			}
			T temp = p._places[index];
			p._places[index] = null;
			return temp;
		}

		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				while(_places[i] == null)
				{
					i++;
					if (i == _places.Length)
					{
						return;
					}
				}
				_places[i].SetPosition(5 + i / 5 * _placeSizeWidth , i % 5 * _placeSizeHeight + 5, pictureWidth, pictureHeight);
				_places[i]?.DrawPlane(g);
			}
		}
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);

			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)


			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}

				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}