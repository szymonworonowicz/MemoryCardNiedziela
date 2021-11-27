
namespace Memory
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblCzas = new System.Windows.Forms.Label();
            this.lblCzasWartosc = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblPunktyWartosc = new System.Windows.Forms.Label();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Location = new System.Drawing.Point(33, 13);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(30, 13);
            this.lblCzas.TabIndex = 0;
            this.lblCzas.Text = "Czas";
            // 
            // lblCzasWartosc
            // 
            this.lblCzasWartosc.AutoSize = true;
            this.lblCzasWartosc.Location = new System.Drawing.Point(69, 13);
            this.lblCzasWartosc.Name = "lblCzasWartosc";
            this.lblCzasWartosc.Size = new System.Drawing.Size(19, 13);
            this.lblCzasWartosc.TabIndex = 1;
            this.lblCzasWartosc.Text = "60";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Location = new System.Drawing.Point(128, 13);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(40, 13);
            this.lblPunkty.TabIndex = 2;
            this.lblPunkty.Text = "Punkty";
            // 
            // lblPunktyWartosc
            // 
            this.lblPunktyWartosc.AutoSize = true;
            this.lblPunktyWartosc.Location = new System.Drawing.Point(174, 13);
            this.lblPunktyWartosc.Name = "lblPunktyWartosc";
            this.lblPunktyWartosc.Size = new System.Drawing.Size(13, 13);
            this.lblPunktyWartosc.TabIndex = 3;
            this.lblPunktyWartosc.Text = "0";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Location = new System.Drawing.Point(251, 13);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(98, 13);
            this.lblStartInfo.TabIndex = 4;
            this.lblStartInfo.Text = "Poczatek gry za 5..";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 385);
            this.panel1.TabIndex = 5;
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.lblPunktyWartosc);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.lblCzasWartosc);
            this.Controls.Add(this.lblCzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MemoryGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.Label lblCzasWartosc;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblPunktyWartosc;
        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
    }
}

