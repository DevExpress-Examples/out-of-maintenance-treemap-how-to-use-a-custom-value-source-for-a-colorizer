using DevExpress.TreeMap;
using DevExpress.XtraTreeMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreemapColorizerValueProvider {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ((TreeMapFlatDataAdapter)treeMapControl1.DataAdapter).DataSource = CreateDataSet();
            ((TreeMapColorizerBase)treeMapControl1.Colorizer).ValueProvider = new ColorizerValueProvider();
        }
        public DataTable CreateDataSet() {
            string filePath = @"..\..\Data\HPI.xml";
            if (!string.IsNullOrWhiteSpace(filePath)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                if (dataSet.Tables.Count > 0)
                    return dataSet.Tables[0];
            }
            return null;
        }
    }

    public class ColorizerValueProvider : IColorizerValueProvider {
        double IColorizerValueProvider.GetValue(IHierarchicalItem item, int itemIndex) {
            DataRowView row = item.Tag as DataRowView;
            if (row != null)
                return (double)row["HPI"];
            return 0;
        }
    }
}
