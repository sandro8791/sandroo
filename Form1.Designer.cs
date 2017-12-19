namespace WHAT
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
            this.btMessage = new System.Windows.Forms.Button();
            this.txFone = new System.Windows.Forms.TextBox();
            this.txMessagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btMessage
            // 
            this.btMessage.Location = new System.Drawing.Point(353, 255);
            this.btMessage.Name = "btMessage";
            this.btMessage.Size = new System.Drawing.Size(130, 39);
            this.btMessage.TabIndex = 0;
            this.btMessage.Text = "Enviar Messagem";
            this.btMessage.UseVisualStyleBackColor = true;
            this.btMessage.Click += new System.EventHandler(this.btMessage_Click);
            // 
            // txFone
            // 
            this.txFone.Location = new System.Drawing.Point(61, 33);
            this.txFone.Name = "txFone";
            this.txFone.Size = new System.Drawing.Size(240, 22);
            this.txFone.TabIndex = 1;
            // 
            // txMessagem
            // 
            this.txMessagem.Location = new System.Drawing.Point(61, 61);
            this.txMessagem.Multiline = true;
            this.txMessagem.Name = "txMessagem";
            this.txMessagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txMessagem.Size = new System.Drawing.Size(422, 176);
            this.txMessagem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 343);
            this.Controls.Add(this.txMessagem);
            this.Controls.Add(this.txFone);
            this.Controls.Add(this.btMessage);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMessage;
        private System.Windows.Forms.TextBox txFone;
        private System.Windows.Forms.TextBox txMessagem;
    }
}

