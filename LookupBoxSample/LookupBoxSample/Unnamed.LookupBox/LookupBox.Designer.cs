namespace Unnamed.LookupBox
{
    partial class LookupBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayLabel = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.Location = new System.Drawing.Point(0, 0);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(200, 20);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "EMPTY";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.displayLabel);
            this.panel1.Controls.Add(this.inputText);
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 20);
            this.panel1.TabIndex = 3;
            // 
            // displayLabel
            // 
            this.displayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayLabel.Location = new System.Drawing.Point(0, 0);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(3);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(200, 20);
            this.displayLabel.TabIndex = 6;
            this.displayLabel.Text = "[0] -";
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.historyButton.Location = new System.Drawing.Point(200, 0);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(22, 20);
            this.historyButton.TabIndex = 7;
            this.historyButton.Text = "v";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.browseButton.Location = new System.Drawing.Point(222, 0);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(22, 20);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "?";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // LookupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "LookupBox";
            this.Size = new System.Drawing.Size(244, 18);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button browseButton;
    }
}
