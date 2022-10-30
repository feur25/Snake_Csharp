using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class command
    {
        public string Forward { get; set; }
        public string Down { get; set; }
        public string Right { get; set; }
        public string Left { get; set; }
        public string Space { get; set; }
        //function constructeur
        public command(string Forward, string Down, string Right, string Left, string Space)
        {
            this.Forward = Forward;
            this.Down = Down;
            this.Right = Right;
            this.Left = Left;
            this.Space=Space;
        }
        /*public override string ToString()
        {
            string outPut = String.Format("{0} {1} {2} {3}", Forward, Down, Right, Left, Space);
        }*/
    }
}
