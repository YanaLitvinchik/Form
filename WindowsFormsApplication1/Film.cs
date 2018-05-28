using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Film
    {
        private string _title;
        private string _genre;
        private string _director;
        private int _time;
        private double _rate;
        private double _revenue;

       
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    TitleChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    GenreChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public string Director
        {
            get { return _director; }
            set
            {
                if (_director != value)
                {
                    _director = value;
                    DirectorChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public int Time
        {
            get { return _time; }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    TimeChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public double Rate
        {
            get { return _rate; }
            set
            {
                if (_rate != value)
                {
                    _rate = value;
                    RateChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public double Revenue
        {
            get { return _revenue; }
            set
            {
                if (_revenue != value)
                {
                    _revenue = value;
                    RevenueChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }       

        public event EventHandler<EventArgs> TitleChanged;
        public event EventHandler<EventArgs> GenreChanged;
        public event EventHandler<EventArgs> DirectorChanged;
        public event EventHandler<EventArgs> TimeChanged;
        public event EventHandler<EventArgs> RateChanged;
        public event EventHandler<EventArgs> RevenueChanged;

        public override string ToString()
        {
            return $"{Title} {Genre} {Director} {Time}";
        }
    }
}
