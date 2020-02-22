using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();
        }
    }
        
    public static class Settings
    {
        public static string Connection { get; set; }
    }
}
