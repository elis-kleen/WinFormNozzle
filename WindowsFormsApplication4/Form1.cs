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
        public void Create()
        {
            int value = 0;
            
            //checking if the user has entered everyrhing in the right way
            if (Int32.TryParse(NozzleId.Text, out value) && Events.SelectedItem != null)
            {
                value = Int32.Parse(NozzleId.Text);
                //check if the user has entered a number
                if (methods.NozzleExist(value))
                {
                    ConfirmCreate.Items.Clear();
                    //create the event
                    methods.EventLog(Events.SelectedItem.ToString(), Decimal.ToInt32(value), DatePicker.Value);
                    NozzleId.Text = "";
                    //confirming the create for the user
                    ConfirmCreate.Items.Add("Event created");
                }
                else
                {
                    //tell the user to enter a valid nozzle id
                    ConfirmCreate.Items.Clear();
                    NozzleId.Text = "";
                    ConfirmCreate.Items.Add("Please enter a valid nozzle id");
                }
            }
            else if(!Int32.TryParse(NozzleId.Text, out value))
            {
                ConfirmCreate.Items.Clear();
                NozzleId.Text = "";
                ConfirmCreate.Items.Add("Please enter a valid nozzle id and");
            }
            //if the user doesn´t enter an event 
            else if (Events.SelectedItem == null)
            {
                //telling the user to enter an event
                ConfirmCreate.Items.Clear();
                ConfirmCreate.Items.Add("Please enter an event");
            }




        }
        //Create Button
        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        //Pressing enter when in the ceate stage 
        private void EnterKeyPressedCreateEvent(object sender, KeyEventArgs key)
        {
            if (key.KeyCode.Equals(Keys.Return))
                Create();
        }
        //date of event selection
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ConfirmCreate.Items.Clear();
        }

        void ViewEvents()
        {
            int Value = 0;
            //check if the user has entered a number 
            if (Int32.TryParse(Nozzle_Id.Text, out Value))
            {
                int NozzleId = Int32.Parse(Nozzle_Id.Text);
                //check if the nozzle id the user has entered exist in the database
                if (methods.NozzleExist(NozzleId))
                {
                    //showing the events of the nozzle the user wanted
                    listBox1.Items.Clear();
                    foreach (string s in Regex.Split(methods.RetrieveEvents(NozzleId, true), "\n"))
                        listBox1.Items.Add(s);
                }
                else
                {
                    //telling the user to enter a valid nozzle id
                    listBox1.Items.Clear();
                    Nozzle_Id.Text = "";
                    listBox1.Items.Add("Please enter a valid nozzle id");
                }

            }
            else
            {
                //telling the user to enter a number
                listBox1.Items.Clear();
                Nozzle_Id.Text = "";
                listBox1.Items.Add("Please enter a valid nozzle id");
            }

        }
        //When the user clicks the show event btton
        private void button1_Click(object sender, EventArgs e)
        {
            ViewEvents();
        }
        //when a key is pressed in the show events tab
        private void EnterKeyPressedShowEvents(object sender, KeyEventArgs key)
        {
            //checks if the key pressed was enter 
            if (key.KeyCode.Equals(Keys.Return))
            {
                ViewEvents();
            }
        }

        //when the show nozzles button is clicked
        private void ShowNeedChange_Click(object sender, EventArgs e)
        {

            ListBoxNeedChange.Items.Clear();
            //calling a method that returns all of the events of one nozzle as a string
            //and then splits it into rows
            foreach (string s in Regex.Split(methods.CheckForChange(dateTimePicker1.Value), "\n"))
                ListBoxNeedChange.Items.Add(s);
        }
        //when a key is pressed in the show events tab
        private void EnterKeyPressedShowNeedChange(object sender, KeyEventArgs key)
        {
            //check if the key pressed was enter 
            if (key.KeyCode.Equals(Keys.Return))
            {
                ListBoxNeedChange.Items.Clear();
                //calling a method that returns all of the events of one nozzle as a string
                //and then splits it into rows
                foreach (string s in Regex.Split(methods.CheckForChange(dateTimePicker1.Value), "\n"))
                    ListBoxNeedChange.Items.Add(s);
            }
        }

        private void NozzleId_TextChanged(object sender, EventArgs e)
        {
            ConfirmCreate.Items.Clear();
        }
    }
}