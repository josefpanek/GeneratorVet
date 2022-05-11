using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorVet
{
    /// <summary>
    /// Generátor náhodných vět
    /// </summary>
    internal class GeneratorVet
    {
        /// <summary>
        /// Slovní zásoba podmětů
        /// </summary>
        private List<string> Podmety = new List<string> { "jednorožec", "programátor", "manažer", "hroch", "T-rex" };
        /// <summary>
        /// Slovní zásoba přísudků
        /// </summary>
        private List<string> Prisudky = new List<string> { "spal", "ležel", "vařil", "uklízel", "derivoval" };
        /// <summary>
        /// Slovní zásoba přívlastků
        /// </summary>
        private List<string> Privlastky = new List<string> { "modrý", "velký", "hubený", "nejlepší", "automatizovaný" };
        /// <summary>
        /// Slovní zásoba příslovcí
        /// </summary>
        private List<string> Prislovce = new List<string> { "rychle", "s oblibou", "hodně", "málo", "se zpožděním" };
        /// <summary>
        /// Slovní zásoba příslovečných určení místa
        /// </summary>
        private List<string> Pum = new List<string> { "pod stolem", "v lese", "u babičky", "v práci", "na stole" };
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random = new Random();
        /// <summary>
        /// Vrátí náhodné slovo z listu
        /// </summary>
        /// <param name="seznam">Vstupní pole</param>
        /// <returns>Náhodné slovo</returns>
        private string NahodneSlovo(List<string> seznam)
        {
            return seznam[random.Next(1, seznam.Count)];
        }
        /// <summary>
        /// Vrátí náhodnou větu
        /// </summary>
        /// <returns>Náhodná věta</returns>
        public string GenerujVetu()
        {
            return string.Format("{0} {1} {2} {3} {4}",
                NahodneSlovo(Privlastky),
                NahodneSlovo(Podmety),
                NahodneSlovo(Prislovce),
                NahodneSlovo(Prisudky),
                NahodneSlovo(Pum));
        }
    }
}