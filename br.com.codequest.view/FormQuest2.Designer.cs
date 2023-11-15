namespace Jogo_I_AEP.br.com.codequest.view
{
    partial class FormQuest2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpcao1 = new System.Windows.Forms.Button();
            this.btnOpcao2 = new System.Windows.Forms.Button();
            this.btnOpcao4 = new System.Windows.Forms.Button();
            this.btnOpcao3 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quest 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_I_AEP.Properties.Resources.quebra_cabeca;
            this.pictureBox1.Location = new System.Drawing.Point(288, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Para concluir o quebra cabeça responda,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uma pilha implementa o mecanismos de inserção/remoção:";
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.Location = new System.Drawing.Point(15, 116);
            this.btnOpcao1.Name = "btnOpcao1";
            this.btnOpcao1.Size = new System.Drawing.Size(262, 23);
            this.btnOpcao1.TabIndex = 7;
            this.btnOpcao1.Text = "FIFO";
            this.btnOpcao1.UseVisualStyleBackColor = true;
            this.btnOpcao1.Click += new System.EventHandler(this.btnOpcao1_Click);
            // 
            // btnOpcao2
            // 
            this.btnOpcao2.Location = new System.Drawing.Point(15, 145);
            this.btnOpcao2.Name = "btnOpcao2";
            this.btnOpcao2.Size = new System.Drawing.Size(261, 23);
            this.btnOpcao2.TabIndex = 8;
            this.btnOpcao2.Text = "FIFA";
            this.btnOpcao2.UseVisualStyleBackColor = true;
            this.btnOpcao2.Click += new System.EventHandler(this.btnOpcao2_Click);
            // 
            // btnOpcao4
            // 
            this.btnOpcao4.Location = new System.Drawing.Point(15, 203);
            this.btnOpcao4.Name = "btnOpcao4";
            this.btnOpcao4.Size = new System.Drawing.Size(261, 23);
            this.btnOpcao4.TabIndex = 9;
            this.btnOpcao4.Text = "LIFO";
            this.btnOpcao4.UseVisualStyleBackColor = true;
            this.btnOpcao4.Click += new System.EventHandler(this.btnOpcao4_Click);
            // 
            // btnOpcao3
            // 
            this.btnOpcao3.Location = new System.Drawing.Point(15, 174);
            this.btnOpcao3.Name = "btnOpcao3";
            this.btnOpcao3.Size = new System.Drawing.Size(261, 23);
            this.btnOpcao3.TabIndex = 10;
            this.btnOpcao3.Text = "FFLL";
            this.btnOpcao3.UseVisualStyleBackColor = true;
            this.btnOpcao3.Click += new System.EventHandler(this.btnOpcao3_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(407, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 23);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormQuest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(429, 236);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnOpcao3);
            this.Controls.Add(this.btnOpcao4);
            this.Controls.Add(this.btnOpcao2);
            this.Controls.Add(this.btnOpcao1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuest2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuest2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpcao1;
        private System.Windows.Forms.Button btnOpcao2;
        private System.Windows.Forms.Button btnOpcao4;
        private System.Windows.Forms.Button btnOpcao3;
        private System.Windows.Forms.Button btnFechar;
    }
}