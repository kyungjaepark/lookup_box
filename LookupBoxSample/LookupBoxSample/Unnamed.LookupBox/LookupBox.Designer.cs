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
            this.components = new System.ComponentModel.Container();
            this.inputText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browseButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new Unnamed.LookupBox.EllipsisLabel();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.Location = new System.Drawing.Point(0, 0);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(290, 20);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "EMPTY";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.inputText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 20);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.displayLabel);
            this.splitContainer1.Size = new System.Drawing.Size(246, 20);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.historyButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(44, 20);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Location = new System.Drawing.Point(22, 0);
            this.browseButton.Margin = new System.Windows.Forms.Padding(0);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(22, 20);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "?";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyButton.Location = new System.Drawing.Point(0, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(0);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(22, 20);
            this.historyButton.TabIndex = 8;
            this.historyButton.Text = "v";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.displayLabel.Location = new System.Drawing.Point(0, 0);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(3);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.displayLabel.Size = new System.Drawing.Size(160, 20);
            this.displayLabel.TabIndex = 7;
            this.displayLabel.Text = "####";
            // 
            // LookupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "LookupBox";
            this.Size = new System.Drawing.Size(290, 18);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Unnamed.LookupBox.EllipsisLabel displayLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Label label1;
    }
}
