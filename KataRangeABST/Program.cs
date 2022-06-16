using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRangeABST
{
    class Program
    {
        public enum SymbolOpen
        {
            CorcheteAbierto = 0,
            ParentisAbierto = 1
        }
        public enum SymbolClose
        {
            CorcheteCerrado = 2,
            ParentesisCerrado = 3
        }

        public static string GetAllPoints()
        {
            return "";
        }
        public static string endPoints(SymbolOpen Op, SymbolClose Cl, int[]rangeValue)
        {
            int fValue = rangeValue[0];
            int sValue = rangeValue[1];
            string OpenSymbol = "";
            string CloseSymbol = "";
            string OpenBraket = "{";
            string CloseBraket = "}";
            if (SymbolOpen.CorcheteAbierto ==  Op)
            {
                OpenSymbol = "[";
            }
            else
            {
                OpenSymbol = "(";
                fValue += 1;
            }

            if (SymbolClose.CorcheteCerrado == Cl)
            {
               CloseSymbol = "]";
            }
            else
            {
                CloseSymbol = ")";
                sValue -= 1;
            }

            return $"{OpenSymbol}{rangeValue[0]}, {rangeValue[1]}{CloseSymbol}  endPoints = {OpenBraket}{fValue}, {sValue}{CloseBraket}";
        }
        public static string integerRangeContain()
        {
            return "";
        }
        public static string equals()
        {
            return "";
        }
        public static string OverlapRange()
        {
            return "";
        }
        public static string ContainsRange()
        {
            return "";
        }
        static void Main(string[] args)
        {
        }
    }
}
