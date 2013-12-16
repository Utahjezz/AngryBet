using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scommesse.Presenters;

namespace Scommesse.View
{
    public partial class ScommessaForm : Form
    {
        ScommesseController scommesseController;
        public ScommessaForm(ScommesseController SController)
        {
            InitializeComponent();
            scommesseController = SController;       
        }

        private void ScommessaForm_Load(object sender, EventArgs e)
        {
            scommesseController.LoadDatiPersonali(CreditoLabel, CodiceLabel, NomeCognomeLabel);
            scommesseController.PopulateListView(ListView);
        }

    }
}
