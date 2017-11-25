// Program 2
// CIS 199-01/-75
// Due: 3/06/2016
// By: Spencer G. Duncan

// This program displays a message box that informs
// the user when they can register for classes in 
// Fall 2016. The user must enter their last name 
// and number of credit hours obtained.Does not use loops. 
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int SENIOR_HOURS = 90;//stores the minimum number of hours required to be a senior
            const int JUNIOR_HOURS = 60;//stores the minimum number of hours required to be a junior
            const int SOPHMORE_HOURS = 30;//stores the minimum number of hours required to be a sophmore

            char name; //stores the lower case letter users last name
            string hold;//stores the users last name
            string day;//stores the day the user registers
            string time;//stores the time the user registers
            float hours;//stores the number of credit hours a student has aquired

            hold = lastName.Text.ToLowerInvariant();
            name = hold[0];
            day = "";
            time = "";

            if (char.IsLetter(hold, 0))
            {
                if (float.TryParse(creditHours.Text, out hours) && (hours > 0))
                {
                    //Tests if you are a Senior and when you register
                    if (hours >= SENIOR_HOURS)
                    {
                        day = "Wednesday, March 30th";
                        if (name <= 'd')
                        {
                            time = "4:00 PM";
                        }
                        else if (name <= 'i')
                        {
                            time = "8:30 AM";
                        }
                        else if (name <= 'o')
                        {
                            time = "10:00 AM";
                        }
                        else if (name <= 's')
                        {
                            time = "11:30 AM";
                        }
                        else
                        {
                            time = "2:00 PM";
                        }
                    }

                    //Tests if you are a Junior and when you register
                    else if (hours >= JUNIOR_HOURS)
                    {
                        day = "Thursday, March 31st";
                        if (name <= 'd')
                        {
                            time = "4:00 PM";
                        }
                        else if (name <= 'i')
                        {
                            time = "8:30 AM";
                        }
                        else if (name <= 'o')
                        {
                            time = "10:00 AM";
                        }
                        else if (name <= 's')
                        {
                            time = "11:30 AM";
                        }
                        else
                        {
                            time = "2:00 PM";
                        }
                    }

                    //Tests if you are a Sophmore and when you register
                    else if (hours >= SOPHMORE_HOURS)
                    {
                        if (name <= 'b')
                        {
                            day = "Monday, April 4th";
                            time = "2:00 PM";
                        }
                        else if (name <= 'd')
                        {
                            day = "Monday, April 4th";
                            time = "4:00 PM";
                        }
                        else if (name <= 'f')
                        {
                            day = "Friday, Aril 1st";
                            time = "8:30 AM";
                        }
                        else if (name <= 'i')
                        {
                            day = "Friday, April 1st";
                            time = " 10:00 AM";
                        }
                        else if (name <= 'l')
                        {
                            day = "Friday, April 1st";
                            time = "11:30 AM";
                        }
                        else if (name <= 'o')
                        {
                            day = "Friday, April 1st";
                            time = "2:00 PM";
                        }
                        else if (name <= 'q')
                        {
                            day = "Friday, April 1st";
                            time = "4:00 PM";
                        }
                        else if (name <= 's')
                        {
                            day = "Monday, April 4th";
                            time = "8:30 AM";
                        }
                        else if (name <= 'v')
                        {
                            day = "Monday, April 4th";
                            time = "10:00 AM";
                        }
                        else
                        {
                            day = "Monday, April 4th";
                            time = "11:30 AM";
                        }
                    }

                    //Tests if you are a Freshman and when you register
                    else
                    {
                        if (name <= 'b')
                        {
                            day = "Wednesday, April 6th";
                            time = "2:00 PM";
                        }
                        else if (name <= 'd')
                        {
                            day = "Wednesday, April 6th";
                            time = "4:00 PM";
                        }
                        else if (name <= 'f')
                        {
                            day = "Tuesday, April 5th";
                            time = "8:30 AM";
                        }
                        else if (name <= 'i')
                        {
                            day = "Tuesday, April 5th";
                            time = " 10:00 AM";
                        }
                        else if (name <= 'l')
                        {
                            day = "Tuesday, April 5th";
                            time = "11:30 AM";
                        }
                        else if (name <= 'o')
                        {
                            day = "Tuesday, April 5th";
                            time = "2:00 PM";
                        }
                        else if (name <= 'q')
                        {
                            day = "Tuesday, April 5th";
                            time = "4:00 PM";
                        }
                        else if (name <= 's')
                        {
                            day = "Wednesday, April 6th";
                            time = "8:30 AM";
                        }
                        else if (name <= 'v')
                        {
                            day = "Wednesday, April 6th";
                            time = "10:00 AM";
                        }
                        else
                        {
                            day = "Wednesday, April 6th";
                            time = "11:30 AM";
                        }
                    }
                    MessageBox.Show("The earliest you can register is " + day + " at " + time + ".");
                }

                else
                    MessageBox.Show("Invalid Value Entered Into the Credit Hours Textbox.");
            }
            else
                MessageBox.Show("Invalid Value Entered Into the Last Name Textbox.");
        }
    }
}

