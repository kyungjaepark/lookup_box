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
        public void ready(string itemType, string findText, DataSet baseDataSet, LookupBox lookupBox)
        {
            _lookupBox = lookupBox;
            listView1.Items.Clear();
            DataTable dt = baseDataSet.Tables[itemType];
            if (dt == null)
                return;
            DataRow[] drResult = dt.Select(String.Format("id LIKE '%{0}%' OR name LIKE '%{0}%'", findText.Replace("'", "''")));
            foreach (DataRow dr in drResult)
            {
                ListViewItem lvi = listView1.Items.Add(dr["id"] as String);
                lvi.SubItems.Add(dr["name"] as String);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && _lookupBox != null)
            {
                _lookupBox.ItemID = listView1.SelectedItems[0].Text;
                _lookupBox.Focus();
                this.Hide();
            }
        }
    }
}
