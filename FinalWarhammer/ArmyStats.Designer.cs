namespace FinalWarhammer
{
    partial class ArmyStats
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
            this.lstBoxArmy = new System.Windows.Forms.ListBox();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotH = new System.Windows.Forms.Label();
            this.lblTotalHealth = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxArmy
            // 
            this.lstBoxArmy.FormattingEnabled = true;
            this.lstBoxArmy.Location = new System.Drawing.Point(34, 70);
            this.lstBoxArmy.Name = "lstBoxArmy";
            this.lstBoxArmy.Size = new System.Drawing.Size(210, 95);
            this.lstBoxArmy.TabIndex = 0;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(349, 70);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(84, 13);
            this.lblTot.TabIndex = 1;
            this.lblTot.Text = "Total Army Cost:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(478, 70);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(25, 13);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "$$$";
            // 
            // lblTotH
            // 
            this.lblTotH.AutoSize = true;
            this.lblTotH.Location = new System.Drawing.Point(349, 106);
            this.lblTotH.Name = "lblTotH";
            this.lblTotH.Size = new System.Drawing.Size(94, 13);
            this.lblTotH.TabIndex = 3;
            this.lblTotH.Text = "Total Army Health:";
            // 
            // lblTotalHealth
            // 
            this.lblTotalHealth.AutoSize = true;
            this.lblTotalHealth.Location = new System.Drawing.Point(478, 106);
            this.lblTotalHealth.Name = "lblTotalHealth";
            this.lblTotalHealth.Size = new System.Drawing.Size(36, 13);
            this.lblTotalHealth.TabIndex = 4;
            this.lblTotalHealth.Text = "health";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(34, 204);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(137, 43);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "<< Return to Recutes";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ArmyStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 316);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalHealth);
            this.Controls.Add(this.lblTotH);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lstBoxArmy);
            this.Name = "ArmyStats";
            this.Text = "ArmyStats";
            this.Load += new System.EventHandler(this.ArmyStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxArmy;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotH;
        private System.Windows.Forms.Label lblTotalHealth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturn;
    }
}