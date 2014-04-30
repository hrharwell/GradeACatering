using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeACatering
{
    public class FilteringElement
    {
        private string strColumn;
        private string strValue;
        private string strAndOr;
        private string strComparator;

        public FilteringElement(string inCol, string inVal, string inAndOr, string inComp = " LIKE ")
        {
            //assign parameters to internal variables
            strColumn = inCol;
            strValue = inVal;
            strAndOr = inAndOr;
            strComparator = inComp;
        }
        public string Column
        { get { return strColumn; } }

        public string Value
        { get { return strValue; } }

        public string AndOr
        { get { return strAndOr; } }

        public string Comparator
        { get { return strComparator; } }
    }
}
