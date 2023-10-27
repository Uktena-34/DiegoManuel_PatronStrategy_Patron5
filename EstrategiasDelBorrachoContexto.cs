using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DiegoManuel_PatronStrategy_Patron5
{
    internal class EstrategiasDelBorrachoContexto
    {
        private Borracho oBorracho;

        public EstrategiasDelBorrachoContexto()
        {
            // Por defeceto se pondra primero esta opcion
            this.oBorracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistaOjitos()
        {
         this.oBorracho= new EstrategiaOjitos();

        }

        public void EstablecerConquistaInvitarCerveza()
        {
            this.oBorracho = new EstrategiaInvitarCerveza();
        }
        public void Conquistar ()
        {
            this.oBorracho.Conquistar();
        }
    }
}
