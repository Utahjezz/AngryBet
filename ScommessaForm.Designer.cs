namespace Scommesse.View
{
    partial class ScommessaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScommessaForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CreditoLabel = new System.Windows.Forms.Label();
            this.CodiceLabel = new System.Windows.Forms.Label();
            this.CrLabel = new System.Windows.Forms.Label();
            this.CodLabel = new System.Windows.Forms.Label();
            this.NomeCognomeLabel = new System.Windows.Forms.Label();
            this.ScommessaPanel = new System.Windows.Forms.Panel();
            this.ListView = new System.Windows.Forms.ListView();
            this.TopPanel.SuspendLayout();
            this.ScommessaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TopPanel.Controls.Add(this.CreditoLabel);
            this.TopPanel.Controls.Add(this.CodiceLabel);
            this.TopPanel.Controls.Add(this.CrLabel);
            this.TopPanel.Controls.Add(this.CodLabel);
            this.TopPanel.Controls.Add(this.NomeCognomeLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(695, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // CreditoLabel
            // 
            this.CreditoLabel.AutoSize = true;
            this.CreditoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditoLabel.Location = new System.Drawing.Point(576, 57);
            this.CreditoLabel.Name = "CreditoLabel";
            this.CreditoLabel.Size = new System.Drawing.Size(45, 16);
            this.CreditoLabel.TabIndex = 6;
            this.CreditoLabel.Text = "label2";
            // 
            // CodiceLabel
            // 
            this.CodiceLabel.AutoSize = true;
            this.CodiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodiceLabel.Location = new System.Drawing.Point(576, 24);
            this.CodiceLabel.Name = "CodiceLabel";
            this.CodiceLabel.Size = new System.Drawing.Size(38, 16);
            this.CodiceLabel.TabIndex = 5;
            this.CodiceLabel.Text = "label";
            // 
            // CrLabel
            // 
            this.CrLabel.AutoSize = true;
            this.CrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrLabel.Location = new System.Drawing.Point(434, 57);
            this.CrLabel.Name = "CrLabel";
            this.CrLabel.Size = new System.Drawing.Size(120, 16);
            this.CrLabel.TabIndex = 4;
            this.CrLabel.Text = "Credito disponibile";
            // 
            // CodLabel
            // 
            this.CodLabel.AutoSize = true;
            this.CodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodLabel.Location = new System.Drawing.Point(434, 24);
            this.CodLabel.Name = "CodLabel";
            this.CodLabel.Size = new System.Drawing.Size(103, 16);
            this.CodLabel.TabIndex = 2;
            this.CodLabel.Text = "Codice BetCard";
            // 
            // NomeCognomeLabel
            // 
            this.NomeCognomeLabel.AutoSize = true;
            this.NomeCognomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCognomeLabel.Location = new System.Drawing.Point(27, 24);
            this.NomeCognomeLabel.Name = "NomeCognomeLabel";
            this.NomeCognomeLabel.Size = new System.Drawing.Size(154, 24);
            this.NomeCognomeLabel.TabIndex = 0;
            this.NomeCognomeLabel.Text = "nomeCognome";
            // 
            // ScommessaPanel
            // 
            this.ScommessaPanel.Controls.Add(this.ListView);
            this.ScommessaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScommessaPanel.Location = new System.Drawing.Point(0, 100);
            this.ScommessaPanel.Name = "ScommessaPanel";
            this.ScommessaPanel.Size = new System.Drawing.Size(695, 338);
            this.ScommessaPanel.TabIndex = 1;
            // 
            // ListView
            // 
            this.ListView.BackColor = System.Drawing.SystemColors.Control;
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(695, 338);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // ScommessaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 438);
            this.Controls.Add(this.ScommessaPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ScommessaForm";
            this.Text = "Le tue scommesse";
            this.Load += new System.EventHandler(this.ScommessaForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ScommessaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label CrLabel;
        private System.Windows.Forms.Label CodLabel;
        private System.Windows.Forms.Label NomeCognomeLabel;
        private System.Windows.Forms.Panel ScommessaPanel;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Label CreditoLabel;
        private System.Windows.Forms.Label CodiceLabel;
    }
}