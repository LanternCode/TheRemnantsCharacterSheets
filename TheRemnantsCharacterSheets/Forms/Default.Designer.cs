namespace TheRemnantsCharacterSheets
{
    partial class frmHome
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
            this.lblHeaderOne = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCopyrights = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.lblLangChoice = new System.Windows.Forms.Label();
            this.btnPolish = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeaderOne
            // 
            this.lblHeaderOne.AutoSize = true;
            this.lblHeaderOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderOne.Location = new System.Drawing.Point(332, 32);
            this.lblHeaderOne.Name = "lblHeaderOne";
            this.lblHeaderOne.Size = new System.Drawing.Size(104, 37);
            this.lblHeaderOne.TabIndex = 0;
            this.lblHeaderOne.Text = "Witaj!";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(269, 240);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(243, 67);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Rozpocznij tworzenie";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(310, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Zamknij generator";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCopyrights
            // 
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrights.Location = new System.Drawing.Point(257, 402);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(264, 16);
            this.lblCopyrights.TabIndex = 3;
            this.lblCopyrights.Text = "Generator Kart Postaci © LanternCode 2020";
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.Location = new System.Drawing.Point(701, 402);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(87, 36);
            this.btnCredits.TabIndex = 4;
            this.btnCredits.Text = "O autorze";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Visible = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // lblLangChoice
            // 
            this.lblLangChoice.AutoSize = true;
            this.lblLangChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLangChoice.Location = new System.Drawing.Point(307, 96);
            this.lblLangChoice.Name = "lblLangChoice";
            this.lblLangChoice.Size = new System.Drawing.Size(91, 16);
            this.lblLangChoice.TabIndex = 5;
            this.lblLangChoice.Text = "Wybierz język";
            // 
            // btnPolish
            // 
            this.btnPolish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolish.Location = new System.Drawing.Point(113, 74);
            this.btnPolish.Name = "btnPolish";
            this.btnPolish.Size = new System.Drawing.Size(110, 59);
            this.btnPolish.TabIndex = 6;
            this.btnPolish.Text = "Polski";
            this.btnPolish.UseVisualStyleBackColor = true;
            this.btnPolish.Click += new System.EventHandler(this.btnPolish_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.Location = new System.Drawing.Point(570, 74);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(112, 59);
            this.btnEnglish.TabIndex = 7;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnPolish);
            this.Controls.Add(this.lblLangChoice);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.lblCopyrights);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblHeaderOne);
            this.Name = "frmHome";
            this.Text = "Generator Kart Postaci The Remnants";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderOne;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCopyrights;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Label lblLangChoice;
        private System.Windows.Forms.Button btnPolish;
        private System.Windows.Forms.Button btnEnglish;
    }
}