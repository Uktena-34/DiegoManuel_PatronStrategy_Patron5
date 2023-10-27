using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiegoManuel_PatronStrategy_Patron5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstrategiasDelBorrachoContexto oBorracho = new EstrategiasDelBorrachoContexto();
            oBorracho.Conquistar();
            oBorracho.EstablecerConquistaInvitarCerveza();
            oBorracho.EstablecerConquistaOjitos();
        }
    }
}
