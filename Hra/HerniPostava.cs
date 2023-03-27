using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class HerniPostava
    {
        public HerniPostava()
        {

        }

        private string jmeno;
        public string Jmeno { get { return jmeno; } set { jmeno = value; } }
        protected int level = 0;
        public double PoziceX { get; protected set; }
        public double PoziceY{ get; protected set; }

        public int GetLevel()
        {
            return level;
        }

        public void ZmenaPozice()
        {
            this.PoziceX += 5;
            this.PoziceY += 5;
        }

        public override string ToString()
        {
            return "Jméno: " + this.Jmeno
                + "\nLevel: " + this.level
                + "\nPozice X: " + this.PoziceX
                + "\nPozice Y: " + this.PoziceY;
        }
    }

}
