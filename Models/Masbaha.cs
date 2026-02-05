using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace اذكاري.Models
{
    
    public class Masbaha
    {
        private string _zekerType;
        private int _number;
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _timeToEnd;
        private string _date;

        public string ZekerType { get => _zekerType; set => _zekerType = value; }
        public int Number { get => _number; set => _number = value; }
        public TimeSpan TimeToEnd { get => _timeToEnd; set => _timeToEnd = value; }
        public string Date { get => _date; set => _date = value; }
        public DateTime StartTime { get => _startTime; set => _startTime = value; }
        public DateTime EndTime { get => _endTime; set => _endTime = value; }
    }
}
