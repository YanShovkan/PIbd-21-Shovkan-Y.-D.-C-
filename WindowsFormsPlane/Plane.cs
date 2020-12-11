using System;
using System.Drawing;

namespace WindowsFormsPlane
{
    public class Plane : AirPlane, IEquatable<Plane>
    {
        protected readonly int planeWidth = 100;

        protected readonly int planeHeight = 50;

        protected readonly char separator = ';';

        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Plane(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        protected Plane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }

        public override void MovePlane(Direction direction)
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
                    if (_startPosX - step > boarderNumber)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > boarderNumber)
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

        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainColor = new SolidBrush(MainColor);
            //body
            g.FillEllipse(mainColor, _startPosX + 80, _startPosY + 10, 20, 35);
            g.FillRectangle(mainColor, _startPosX + 10, _startPosY + 25, 90, 20);
            //wint
            g.DrawLine(pen, _startPosX + 10, _startPosY + 35, _startPosX + 5, _startPosY + 35);
            g.DrawLine(pen, _startPosX + 5, _startPosY + 30, _startPosX + 5, _startPosY + 40);
            //glass
            g.DrawLine(pen, _startPosX + 25, _startPosY + 25, _startPosX + 30, _startPosY + 15);
            //wing
            g.DrawLine(pen, _startPosX + 50, _startPosY + 25, _startPosX + 50, _startPosY + 10);
            g.FillEllipse(mainColor, _startPosX + 30, _startPosY + 5, 40, 5);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
        public bool Equals(Plane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Plane planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
    }
}
