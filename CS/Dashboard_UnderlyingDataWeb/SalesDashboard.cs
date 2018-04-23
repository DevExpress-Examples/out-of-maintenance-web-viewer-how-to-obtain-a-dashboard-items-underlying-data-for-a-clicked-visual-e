using System;
using Dashboard_UnderlyingDataWeb.nwindDataSetTableAdapters;

namespace Dashboard_UnderlyingDataWeb {
    public partial class SalesDashboard : DevExpress.DashboardCommon.Dashboard {
        public SalesDashboard() {
            InitializeComponent();
        }

        private void SalesDashboard_DashboardLoading(object sender, EventArgs e) {
            SalesPersonTableAdapter categories = new SalesPersonTableAdapter();
            categories.Fill(this.nwindDataSet1.SalesPerson);
        }
    }
}
