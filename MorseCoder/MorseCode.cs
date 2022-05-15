using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MorseCoder
{

    internal class MorseCode
    {
        private Dictionary<string, string> code = new Dictionary<string, string>();

        // Erstellung des KeyValuePair für den MorseCode
        public Dictionary<string, string> Code(Dictionary<string, string> code)
        {
            this.code = code;
            this.code.Add("A", "short long");
            this.code.Add("B", "long short short short");
            this.code.Add("C", "long short long short");
            this.code.Add("D", "long short short");
            this.code.Add("E", "short");
            this.code.Add("F", "short short long short");
            this.code.Add("G", "long long short");
            this.code.Add("H", "short short short short");
            this.code.Add("I", "short short");
            this.code.Add("J", "short long long long");
            this.code.Add("K", "long short long");
            this.code.Add("L", "short long short short");
            this.code.Add("M", "long long");
            this.code.Add("N", "long short");
            this.code.Add("O", "long long long");
            this.code.Add("P", "shor long long short");
            this.code.Add("Q", "long long short long");
            this.code.Add("R", "short long short");
            this.code.Add("S", "short short short");
            this.code.Add("T", "long");
            this.code.Add("U", "short short long");
            this.code.Add("V", "short short short long");
            this.code.Add("W", "short long long");
            this.code.Add("X", "long short short long");
            this.code.Add("Y", "long short long long");
            this.code.Add("Z", "long long short short");
            return this.code;
        }
    }
}
