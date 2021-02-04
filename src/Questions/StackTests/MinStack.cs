using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace src.Questions.StackTests {
    public class MinStack {        
        private readonly List<int> _Stack = new List<int> ();
        public MinStack () {

        }

        public void Push (int x) {
            _Stack.Add (x);            
        }

        public void Pop () {
            _Stack.RemoveAt(_Stack.Count-1);
        }

        public int Top () {
            return _Stack.Count > 0 ? _Stack.Last() : 0;
        }

        public int GetMin () {
            var min = _Stack.ElementAt (0);
            for (var i = 1; i < _Stack.Count; i++) {
                var elementValue = _Stack.ElementAt (i);
                min = Math.Min (min, elementValue);
            }
            return min;
        }
    }
}