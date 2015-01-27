using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Unnamed.LookupBox
{
    public partial class LookupBox : UserControl
    {
        public LookupBox()
        {
            InitializeComponent();
        }

        private DataSet _ds = null;
        private String _itemId = null;
        private String _itemType = null;
        private LookupBoxCandidateForm _candidateForm = new LookupBoxCandidateForm();
        public DataSet BaseDataSet
        {
            get { return _ds; }
            set
            {
                _ds = value;
                refreshDisplayLabel();
            }
        }
        public String ItemType
        {
            get { return _itemType; }
            set
            {
                _itemType = value;
                refreshDisplayLabel();
            }
        }
        public String ItemID
        {
            get { return _itemId; }
            set
            {
                _itemId = value;
                textBox1.Text = _itemId;
                refreshDisplayLabel();
            }
        }
        public int ItemWidth
        {
            get { return textBox1.Width; }
            set { textBox1.Width = value;  }
        }

        public static string StringItemIdNotAvailable = "(?)";
        public static string StringNameNotAvailable = "(#N/A)";
        public static string DisplayFormat = "{1}";

        private void refreshDisplayLabel()
        {
            string orgLabel = getDisplayLabel();
            displayLabel.Text = orgLabel;
            toolTip1.SetToolTip(displayLabel, orgLabel);
        }

        private string getDisplayLabel()
        {
            if (String.IsNullOrEmpty(_itemId))
                return StringItemIdNotAvailable;

            if (_ds == null)
                return _itemId;

            string name = StringNameNotAvailable;
            if (_ds.Tables.Contains(_itemType)) 
            {
                DataRow[] drList = _ds.Tables[_itemType].Select("id = '" + _itemId.Replace("'", "''") + "'");
                if (drList.Length == 1)
                    name = drList[0]["name"] as String;
            }

            return String.Format(DisplayFormat, _itemId, name);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox1.SelectAll();
                ItemID = textBox1.Text;
            }

            if (e.KeyCode == Keys.Escape)
            {
                _candidateForm.Hide();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                return;

            _candidateForm.Show();
            _candidateForm.Top = this.PointToScreen(new Point(0, 0)).Y + this.Height;
            _candidateForm.Left = this.PointToScreen(new Point(0, 0)).X;
            _candidateForm.TopMost = true;
            _candidateForm.ready(this.ItemType, textBox1.Text, this.BaseDataSet, this);
            this.Focus();
        }
    }

    public class EllipsisLabel : Label
    {

        // from https://social.msdn.microsoft.com/Forums/vstudio/en-US/f452fd0d-a4f1-49fa-ac3a-da614540cbf1
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);
            System.Drawing.StringFormat sf = System.Drawing.StringFormat.GenericDefault;
            sf.FormatFlags = StringFormatFlags.LineLimit;
            sf.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            RectangleF rect = new RectangleF(0, this.Padding.Top, this.Width, this.Height);
            using (SolidBrush brush = new System.Drawing.SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, brush, rect, sf);
            }
        }
    }
}
