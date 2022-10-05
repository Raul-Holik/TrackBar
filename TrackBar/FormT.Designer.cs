namespace TrackBar
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
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.trcBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trcBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBx1
            // 
            this.txtBx1.Location = new System.Drawing.Point(319, 209);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.ReadOnly = true;
            this.txtBx1.Size = new System.Drawing.Size(100, 20);
            this.txtBx1.TabIndex = 0;
            // 
            // trcBar1
            // 
            this.trcBar1.Location = new System.Drawing.Point(319, 139);
            this.trcBar1.Maximum = 15;
            this.trcBar1.Name = "trcBar1";
            this.trcBar1.Size = new System.Drawing.Size(147, 45);
            this.trcBar1.TabIndex = 1;
            this.trcBar1.Scroll += new System.EventHandler(this.trcBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj je :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trcBar1);
            this.Controls.Add(this.txtBx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trcBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TrackBar trcBar1;
        private System.Windows.Forms.Label label1;
    }
}

