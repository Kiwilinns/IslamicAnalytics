using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IslamicAnalytics
{
    public partial class generatefastraportForm : Form
    {
        public generatefastraportForm()
        {
            InitializeComponent();
        }

        public DateTime _fasttime;

        public string _fasttype, _fastname,_fastername,_watermark, _text;

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

        private void genereatefastreportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    writer.Write(_text);
                }
            }
        }

        private void generatefastraportForm_Load(object sender, EventArgs e)
        {
            FormFadeIn();
        }

        private void generatefastraportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void fasttypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _fasttime = fastdateDateTimerPicker.Value;
            _fasttype = fasttypeComboBox.Text;
            _fastname = nameoffastTextBox.Text;
            _fastername = fastingpeopleTextBox.Text;
            _watermark = watermarkTextBox.Text;

            _text = $"Fasting Report!\n1-Fast Date:{_fasttime.ToLongDateString()}\n2-Fast Type:{_fasttype}\n3-Fast Name:{_fastname}\n4-Name of the person fasting:{_fastername}\n{_watermark}";
        }
    }
}
