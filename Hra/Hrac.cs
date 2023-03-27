using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Hra
{
    public class Hrac : HerniPostava
    {
        public Hrac()
        { 
        
        }

        private string specializace;
        public string Specializace { get { return specializace; } set { specializace = value; } }
        public int XP;


        private enum Oblicej
        {
            VelkyNos,
            VelkeUsi,
            Make_up
        }

        private enum Vlasy
        {
            Drdol,
            Culik,
            Pleska
        }

        private enum BarvaVlasu
        {
            Kastanova,
            Blond,
            Cervena
        }

        public void PridejXP(int xp)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
