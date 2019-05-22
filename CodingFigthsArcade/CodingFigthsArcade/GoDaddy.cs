using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingFigthsSolvingArcade
{
    class GoDaddy
    {
        private GoDaddy() { }

        static void Main(string[] args)
        {
            //var a = new string[][] { new string[] { "godaddy.net", "godaddy.com" }, new string[] { "godaddy.org", "godaddycares.com" }, new string[] { "godaddy.com", "godaddy.com" }, new string[] { "godaddy.ne","godaddy.net" } };
            //Console.WriteLine(domainForwarding(a));

            var domain = "godaddy.com";
            var i = 7;
            Console.WriteLine(typosquatting(i,domain));

            Console.ReadLine();
        }

        static string[][] domainForwarding(string[][] redirects)
        {
            var r = new string[][] { new string[] { } };
            var red = new List<domainForward>();

            for (int i = 0; i < redirects.Length; i++)
            {
                red.Add(new domainForward() { fromDamain = redirects[i][0], toDomain = redirects[i][1] });
            }

            var lst = new List<string>();
            
            foreach (var item in red.GroupBy(x => x.toDomain).ToList())
            {
                lst.Add(item.Key);
            }

            var h = lst.OrderBy(x => x).Distinct().ToList();


            return r;
        }

        static int typosquatting(int n, string domain)
        {
            int r = -1;
            
            return r;
        }
    }

    class domainForward
    {
        public string fromDamain { get; set; }
        public string toDomain { get; set; }
    }
}
