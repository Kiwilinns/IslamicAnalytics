using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslamicAnalytics
{
    public partial class slidesForm : Form
    {
        public slidesForm()
        {
            InitializeComponent();
        }

        private void ramadanQuizTrButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.canva.com/design/DAFdYraq63s/H254Twfws25kqYJM7g9i2A/view?utm_content=DAFdYraq63s&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton");
        }
    }
}
