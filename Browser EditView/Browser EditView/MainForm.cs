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
                Uri URL = new Uri("https://bing.com/");
                webControl1.Source = URL;
            }
        }
    }
}
