using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class TimeMap
    {
        private Dictionary<string, Dictionary<int, string>> _map = new Dictionary<string, Dictionary<int, string>>();
        
        public TimeMap()
        {

        }

        public void Set(string key, string value, int timestamp)
        {
            if (_map.Keys.Contains(key))
            {
                _map[key][timestamp] = value;
            }
            else
            {
                _map[key] = new Dictionary<int, string>();
                _map[key].Add(timestamp, value);
            }
        }

        public string Get(string key, int timestamp)
        {
            if (_map.ContainsKey(key))
            {
                if (_map[key].ContainsKey(timestamp))
                {
                    return _map[key][timestamp];
                }

                IEnumerable<int> keys = _map[key].Keys.Reverse();
                for (int i = 0; i < keys.Count(); i++)
                {
                    int j = keys.ElementAt(i);
                    if (timestamp > j)
                    {
                        return _map[key][j];
                    }
                }
            }

            return "";
        }
    }
}
