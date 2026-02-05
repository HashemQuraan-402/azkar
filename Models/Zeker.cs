using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace اذكاري.Models
{
    public class Zeker
    {
        private string _text;
        private int _number;
        private bool _complete;
        private int _id;
        private int _counter;


        public string Text { get => _text; set => _text = value; }
        public int Number { get => _number; set => _number = value; }
        public bool Complete { get => _complete; set => _complete = value; }
        public int Id { get => _id; set => _id = value; }
        public int Counter { get => _counter; set => _counter = value; }
    }
}
