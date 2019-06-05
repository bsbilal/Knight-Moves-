namespace KnightMoves
{
    partial class FormConfigs
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
            this.rdBes = new System.Windows.Forms.RadioButton();
            this.rdAlti = new System.Windows.Forms.RadioButton();
            this.rdYedi = new System.Windows.Forms.RadioButton();
            this.rdSekiz = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.rdDokuz = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBes
            // 
            this.rdBes.AutoSize = true;
            this.rdBes.Location = new System.Drawing.Point(15, 6);
            this.rdBes.Name = "rdBes";
            this.rdBes.Size = new System.Drawing.Size(51, 21);
            this.rdBes.TabIndex = 0;
            this.rdBes.TabStop = true;
            this.rdBes.Text = "5x5";
            this.rdBes.UseVisualStyleBackColor = true;
            // 
            // rdAlti
            // 
            this.rdAlti.AutoSize = true;
            this.rdAlti.Location = new System.Drawing.Point(15, 33);
            this.rdAlti.Name = "rdAlti";
            this.rdAlti.Size = new System.Drawing.Size(51, 21);
            this.rdAlti.TabIndex = 1;
            this.rdAlti.TabStop = true;
            this.rdAlti.Text = "6x6";
            this.rdAlti.UseVisualStyleBackColor = true;
            // 
            // rdYedi
            // 
            this.rdYedi.AutoSize = true;
            this.rdYedi.Location = new System.Drawing.Point(142, 6);
            this.rdYedi.Name = "rdYedi";
            this.rdYedi.Size = new System.Drawing.Size(51, 21);
            this.rdYedi.TabIndex = 2;
            this.rdYedi.TabStop = true;
            this.rdYedi.Text = "7x7";
            this.rdYedi.UseVisualStyleBackColor = true;
            // 
            // rdSekiz
            // 
            this.rdSekiz.AutoSize = true;
            this.rdSekiz.Location = new System.Drawing.Point(142, 33);
            this.rdSekiz.Name = "rdSekiz";
            this.rdSekiz.Size = new System.Drawing.Size(51, 21);
            this.rdSekiz.TabIndex = 3;
            this.rdSekiz.TabStop = true;
            this.rdSekiz.Text = "8x8";
            this.rdSekiz.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(79, 104);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 33);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Güncelle";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rdDokuz
            // 
            this.rdDokuz.AutoSize = true;
            this.rdDokuz.Location = new System.Drawing.Point(77, 58);
            this.rdDokuz.Name = "rdDokuz";
            this.rdDokuz.Size = new System.Drawing.Size(51, 21);
            this.rdDokuz.TabIndex = 5;
            this.rdDokuz.TabStop = true;
            this.rdDokuz.Text = "9x9";
            this.rdDokuz.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSekiz);
            this.groupBox1.Controls.Add(this.rdDokuz);
            this.groupBox1.Controls.Add(this.rdYedi);
            this.groupBox1.Controls.Add(this.rdAlti);
            this.groupBox1.Controls.Add(this.rdBes);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // FormConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 148);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Name = "FormConfigs";
            this.Text = "Configs";
            this.Load += new System.EventHandler(this.Configs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBes;
        private System.Windows.Forms.RadioButton rdAlti;
        private System.Windows.Forms.RadioButton rdYedi;
        private System.Windows.Forms.RadioButton rdSekiz;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rdDokuz;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}