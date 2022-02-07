using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace settings_pro_adv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings_pro_adv.Properties.Settings.Default.selected_combo_index = this.comboBox1.SelectedIndex;
            settings_pro_adv.Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Int32 i;
            i = settings_pro_adv.Properties.Settings.Default.selected_combo_index;
            this.comboBox1.SelectedIndex =i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double  f;
            double.TryParse(this.textBox1.Text, out f);

            settings_pro_adv.Properties.Settings.Default.mark_num = f;
            settings_pro_adv.Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = settings_pro_adv.Properties.Settings.Default.mark_num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            settings_pro_adv.Properties.Settings.Default.check_state = this.checkBox1.Checked;
            settings_pro_adv.Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = settings_pro_adv.Properties.Settings.Default.check_state;
        }
    }
}
