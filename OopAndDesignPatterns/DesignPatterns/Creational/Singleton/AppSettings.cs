using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Creational.Singleton
{
    internal class AppSettings
    {
        private static AppSettings? _instance;

        private Dictionary<string, object> _settings = new Dictionary<string, object> ();
        private AppSettings() //Private so that only this class can use it.
        {

        }
        public static AppSettings GetInstance()
        {
            if(_instance == null)
            {
                _instance = new AppSettings ();
            }
            return _instance;
        }
        public object? Get(string key)
        {
            if (!_settings.ContainsKey(key))
            {
                return null;
            }
            return _settings[key];
        }
        public void Set(string key, object value)
        {
            _settings[key] = value;
        }
    }
}
