using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Practice_7___13._03._24.Program;

namespace Practice_7___13._03._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = checkedListBox1.SelectedItem.ToString();
            textBox1.Text = $"{selectedItem}\r\n{AutoDict[selectedItem]}";
            button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Mass
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Объем
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //Расстояние
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count == 0)
            {
                Output.Text = "No Selected Item's";
            }
            else
            {
                //Count Auto's == Mass / Gruz
                List<Auto> autoList = new List<Auto>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    autoList.Add(AutoDict[item.ToString()]);
                }
                //Auto auto = AutoDict[checkedListBox1.SelectedItem.ToString()];

                bool massReply = double.TryParse(Mass.Text, out double mass);
                if (massReply && mass > 0)
                {
                    bool vgruzReply = double.TryParse(VGruz.Text, out double vgruz);
                    if (vgruzReply && vgruz > 0)
                    {
                        bool putReply = double.TryParse(Putb.Text, out double putb);
                        if (putReply && putb > 0)
                        {
                            string text = "";
                            foreach (var auto in autoList)
                            {
                                double count = mass / auto.Gruz;
                                if (mass % auto.Gruz > 0) { count = Math.Truncate(count) + 1; }
                                double count_other = vgruz / auto.Vmest;
                                if (vgruz % auto.Vmest > 0) { count_other = Math.Truncate(count_other) + 1; }
                                count = count > count_other ? count : count_other;

                                double cost = auto.Tarif * count * putb;

                                text += $"Используя {auto.Name}\r\nСтоимость перевозки: {cost} рублей\r\nКоличество Машин: {count}\r\n\r\n";
                            }

                            Output.Text = text;
                        }
                        else
                        {
                            Output.Text = $"Putb is not defined";
                        }
                    }
                    else
                    {
                        Output.Text = $"vGruz is not defined";
                    }
                }
                else
                {
                    Output.Text = $"mass is not defined";
                }

            }



        }



        //Output
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void VGruz_NoReply_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
