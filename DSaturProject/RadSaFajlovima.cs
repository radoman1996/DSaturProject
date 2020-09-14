using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DSaturProject
{
    class RadSaFajlovima
    {
        public String[] fileNames()
        {
            String[] namesPath = Directory.GetFiles("../../graph");
            String[] names = new String[namesPath.Length];
            for(int i = 0; i < namesPath.Length; i++)
            {
                String[] temp = namesPath[i].Split('\\');
                names[i] = temp[temp.Length - 1];
            }
            return names;
        }
    }
}
