using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_EditView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            OpenedTabs.Items.Add("New Tab");
        }

        private void OpenedTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = OpenedTabs.SelectedIndex;
            try
            {
                Uri URL = new Uri(OpenedTabs.Items[Index].ToString());
                webControl1.Source = URL;
            }
            catch (Exception)
            {
                Uri URL = new Uri("https://ru.search.yahoo.com/");
                webControl1.Source = URL;
            }
        }

        private void GoToSiteButton_Click(object sender, EventArgs e)
        {
            int Index = OpenedTabs.SelectedIndex;
            string SiteAddress = textBox1.Text;
            try
            {
                Uri URL = new Uri(OpenedTabs.Items[Index].ToString());
                webControl1.Source = new Uri(SiteAddress);
                OpenedTabs.Items[Index] = SiteAddress;
            }
            catch (Exception)
            {
                Uri URL = new Uri("https://ru.search.yahoo.com/");
                webControl1.Source = URL;
                MessageBox.Show("404 - Not founded.", "Browser EditView");
            }
        }
    }
}
