using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.DesignPatterns.Behavioral.Observer
{
    internal class School(string schoolName) : IObserver //Coz school is an observer. Waiting for the news.
    {
        private string _schoolName = schoolName;

        public void Update(string news)
        {
            Console.WriteLine($"School {_schoolName} received the news: {news}");
        }
    }
}
