﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace WindowsFormsApplication4
{
    class Methods
    {
        Form form = new Form();
        //method to create an event in the seleced database
        public void EventLog(string EventName, int Nozzle_Id, DateTime DateAndTime)
        {
            //string to connect to the right database
            string conStr = "Data Source=.;Initial Catalog=NozzleTest;Integrated Security=True";
            using (var Con = new SqlConnection(conStr))
            {
                Con.Open();
                try
                {
                    //sending the data to the database
                    var sendCom = $"insert into  EventLog(Nozzle_Id, EventName, DateOfEvent) values  ('{Nozzle_Id}', '{EventName}', '{DateAndTime}')";
                    var Command = new SqlCommand(sendCom, Con);
                    var result = Command.ExecuteScalar();
                }
                catch (Exception e1)
                {

                }


            }
        }
        //method to get events from the database
        public string RetrieveEvents(int NozzleId, bool ShowNoEvents)
        {
            Form1 inputs = new Form1();
            string conStr = "Data Source=.;Initial Catalog=NozzleTest;Integrated Security=True";
            string rowAsString = "";

            using (var Con = new SqlConnection(conStr))
            {
                Con.Open();
                try
                {
                    var sendCom = $"select EventName, DateOfEvent from EventLog where Nozzle_Id = '{NozzleId}'";
                    var Command = new SqlCommand(sendCom, Con);
                    var reader = Command.ExecuteReader();

                    //if there is data for that specific nozzle 
                    if (reader.HasRows)
                    {
                        rowAsString += ("Event Name       Date of event \n");

                        //while there is data to read; add the data to a string 
                        while (reader.Read())
                        {
                            if (reader.GetValue(0).ToString() == "Line")
                                rowAsString += $"{reader.GetValue(0)}                {reader.GetValue(1)} \n";
                            else if (reader.GetValue(0).ToString() == "Park")
                                rowAsString += $"{reader.GetValue(0)}               {reader.GetValue(1)} \n";
                            else
                                rowAsString += $"{reader.GetValue(0)}             {reader.GetValue(1)} \n";
                        }

                    }
                    //if there is data and you want to show this text
                    else if (ShowNoEvents)
                        rowAsString += ($"No events found for Nozzle: {NozzleId} \n");
                    else
                        rowAsString = "";

                }
                catch (Exception e)
                {
                    Con.Close();
                    return e.ToString();
                }
                Con.Close();
                return rowAsString;
            }
            
            

        }

        public string CheckForChange(DateTime dateCheck)
        {


            bool NoChangesNeeded = true;
            string returnString = "";

            string conStr = "Data Source=.;Initial Catalog=NozzleTest;Integrated Security=True";
            using (var Con = new SqlConnection(conStr))
            {
                try
                {
                    Con.Open();
                    for (int i = 1; i <= 500; i++)
                    {
                        var sendCom = $@"select top 1 DateOfEvent 
                                        from EventLog
                                        where EventName = 'Line' and Nozzle_Id = '{i}'
                                        order by DateOfEvent desc";

                        var Command = new SqlCommand(sendCom, Con);
                        var result = Command.ExecuteScalar();

                        if (result != null)
                        {
                            var DateOfEvent = (DateTime)result;
                            int DaysSinceChange = DateTime.Compare(DateOfEvent, dateCheck);

                            if (DaysSinceChange < 0)
                            {
                                returnString += $"{i} needs change \n";
                                NoChangesNeeded = false;
                            }
                        }

                        
                    }
                    Con.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                if (NoChangesNeeded)
                    return "No changes needed";
                else
                    return returnString;

            }

        }
        public bool NozzleExist(int NozzleId)
        {

            string conStr = "Data Source=.;Initial Catalog=NozzleTest;Integrated Security=True";
            using (var Con = new SqlConnection(conStr))
            {
                Con.Open();
                try
                {
                    var sendCom = $@"  select * from [NozzleTest].[dbo].[NozzleTable] 
                                       where
                                       Nozzle_Id = '{NozzleId}' ";
                    var Command = new SqlCommand(sendCom, Con);
                    var reader = Command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        return false;
                    }
                    else
                        return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }
    }
}
