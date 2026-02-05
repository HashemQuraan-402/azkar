using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace اذكاري.Models
{
    public enum DayState {
        الصباح,المساء
    }
    public class Azkar
    {
        private bool _complete;
        
        private DayState _dayState;
        private string _date;
        public List<Zeker> zekers;
        public List<int> indexsForNotCompleteZekers;

        
        public bool Complete { get; set; }
        
        public DayState DayState { get; set; }
        public string Date { get; set; }

        

    }
}
