using System.Drawing;

namespace WindowsFormsPlane
{
	public interface IAirTransport
	{
		void SetPosition(int x, int y, int width, int height);
		void MovePlane(Direction direction);
		void DrawPlane(Graphics g);
		void SetMainColor(Color color);
	}
}
