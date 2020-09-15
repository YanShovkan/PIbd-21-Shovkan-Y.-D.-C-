using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
	class SeaPlane
	{
       
        private float _startPosX;
      
        private float _startPosY;
        
        private int _pictureWidth;
        
        private int _pictureHeight;
 
        private readonly int planeWidth = 100;
       
        private readonly int planeHeight = 60;
        
        public int MaxSpeed { private set; get; }
       
        public float Weight { private set; get; }
       
        public Color MainColor { private set; get; }
        
        public Color DopColor { private set; get; }
        
        public bool PlaneFloat { private set; get; }
        
        public bool LowerWing { private set; get; }
        
       
        public SeaPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool planeFloat, bool lowerWing)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            PlaneFloat = planeFloat;
            LowerWing = lowerWing;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MovePlane(Direction direction)
        {
            int boarderNumber = 10; 
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {                
                // вправо
                case Direction.Right:
                    if (_startPosX + step + planeWidth < _pictureWidth - boarderNumber)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step  > boarderNumber)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step  > boarderNumber)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step + planeHeight < _pictureHeight - boarderNumber)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainColor = new SolidBrush(MainColor);
            Brush dopColor = new SolidBrush(DopColor);
            //body
            g.FillEllipse(mainColor, _startPosX + 80, _startPosY+10, 20, 35);
            g.FillRectangle(mainColor, _startPosX + 10, _startPosY + 25, 90, 20);
            //wint
            g.DrawLine(pen,_startPosX + 10, _startPosY + 35, _startPosX+5, _startPosY+35);
            g.DrawLine(pen, _startPosX+5, _startPosY + 30, _startPosX+5, _startPosY + 40);
            //glass
            g.DrawLine(pen, _startPosX + 25, _startPosY + 25, _startPosX + 30, _startPosY + 15);
            //wing
            g.DrawLine(pen, _startPosX+50, _startPosY + 25, _startPosX+50, _startPosY + 10);
            g.FillEllipse(dopColor, _startPosX + 30, _startPosY+5 , 40, 5);

            if (LowerWing)
            {
                g.FillEllipse(dopColor, _startPosX + 30, _startPosY + 30, 40, 5);
            }
            if (PlaneFloat)
            {
                g.DrawLine(pen, _startPosX + 30, _startPosY + 45, _startPosX + 30, _startPosY + 55);
                g.DrawLine(pen, _startPosX + 60, _startPosY + 45, _startPosX + 60, _startPosY + 55);
                g.FillRectangle(dopColor, _startPosX + 10, _startPosY + 55, 70, 5);

            }
        }
    }
}

