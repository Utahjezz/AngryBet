using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scommesse.Model;
using System.Windows.Forms;
using Scommesse.View;

namespace Scommesse.Presenters
{
    public class ScommesseController
    {
        BetCard betCard;
        ScommessaForm scommessaForm;

        public ScommesseController(BetCard BCard)
        {
            betCard = BCard;
            scommessaForm = new ScommessaForm(this);
            Application.Run(scommessaForm);
        }

        public void LoadDatiPersonali(Label creditoLabel, Label codiceLabel, Label nomeLabel)
        {
            creditoLabel.Text = betCard.Credito.ToString()+ " $";
            codiceLabel.Text = betCard.CodiceTessera.ToString();
            nomeLabel.Text = betCard.Cliente.Nome +" " + betCard.Cliente.Cognome;
        }

        public void PopulateListView(ListView listView)
        {
            foreach (ScommessaConfermata s in betCard.Scommesse)
            {
                listView.Items.Add(s.ToString());
            }
        }

    }
}
