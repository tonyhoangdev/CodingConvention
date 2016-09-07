using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConvention
{
    public class FunctionParam
    {
        public string FncName { get; set; }
        public string[] FncParams { get; set; }
        public int NumOfParam { get; set; }

        public override string ToString()
        {
            return FncName;
        }
    }
}
