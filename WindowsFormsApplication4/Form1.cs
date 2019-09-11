using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        Methods methods = new Methods();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Events selection
        private void Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfirmCreate.Items.Clear();
        }
        //Nozzle id select
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConfirmCreate.Items.Clear();
        }
        //Create Button
        private void Create_Click(object sender, EventArgs e)
        {
            int value = 0;
            value = Int32.Parse(NozzleId.Text);
            if (methods.NozzleExist(value))
            {
                 if (Int32.TryParse(NozzleId.Text, out value) && Events.SelectedItem != null)
                            {
                                ConfirmCreate.Items.Clear();
                
                                methods.EventLog(Events.SelectedItem.ToString(), Decimal.ToInt32(value), DatePicker.Value);
                                NozzleId.Text = "";
                                ConfirmCreate.Items.Add("Event created");
                             }
            }
            
           else
            {
                ConfirmCreate.Items.Clear();
                ConfirmCreate.Items.Add("Please enter a valid nozzle id");
            }

        }
        private void EnterKeyPressedCreateEvent(object sender, KeyEventArgs key)
        {
            if (key.KeyCode.Equals(Keys.Return))
            {
                int value = 0;
                value = Int32.Parse(NozzleId.Text);
                if (methods.NozzleExist(value))
                {
                    if (Int32.TryParse(NozzleId.Text, out value) && Events.SelectedItem != null)
                    {
                        ConfirmCreate.Items.Clear();

                        methods.EventLog(Events.SelectedItem.ToString(), Decimal.ToInt32(value), DatePicker.Value);
                        NozzleId.Text = "";
                        ConfirmCreate.Items.Add("Event created");
                    }
                }

                else
                {
                    ConfirmCreate.Items.Clear();
                    ConfirmCreate.Items.Add("Please enter a valid nozzle id");
                }

            }
        }
        //date of event selection
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ConfirmCreate.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Value = 0;
            if (Int32.TryParse(Nozzle_Id.Text, out Value) && Events.SelectedItem != null)
            {
                listBox1.Items.Clear();
                foreach (string s in Regex.Split(methods.RetrieveEvents(Decimal.ToInt32(Value), true), "\n"))
                    listBox1.Items.Add(s);
            }
        }
        private void EnterKeyPressedShowEvents(object sender, KeyEventArgs key)
        {
            if (key.KeyCode.Equals(Keys.Return))
            {
                int Value = 0;
                if (Int32.TryParse(Nozzle_Id.Text, out Value) && Events.SelectedItem != null)
                {
                    listBox1.Items.Clear();
                    foreach (string s in Regex.Split(methods.RetrieveEvents(Decimal.ToInt32(Value), true), "\n"))
                        listBox1.Items.Add(s);
                }
            }
        }
        private void ShowNeedChange_Click(object sender, EventArgs e)
        {

            ListBoxNeedChange.Items.Clear();
            foreach (string s in Regex.Split(methods.CheckForChange(dateTimePicker1.Value), "\n"))
                ListBoxNeedChange.Items.Add(s);
        }
        private void EnterKeyPressedShowNeedChange(object sender, KeyEventArgs key)
        {
            if (key.KeyCode.Equals(Keys.Return))
            {
                ListBoxNeedChange.Items.Clear();
                foreach (string s in Regex.Split(methods.CheckForChange(dateTimePicker1.Value), "\n"))
                    ListBoxNeedChange.Items.Add(s);
            }
        }

        private void NozzleId_TextChanged(object sender, EventArgs e)
        {
            ConfirmCreate.Items.Clear();
        }

        private void Nozzle_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}