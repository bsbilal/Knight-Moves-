namespace KnightMoves
{
    partial class FormGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.xxxzxxassa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSqr = new System.Windows.Forms.GroupBox();
            this.lblPossible = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(270, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skorunuz";
            // 
            // xxxzxxassa
            // 
            this.xxxzxxassa.AutoSize = true;
            this.xxxzxxassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxxzxxassa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xxxzxxassa.Location = new System.Drawing.Point(91, 412);
            this.xxxzxxassa.Name = "xxxzxxassa";
            this.xxxzxxassa.Size = new System.Drawing.Size(207, 25);
            this.xxxzxxassa.TabIndex = 1;
            this.xxxzxxassa.Text = "Mümkün Hamle Sayısı";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeni Oyuna Basla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpSqr
            // 
            this.grpSqr.Location = new System.Drawing.Point(42, 70);
            this.grpSqr.Name = "grpSqr";
            this.grpSqr.Size = new System.Drawing.Size(361, 336);
            this.grpSqr.TabIndex = 3;
            this.grpSqr.TabStop = false;
            // 
            // lblPossible
            // 
            this.lblPossible.AutoSize = true;
            this.lblPossible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossible.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPossible.Location = new System.Drawing.Point(328, 411);
            this.lblPossible.Name = "lblPossible";
            this.lblPossible.Size = new System.Drawing.Size(0, 25);
            this.lblPossible.TabIndex = 5;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSkor.Location = new System.Drawing.Point(370, 38);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(21, 24);
            this.lblSkor.TabIndex = 6;
            this.lblSkor.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Oyun Ayarı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(451, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblPossible);
            this.Controls.Add(this.grpSqr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xxxzxxassa);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "KnightMoves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xxxzxxassa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpSqr;
        private System.Windows.Forms.Label lblPossible;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Button button2;
    }
}

