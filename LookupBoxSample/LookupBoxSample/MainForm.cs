using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LookupBoxSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataSet ds_sample = new DataSet();
        private void MainForm_Load(object sender, EventArgs e)
        {
            ds_sample = Unnamed.LookupBox.SampleDataSet.createSampleDataSet();

            lookupBox1.BaseDataSet = ds_sample;
            lookupBox1.ItemType = "Stocks";
            lookupBox1.ItemID = "16050";
        }


    }
}
