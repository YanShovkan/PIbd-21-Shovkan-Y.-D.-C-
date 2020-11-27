using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsPlane
{
    class AirfieldCollection
    {
        readonly Dictionary<string, Airfield<AirPlane>> airfieldStages;

        public List<string> Keys => airfieldStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public AirfieldCollection(int pictureWidth, int pictureHeight)
        {
            airfieldStages = new Dictionary<string, Airfield<AirPlane>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAirfield(string name)
        {
            if (airfieldStages.ContainsKey(name))
            {
                return;
            }
            airfieldStages.Add(name, new Airfield<AirPlane>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (airfieldStages.ContainsKey(name))
            {
                airfieldStages.Remove(name);
            }
        }

        public Airfield<AirPlane> this[string ind]
        {
            get
            {
                if (airfieldStages.ContainsKey(ind))
                {
                    return airfieldStages[ind];
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
                    return airfieldStages[Keys[ind]];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"AirfieldCollection");
                foreach (var level in airfieldStages)
                {
                    sw.WriteLine($"Airfield{separator}{level.Key}");
                    IAirTransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "Plane")
                            {
                                sw.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "SeaPlane")
                            {
                                sw.Write($"SeaPlane{separator}");
                            }
                            sw.WriteLine(plane);
                        }
                    }
                }
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                string key = string.Empty;
                AirPlane plane = null;
                if (line.Contains("AirfieldCollection"))
                {
                    airfieldStages.Clear();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains("Airfield"))
                        {
                            key = line.Split(separator)[1];
                            airfieldStages.Add(key, new Airfield<AirPlane>(pictureWidth, pictureHeight));
                            line = sr.ReadLine();
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            line = sr.ReadLine();
                            continue;
                        }
                        if (line.Split(separator)[0] == "Plane")
                        {
                            plane = new Plane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "SeaPlane")
                        {
                            plane = new SeaPlane(line.Split(separator)[1]);
                        }
                        var result = airfieldStages[key] + plane;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }
                else
                {
                    throw new FileFormatException();
                }
            }
            
        }
    }
}
