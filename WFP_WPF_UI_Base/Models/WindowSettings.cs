using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP_WPF_UI_Base.Models
{
    public class WindowSettings
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        
        public WindowState State { get; set; } = WindowState.Normal;
    }
}
