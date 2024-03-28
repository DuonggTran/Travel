using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Windows.Forms;
using System.Drawing;
namespace GUI
{
    internal class DataConnection
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        public void ThucThi(string sqltStr)
        {
            try
            {
                cnnStr.Open();
                SqlCommand cmd = new SqlCommand(sqltStr, cnnStr);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại" + ex);
            }
            finally
            {
                cnnStr.Close();
            }
        }
    }
}
