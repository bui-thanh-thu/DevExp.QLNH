using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExp.QLNH.Properties
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucOrder _instance;
        public static ucOrder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucOrder();
                return _instance;
            }
        }
        public ucOrder()
        {
            InitializeComponent();
        }
    }
}
