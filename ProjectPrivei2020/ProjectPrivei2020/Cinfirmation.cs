using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace ProjectPrivei2020
{
    public partial class Cinfirmation : Form
    {

        //credentials providing from the firebase
        IFirebaseConfig firebaseconfig = new FirebaseConfig
        {
            AuthSecret = "1KBjgixlJbZVuO5ZhwXWvNVh9pobrfjIOayGoHxK",
            BasePath = "https://finalyear-9781d.firebaseio.com/"
        };
        IFirebaseClient firebaseclient;


        int hours, mins, secs;
        static BL.InsertBL connectionblinsert = new BL.InsertBL();
        static BL.SelectBL connectionblselect = new BL.SelectBL();
        string generatedtime = "";
        string confirmedtime = "";
        string threatlevel = "";
        Timer t = new Timer();

        public Cinfirmation()
        {
            InitializeComponent();
        }

        private void Cinfirmation_Load(object sender, EventArgs e)
        {
            //firebase connection establishment
            firebaseclient = new FireSharp.FirebaseClient(firebaseconfig);
            if (firebaseclient != null)
            {
                MessageBox.Show("Connected with cloud Data Base");
            }
            else
            {
                MessageBox.Show("Error In connecting to the firebase database");
            }


            //-----------------------get status code----------------------------------------
            Form1 form = new Form1();
            string valuecall = form.callsenso0rvalues().ToString().Trim();
            String[] subsstring = valuecall.Split('/');
            threatlevel = subsstring[1];


            //get the generatyed time
            generatedtime = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            //Show Current Time
            t.Interval = 1000;  //in milliseconds
            t.Tick += new EventHandler(this.t_Tick);
            //start timer when form loads
            t.Start();  //this will use t_Tick() method

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            //show timer time out
            hours = 00;
            mins = 00;
            secs = 30;
            lblhr.Text = "00";
            lblmin.Text = "00";
            lblsec.Text = "00";
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (hours == 0 && mins == 0 && secs == 0)// on here we chack if the time is up and we add some stuff on times up
            {
                timer1.Stop();
                // MessageBox.Show(new Form() { TopMost = true }, "Times up!!! :P", "Will you press OK? :P", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblhr.Text = "00";
                lblmin.Text = "00";
                lblsec.Text = "00";
                try
                {
                    confirmedtime = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    connectionblinsert.inertalertdetails(threatlevel, 45, "Not Confirmed", generatedtime, confirmedtime, textBox1.Text.Trim(), "005");
                    Form1 form1 = new Form1();

                   uploadThreatLevel("Danger");
                    popupNotifications("!!!------TIMED OUT--------!!!\n ALERTS HAVE BEEN AUTOMATICALLY SENT");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("!!DataBase Error!!! \n\n" + "ERROR :-" + ex1);
                }



                // System.Windows.Forms.Application.Exit();
                this.Close();
            }
            else
            {
                if (secs < 1)// here is the most important code (dont forget to change the timer to 1000 milliseconds)!!! first we check if the secs are smaller than 1
                {
                    secs = 59;// on here we make the secs to 59 if it is smaller than 1
                    if (mins < 1)// here we check if the minutes are smaller than 1
                    {
                        mins = 59;// on here we make the mins to 59 if it is smaller than 1
                        if (hours != 0)// on here we check if the hours are different from 0
                            hours -= 1;// on here we remove from the current hour the number 1. its the same if we write hours = hours - 1;
                    }
                    else mins -= 1;// on here we remove fro mthe current mins 1
                }
                else secs -= 1;// and here we do the same with the seconds
                if (hours > 9)// and on this stage we add the numbers on the labels
                    lblhr.Text = hours.ToString();
                else lblhr.Text = "0" + hours.ToString();
                if (mins > 9)
                    lblmin.Text = mins.ToString();
                else lblmin.Text = "0" + mins.ToString();
                if (secs > 9)
                    lblsec.Text = secs.ToString();
                else lblsec.Text = "0" + secs.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {

            Boolean validate = connectionblselect.valiedadminid(textBox1.Text.Trim());
            if (validate == true)
            {
                //Form1 form = new Form1();
                //string valuecall = form.callsenso0rvalues().ToString().Trim();
                //String[] subsstring = valuecall.Split('/');
                //threatlevel = subsstring[1];
                confirmedtime = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                // MessageBox.Show("!!!------ALERTS HAVE BEEN SENT--------!!!");
                try
                {
                    connectionblinsert.inertalertdetails(threatlevel, 45, "confirmed", generatedtime, confirmedtime, textBox1.Text.Trim(), "005");
                    Form1 form1 = new Form1();
                    uploadThreatLevel("Danger");
                    popupNotifications("!!!------ALERTS HAVE BEEN SENT--------!!!");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("!!DataBase Error!!! \n\n" + "ERROR :-" + ex1);
                }

                this.Close();
            }
            else if (validate == false)
            {
                MessageBox.Show("Invalied Admin id");
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            clock.Text = time;
        }



        //notification

        //notification popup
        public void popupNotifications(String message)
        {
            PopupNotifier popupNotifier = new PopupNotifier();
            Bitmap objBitmap = new Bitmap(Properties.Resources.download, new Size(90, 90));
            popupNotifier.Image = objBitmap;
            popupNotifier.Image.Width.Equals(5);
            popupNotifier.Delay = 1000000;
            popupNotifier.TitleText = "Flood Warning!!";
            popupNotifier.ContentText = "" + message;
            popupNotifier.Popup();
        }


        //upload thret levl to cloud database

        public async void uploadThreatLevel(String status1)
        {
            try
            {
                var threatstatus = new ThreatStatus
                {
                    State = status1
                };

                SetResponse response = await firebaseclient.SetTaskAsync("DisasterStatus", threatstatus);
                ThreatStatus results = response.ResultAs<ThreatStatus>();
                MessageBox.Show("Data Inserted" + results.State);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Status :-" + e);
            }

        }
    }
}
