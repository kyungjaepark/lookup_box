using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unnamed.LookupBox
{
    public partial class LookupBoxCandidateForm : Form
    {
        public LookupBoxCandidateForm()
        {
            InitializeComponent();
        }

        LookupBox _lookupBox = null;
        bool isReady = false;
        public void ready(Label textLabel, LookupBox lookupBox)
        {
            string findText = textLabel.Text;
            textBox1.Width = textLabel.Width;
            textBox1.Text = findText;
            textBox1.Focus();
            _lookupBox = lookupBox;
            isReady = true;

            listView1.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0 && _lookupBox != null)
            {
                _lookupBox.ItemID = _searchResult[listView1.SelectedIndices[0]]["id"] as String;
                _lookupBox.Focus();
                this.Hide();
            }
        }

        private void LookupBoxCandidateForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LookupBoxCandidateForm_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        DataRow[] _searchResult = null;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isReady == false)
                return;

            listView1.Visible = true;

            listView1.VirtualListSize = 0;
            if (_lookupBox.BaseDataSet == null)
                return;

            DataTable dt = _lookupBox.BaseDataSet.Tables[_lookupBox.ItemType];
            if (dt == null)
                return;
            DataRow[] drResult = dt.Select(String.Format("id LIKE '%{0}%' OR name LIKE '%{0}%'", textBox1.Text.Replace("'", "''")));
            _searchResult = drResult;
            listView1.VirtualListSize = drResult.Length;
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (_searchResult == null || _searchResult.Length <= e.ItemIndex)
                return;
            DataRow dr = _searchResult[e.ItemIndex];

            ListViewItem lvi = new ListViewItem(dr["id"] as String);
            lvi.SubItems.Add(dr["name"] as String);
            if (dr["desc"] != null)
                lvi.SubItems.Add(dr["desc"] as String);

            e.Item = lvi;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                this.Hide();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                _lookupBox.ItemID = textBox1.Text;
                _lookupBox.Focus();
                this.Hide();

            }
        }
    }
}
