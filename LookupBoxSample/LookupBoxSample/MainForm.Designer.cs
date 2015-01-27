namespace LookupBoxSample
{
    partial class MainForm
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
            this.lookupBox1 = new Unnamed.LookupBox.LookupBox();
            this.SuspendLayout();
            // 
            // lookupBox1
            // 
            this.lookupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.lookupBox1.BaseDataSet = null;
            this.lookupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lookupBox1.ItemType = "s";
            this.lookupBox1.ItemID = "s";
            this.lookupBox1.ItemWidth = 67;
            this.lookupBox1.Location = new System.Drawing.Point(12, 12);
            this.lookupBox1.Name = "lookupBox1";
            this.lookupBox1.Size = new System.Drawing.Size(246, 20);
            this.lookupBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 325);
            this.Controls.Add(this.lookupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Unnamed.LookupBox.LookupBox lookupBox1;
    }
}

