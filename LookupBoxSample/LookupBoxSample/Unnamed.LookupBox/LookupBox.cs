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
        private String _category = null;
        public DataSet BaseDataSet
        {
            get { return _ds; }
            set
            {
                _ds = value;
                refreshDisplayLabel();
            }
        }
        public String ItemCategory
        {
            get { return _category; }
            set
            {
                _category = value;
                refreshDisplayLabel();
            }
        }
        public String ItemID
        {
            get { return _itemId; }
            set
            {
                _itemId = value;
                refreshDisplayLabel();
            }
        }

        public static string StringItemIdNotAvailable = "(#N/A)";
        public static string StringNameNotAvailable = "(- ? -)";
        public static string DisplayFormat = "{0} {1}";

        private void refreshDisplayLabel()
        {
            displayLabel.Text = getDisplayLabel();
        }

        private string getDisplayLabel()
        {
            if (String.IsNullOrEmpty(_itemId))
                return StringItemIdNotAvailable;

            if (_ds == null)
                return _itemId;

            string name = StringNameNotAvailable;
            if (_ds.Tables.Contains(_category)) 
            {
                DataRow[] drList = _ds.Tables[_category].Select("id = " + _itemId);
                if (drList.Length == 1)
                    name = drList[0]["name"] as String;
            }

            return String.Format(DisplayFormat, _itemId, name);
        }
    }
}
