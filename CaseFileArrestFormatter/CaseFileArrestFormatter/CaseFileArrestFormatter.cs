using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace CaseFileArrestFormatter
{
    public partial class CaseFileArrestFormatter : Form
    {
        public CaseFileArrestFormatter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string openingTags = "[B][FONT=Trebuchet MS][CENTER][table=\"width: 550, class: grid, align: center\"]\n[TR=\"bgcolor: #1E1E1E\"]\n[TD][table=\"width: 550, align: center\"][tr]\n[td][IMG]'https://i.imgur.com/qO2AJf8.png'[/IMG][/td][/tr][tr]\n[td][Font=Book Antique][Size=7][color=#8d8dFF][B]C A P T U R E D[/B][/color][/Size][/Font][/td][/tr][/table]\n[table=\"width: 550, align: center\"][tr][td]\n[size=2][table=\"width: 500, class: grid, align: center\"][Left]";
            
            string agent = "[TR][TD][COLOR=\"#8d8dff\"][B]Agent Name:[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + textBox1.Text + "[/COLOR][/TD][/TR]"; 
            string assist = "[TR][TD][COLOR=\"#8d8dff\"][B]Assistants:[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + textBox2.Text + "[/COLOR][/TD][/TR]"; 
            string suspect = "[TR][TD][COLOR=\"#8d8dff\"][B]Suspect Full Name:[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + textBox3.Text + "[/COLOR][/TD][/TR]";
            string date = "[TR][TD][COLOR=\"#8d8dff\"][B]Date of Arrest:[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + dateTimePicker1.Value.ToString().Substring(0, 10) + "[/COLOR][/TD][/TR]";
            object type = "[TR][TD][COLOR=\"#8d8dff\"][B]Type of Arrest[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + comboBox1.SelectedItem + "[/COLOR][/TD][/TR]";
            string drugs = "[TR][TD][COLOR=\"#8d8dff\"][B]Drugs Confiscated:[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + textBox5.Text + "[/COLOR][/TD][/TR]";
            string weapons = "[TR][TD][COLOR=\"#8d8dff\"][B]Arms Confiscated:[/B][/COLOR][/TD][TD] [color=#DCDCDC]" + textBox4.Text + "[/COLOR][/TD][/TR]";

            string mid = "[/Left][/table][/size][table=\"width: 500, class: grid, align: center\"][/table]\n[Font=Book Antique][Size=3][color=#8d8dFF][B][U]ARREST EVIDENCE[/U][/B][/color][/Size][/Font]\n";

            string frisk = "[spoiler]\n[B][COLOR=\"#DCDCDC\"][FONT=Book Antiqua]FRISK[/FONT][/COLOR][/B]\n[spoiler][img]" + textBox6.Text + "[/img][/spoiler]";
            //string confiscation = "[B][COLOR=\"#DCDCDC\"][FONT=Book Antiqua]FRISK[/FONT][/COLOR][/B]\n[spoiler][img]" + textBox7.Text + "[/img][/spoiler]";
            string confiscation = textBox7.Text != "" ? "[B][COLOR=\"#DCDCDC\"][FONT=Book Antiqua]FRISK[/FONT][/COLOR][/B]\n[spoiler][img]" + textBox7.Text + "[/img][/spoiler]" : "";
            string charges = "[B][COLOR=\"#DCDCDC\"][FONT=Book Antiqua]FRISK[/FONT][/COLOR][/B]\n[spoiler][img]" + textBox8.Text + "[/img][/spoiler]";
            string arrestInmates = "[B][COLOR=\"#DCDCDC\"][FONT=Book Antiqua]ARREST & INMATES[/FONT][/COLOR][/B]\n[spoiler][img]" + textBox9.Text + "[/img][/spoiler]";

            string closingTags = "[/spoiler][/td][/tr][/table][/TD][/TR][/table][/CENTER][/FONT][/B]";


            string res = openingTags + agent + assist + suspect + date + type + drugs + weapons + mid + frisk + confiscation + charges + arrestInmates + closingTags;

            //MessageBox.Show(agent + "\n" + assist +"\n" + suspect +"\n" + date +"\n" + type + "\n" + drugs + "\n" + weapons, "Output");
            Clipboard.SetText(res);
            MessageBox.Show(res, "Output");
            //MessageBox.Show("Format is copied.", "Output");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "None";
            textBox5.Text = "None";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            dateTimePicker1.ResetText();
            comboBox1.SelectedIndex = -1;
        }

    }
}
