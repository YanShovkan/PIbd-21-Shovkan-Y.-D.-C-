﻿using System.Drawing;

namespace WindowsFormsPlane
{
	public abstract class AirPlane : IAirTransport
	{
        protected float _startPosX;

        protected float _startPosY;

        protected int _pictureWidth;

        protected int _pictureHeight;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawPlane (Graphics g);
        public abstract void MovePlane(Direction direction);

    }
}
