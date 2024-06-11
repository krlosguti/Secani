using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secani.Data.Common
{
    public class TablaParametrica
    {
        public int key { get; set; }
        public string value { get; set; }
    }
    public class TablasParametricas
    {
        public string name {  get; set; }
        public ICollection<TablasParametricas> values { get; set; }
    }
}
