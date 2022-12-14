using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBB_Draft.Modele;
internal class Osada : IGrupa
{
	public readonly ICollection<Budynek> Budynki = new List<Budynek>();
}
