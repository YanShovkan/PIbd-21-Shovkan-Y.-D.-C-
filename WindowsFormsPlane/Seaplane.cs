using System.Drawing;

namespace WindowsFormsPlane
{
	class SeaPlane : Plane
	{
              
        public Color DopColor { private set; get; }
        
        public bool PlaneFloat { private set; get; }
        
        public bool LowerWing { private set; get; }
        
       
        public SeaPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool planeFloat, bool lowerWing) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            PlaneFloat = planeFloat;
            LowerWing = lowerWing;
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
    }
}

