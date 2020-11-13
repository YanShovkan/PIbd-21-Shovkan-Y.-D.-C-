﻿using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsPlane
{
	public class Airfield<T> where T : class, IAirTransport
	{
		private readonly List<T> _places;

		private readonly int _maxCount;

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		private readonly int _placeSizeWidth = 210;

		private readonly int _placeSizeHeight = 80;


		public Airfield(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			pictureWidth = picWidth;
			pictureHeight = picHeight;
			_places = new List<T>();
		}

		public static bool operator +(Airfield<T> p, T plane)
		{
			if (p._places.Count >= p._maxCount)
			{
				return false;
			}
			p._places.Add(plane);
			return true;
		}

		public static T operator -(Airfield<T> p, int index)
		{
			if (index < 0 || index > p._places.Count - 1)
			{
				return null;
			}
			T plane = p._places[index];
			p._places.RemoveAt(index);
			return plane;
		}

		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Count; ++i)
			{
				_places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
				_places[i].DrawPlane(g);
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
		public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
			{
				return null;
			}
			return _places[index];
		}
	}
}