using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsPlane
{
	class AirfieldCollection
	{
		readonly Dictionary<string, Airfield<Plane>> airdieldStages;

		public List<string> Keys => airdieldStages.Keys.ToList();

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		public AirfieldCollection(int pictureWidth, int pictureHeight)
		{
			airdieldStages = new Dictionary<string, Airfield<Plane>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		public void AddAirfield(string name)
		{
			if (airdieldStages.ContainsKey(name))
			{
				return;
			}
			airdieldStages.Add(name, new Airfield<Plane>(pictureWidth, pictureHeight));
		}

		public void DelParking(string name)
		{
			if (airdieldStages.ContainsKey(name))
			{
				airdieldStages.Remove(name);
			}
		}

		public Airfield<Plane> this[string ind]
		{
			get
			{
				if (airdieldStages.ContainsKey(ind))
				{
					return airdieldStages[ind];
				}
				return null;
			}
		}

		public Airfield<Plane> this[int ind]
		{
			get
			{
				if (ind >= 0 || ind < Keys.Count)
				{
					return airdieldStages[Keys[ind]];
				}
				return null;
			}
		}
	}
}