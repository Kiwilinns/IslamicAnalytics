using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslamicAnalytics
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private async void FormFadeIn()
        {
            // Formu önce tamamen şeffaf hale getirin
            this.Opacity = 0.0;

            // Formu yavaş yavaş görünür hale getirin
            while (this.Opacity < 1.0)
            {
                this.Opacity += 0.05;
                await Task.Delay(20);
            }
        }

        private async void FormFadeOut()
        {
            // Formu yavaş yavaş şeffaf hale getirin
            while (this.Opacity > 0.0)
            {
                this.Opacity -= 0.05;
                await Task.Delay(20);
            }

            // Formu tamamen gizleyin
            this.Hide();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            FormFadeIn();
        }


        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            FormFadeOut();
            Application.Exit();
        }

        private void genereatefastreportButton_Click(object sender, EventArgs e)
        {
            generatefastraportForm gfrF = new generatefastraportForm();
            gfrF.Show();
            FormFadeOut();
        }

        private void slidesButton_Click(object sender, EventArgs e)
        {
            slidesForm slideF = new slidesForm();
            slideF.Show();
            FormFadeOut();
        }
    }
}
