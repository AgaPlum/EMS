using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace K_ntor
{
    class Table
    {
        //Support Class where you can do operation on table
        WebClient wb = new WebClient();
        //Get data from website - it is important to have the current exchange rate
        public string[,] DataDownload(Uri url)
        {
            string s = wb.DownloadString(url);
            char[] v = { '{', ',', ':' };
            string b = s.Replace("}", "").Replace(@"""", "");
            string[] element = b.Split(v);
            string[,] tab = Splitting(element.Skip(7).ToArray());
            return Assign(tab);
        }
        //Assign full name to currencies - join tables
        public string[,] Assign(string[,] tab2)
        {
            string[,] tab1 = ResorcePrep();
            string[,] ntab = new string[tab2.Length / 2, 3];
            for (int i = 0; i < tab2.Length / 2; i++)
            {
                for (int j = 0; j < tab2.Length / 2; j++)
                {
                    if (tab1[i, 1] == tab2[j, 0])
                    {
                        ntab[i, 0] = tab1[i, 0];
                        ntab[i, 1] = tab2[j, 0];
                        ntab[i, 2] = tab2[j, 1];
                    }
                    if (tab2[i, 0] == "EUR")
                    {
                        ntab[0, 0] = "Euro";
                        ntab[0, 1] = tab2[i, 0];
                        ntab[0, 2] = tab2[i, 1];
                    }
                }
            }
            return ntab;
        }
        //Take table from the resource where you can find full list of currency name
        public string[,] ResorcePrep()
        {
            string s = K_ntor.Properties.Resources.ERList;
            char[] b = { ':', '\n' };
            string z = s.Replace("\r", "").Replace("  ", "");
            string[] element = z.Split(b);
            return Splitting(element);
        }
        //Support for splitting the string and create table
        public string[,] Splitting(string[] element)
        {
            int d = element.Length / 2;
            string[,] tab = new string[d, 2];
            int k = 0;
            for (int i = 0; i < d; i++)
            {
                tab[i, 0] = element[k];
                tab[i, 1] = element[k + 1];
                k = k + 2;
            }
            return tab;
        }
        //Choice of exchange rate
        public string[] Chosen(string ct, string[,] tab)
        {
            string[] final=new string[2];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i, 0] == ct)
                {
                    final[0]=tab[i, 2];
                    final[1]=tab[i, 1];
                    return final;
                }
            }
            return final;
        }
    }
}
