using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Model;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class ViewTransactionReport_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                TransactionReport newReport = new TransactionReport();
                CrystalReportViewer1.ReportSource = newReport;
                newReport.SetDataSource(GenerateData(TransactionHandler.GetTransaction()));
            }
            else
            {
                Response.Redirect("Home_Page.aspx");
            }
        }

        private TokoBeDiaDataSet GenerateData(List<HeaderTransaction> Transaction)
        {
            TokoBeDiaDataSet DataSet = new TokoBeDiaDataSet();
            var HTrans = DataSet.HeaderTransaction;
            var DTrans = DataSet.DetailTransaction;

            foreach(var HTr in Transaction)
            {
                var HeaderTransaction = HTrans.NewRow();
                HeaderTransaction["HeaderTransactionID"] = HTr.HeaderTransactionID;
                HeaderTransaction["UserID"] = HTr.User.UserName;
                HeaderTransaction["PaymentTypeID"] = HTr.PaymentType.PaymentTypeName;
                HeaderTransaction["Date"] = HTr.Date;
                HTrans.Rows.Add(HeaderTransaction);

                foreach(var DTr in HTr.DetailTransactions)
                {
                    var DetailTransaction = DTrans.NewRow();
                    DetailTransaction["HeaderTransactionID"] = HTr.HeaderTransactionID;
                    DetailTransaction["ProductID"] = DTr.Product.ProductName;
                    DetailTransaction["Quantity"] = DTr.Product.ProductPrice * DTr.Quantity;

                    DTrans.Rows.Add(DetailTransaction);


                }

            }

            return DataSet;
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}