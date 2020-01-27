namespace ArqAut00
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
            this.bt_CarregaArq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_CarregaArq
            // 
            this.bt_CarregaArq.Location = new System.Drawing.Point(94, 33);
            this.bt_CarregaArq.Name = "bt_CarregaArq";
            this.bt_CarregaArq.Size = new System.Drawing.Size(130, 41);
            this.bt_CarregaArq.TabIndex = 0;
            this.bt_CarregaArq.Text = "Open File";
            this.bt_CarregaArq.UseVisualStyleBackColor = true;
            this.bt_CarregaArq.Click += new System.EventHandler(this.bt_CarregaArq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 101);
            this.Controls.Add(this.bt_CarregaArq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_CarregaArq;
    }
}

