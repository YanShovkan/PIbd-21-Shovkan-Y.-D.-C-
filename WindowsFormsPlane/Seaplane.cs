using System;
using System.Drawing;

namespace WindowsFormsPlane
{
    class SeaPlane : Plane
    {

        public Color DopColor { private set; get; }

        public bool PlaneFloat { private set; get; }

        public bool LowerWing { private set; get; }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public SeaPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool planeFloat, bool lowerWing) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            PlaneFloat = planeFloat;
            LowerWing = lowerWing;
        }
        public SeaPlane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                PlaneFloat = Convert.ToBoolean(strs[4]);
                LowerWing = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColor = new SolidBrush(DopColor);

            base.DrawPlane(g);

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
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{PlaneFloat}{separator}{LowerWing}";
        }
    }
}