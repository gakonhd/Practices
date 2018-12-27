using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    public class WorkChangedEventArgs : EventArgs
    {
        public Work Work { get; set; }
    }
}
