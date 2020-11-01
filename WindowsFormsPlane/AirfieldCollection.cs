using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsPlane
{
	class AirfieldCollection
	{
		readonly Dictionary<string, Airfield<AirPlane>> airdieldStages;

		public List<string> Keys => airdieldStages.Keys.ToList();

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		public AirfieldCollection(int pictureWidth, int pictureHeight)
		{
			airdieldStages = new Dictionary<string, Airfield<AirPlane>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		public void AddAirfield(string name)
		{
			if (airdieldStages.ContainsKey(name))
			{
				return;
			}
			airdieldStages.Add(name, new Airfield<AirPlane>(pictureWidth, pictureHeight));
		}

		public void DelParking(string name)
		{
			if (airdieldStages.ContainsKey(name))
			{
				airdieldStages.Remove(name);
			}
		}

		public Airfield<AirPlane> this[string ind]
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

		public Airfield<AirPlane> this[int ind]
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