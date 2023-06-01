using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Trang63
{
    internal class SoSanhChuoi
    {
        public static int SoSanh(string a, string b)    // a<b:-1   a==b:0  a>b:1
        {
            int lengthMin = a.Length<b.Length?a.Length:b.Length;

            for(int i=0; i < lengthMin; i++)
            {
                if (a[i] == b[i])
                    continue;
                if (a[i] < b[i])
                    return -1;
                return 1;
            }
            if (a.Length == b.Length) return 0;
            if(lengthMin == a.Length) return -1;
            return 1;
        }
    }
}
