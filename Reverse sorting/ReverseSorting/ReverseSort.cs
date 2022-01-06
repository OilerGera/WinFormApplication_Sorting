using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace simplification
{
    class Sorting
    {
        public class ReverseSort : IComparer                                    // IComparer - bult-in function
        {
            public int Compare(object x, object y)                             
            {
                return Comparer.Default.Compare(y, x);                      // Reverse sorting via bult-in method
            }
        }
    }
}