using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

//firesharp
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProjectPrivei2020
{

    public partial class Form1 : Form
    {
        //credentials providing from the firebase
        IFirebaseConfig firebaseconfig = new FirebaseConfig
        {
            AuthSecret = "1KBjgixlJbZVuO5ZhwXWvNVh9pobrfjIOayGoHxK",
            BasePath = "https://finalyear-9781d.firebaseio.com/"
        };
        IFirebaseClient firebaseclient;


        //variables for arduno part
        private SerialPort myport;
        static string inn = "";
        static int inn1 = 0;
        static string time = "";
        static string status = "";
        private DateTime datetime;
        int count = 1;
        int dangercount = 0;
        int normalcount = 0;
        int notificationcount = 0;
        int lvl1counter = 0;
        int lvl2counter = 0;
        int lvl3counter = 0;
        Form confirmwindow = new Cinfirmation();
        static List<PointLatLng> point;
        static List<PointLatLng> safelocations;
        static string threatlevel = "";


        GMapOverlay markers = new GMapOverlay("markers");
        GMapOverlay safelocationoverlay = new GMapOverlay("safelocation");
        GMarkerGoogle marker;
        GMarkerGoogle markersafelocation;
        static BL.InsertBL connectionblinsert = new BL.InsertBL();
        static BL.DeleteBL connectionbldelete = new BL.DeleteBL();
        static BL.SelectBL connectionblselect = new BL.SelectBL();


        //this is for draw affeted areas map
        List<PointLatLng> gpollist = new List<PointLatLng>();
        //radioo buttons
        GMapOverlay lowerleveloverlay = new GMapOverlay("circularlvl1polygons");
        GMapPolygon lowerlevelpolygon = null;
        GMapOverlay mediumleveloverlay = new GMapOverlay("circularlvl2polygons");
        GMapPolygon mediumlevelpolygon = null;
        GMapOverlay highleveloverlay = new GMapOverlay("circularlvl3polygons");
        GMapPolygon highlevelpolygon = null;

        //buttons
        Boolean btnsafelocation = false;
        Boolean btnaffetectedarea = false;
        


        //variable for threat checking
        double lvl1waterlevel, lvl2waterlevel, lvl3waterlevel;
        string lastupdatelvl1, lastupdatelvl2, lastupdatelvl3;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //firebase connection establishment
            firebaseclient = new FireSharp.FirebaseClient(firebaseconfig);
            if(firebaseclient != null)
            {
                MessageBox.Show("Connected with cloud Data Base");
            }
            else
            {
                MessageBox.Show("Error In connecting to the firebase database");
            }


            closeholder.Visible = false;
            cardthreatlevel.Visible = false;
            //button4.Visible = false;
            //button5.Visible = false;
            //button6.Visible = false;


            //map module opening and mark sensor locations
            GmapLoading();
            point = new List<PointLatLng>();
            object[,] sensorLocations = connectionblselect.getLatLngOfSensors();
            int rows = sensorLocations.GetLength(0);
            int columns = sensorLocations.GetLength(1);
            for(int k = 0; k<rows; k++)
            {
                point.Add(new PointLatLng(Convert.ToDouble(sensorLocations[k, 1]), Convert.ToDouble(sensorLocations[k, 2])));
            }
            getThreatdetials();

            int i = 0;
            foreach (var points in point)
            {
                LoadMap(new PointLatLng(Convert.ToDouble(point[i].Lat), Convert.ToDouble(point[i].Lng)));
                AddMarker(new PointLatLng(Convert.ToDouble(point[i].Lat), Convert.ToDouble(point[i].Lng)), GMarkerGoogleType.blue_dot);
                i++;
            }

            //activationg sensors
            this.Activated += mainport;

            //inserting sensor value to the DB THREAD RUNNING
            Thread thread = new Thread(() =>
            {
                System.Timers.Timer time1 = new System.Timers.Timer();
                time1.Interval = 3 * 60 * 1000;
                time1.Elapsed += new System.Timers.ElapsedEventHandler(InsertData);

                time1.Start();
            })
            { IsBackground = true };
            thread.Start();


            //retrive threat details

        }



        //google map part---------------------------------------------------------------------------------------

        //google map configurations

        public void GmapLoading()
        {
            //setup the API key
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAVR9eQglFrAKCpuSWlnCV9Ao9QXEwJJCA";

            //configure the cache and create the cache folder
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"MapCache";
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = false;

            //set up the default map
            map.MapProvider = GMapProviders.GoogleMap;
            map.SetPositionByKeywords("Colombo, Sri Lanka");
            map.MinZoom = 1;
            map.MaxZoom = 18;
            map.Zoom = 15;
        }

        //adding marker
        private void AddMarker(PointLatLng pointtoadd, GMarkerGoogleType markertype = GMarkerGoogleType.blue_dot)
        {
            // var markers = new GMapOverlay("markers");
            marker = new GMarkerGoogle(pointtoadd, markertype);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private void AddSafeAreaMarker(PointLatLng pointtoadd, GMarkerGoogleType markertype = GMarkerGoogleType.blue_dot)
        {
            // var markers = new GMapOverlay("markers");
            markersafelocation = new GMarkerGoogle(pointtoadd, markertype);
            safelocationoverlay.Markers.Add(markersafelocation);
            map.Overlays.Add(safelocationoverlay);
        }

        private void ToolTip(PointLatLng pointtoadd, GMarkerGoogleType markertype = GMarkerGoogleType.blue_dot)
        {
            marker = new GMarkerGoogle(pointtoadd, markertype);
            markers.Markers.Remove(marker);
            marker.ToolTipText = "-------------------------------------\nTime : " + time + "\n \n Water Level : " + inn + "\n \n Status : " + status + "\n-------------------------------------";
            //adding tootltip
            var tooltip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.DarkBlue),
                Foreground = new SolidBrush(Color.White),
                Offset = new Point(10, -80),
                Stroke = new Pen(new SolidBrush(Color.Black)),
            };
            marker.ToolTip = tooltip;
            markers.Markers.Add(marker);

        }

        //loading map
        private void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }



        //arduno part----------------------------------------------------------------------------------------------------------

        //port initialization and configuring
        public void mainport(object sender, EventArgs e)
        {

            this.Activated -= mainport;
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM5";
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += datarecive;
            try
            {
                myport.Open();
                //// txttime.Text = "";
               MessageBox.Show("Sensor Units are Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sensor Units are not Connected");
            }
        }

        public void datarecive(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displaydata));
            inn = myport.ReadLine();
        }




        //general settings-------------------------------------------------------------------------------------------------------------

        //notification popup
        public void popupNotifications(String message)
        {
            if (notificationcount == 0)
            {
                confirmwindow = new Cinfirmation();
                confirmwindow.Show();
                notificationcount = 1;
            }
            PopupNotifier popupNotifier = new PopupNotifier();
            Bitmap objBitmap = new Bitmap(Properties.Resources.download, new Size(90, 90));
            popupNotifier.Image = objBitmap;
            popupNotifier.Image.Width.Equals(5);
            popupNotifier.Delay = 1000000;
            popupNotifier.TitleText = "Flood Warning!!";
            popupNotifier.ContentText = "----------------ALERT----------------ALERT-------------------------\n" + message;
            popupNotifier.Popup();
        }

        //displaying data
        private void displaydata(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            string ff;
     
            if (count == 1)
            {
                ff = "";
                count++;
            }
            else
            {
                ff = time + ":" + inn + "\n";
                string[] substrings = ff.Split(':');
                string sesnorval = substrings[3];
                int intsensorval = Convert.ToInt16(sesnorval);
                int i = 0;
                //check whether dangerous or not
                if (intsensorval < 13)
                {
                    dangercount++;
                    foreach (var points in point)
                    {
                        //add details to the tooltip
                        ToolTip(new PointLatLng(Convert.ToDouble(point[i].Lat), Convert.ToDouble(point[i].Lng)), GMarkerGoogleType.blue_dot);
                        i++;
                    }
                    status = "DANGER";
                    //  txttime.Text = time.ToString();
                    lblsensor.Text = inn.ToString();
                   // lbltime.Text = time.ToString();
                   // txtstatus.Text = status;

                    if (dangercount > 30)
                    {
                        if (intsensorval >= 0 && intsensorval < 4)
                        {
                            if (lvl3counter == 0)
                            {
                                threatlevel = "LEVEL 3";
                                popupNotifications("LEVEL 3 ALERT: Waiting For Your Confirmation!!!!! \n Alerts Will automatically send Within 15 Minitues");
                                lvl3counter++;
                            }
                        }
                        else if (intsensorval >= 4 && intsensorval < 8)
                        {
                            if (lvl2counter == 0)
                            {
                                threatlevel = "LEVEL 2";
                                popupNotifications("LEVEL 2 ALERT: Waiting For Your Confirmation!!!!! \n Alerts Will automatically send Within 15 Minitues");
                                lvl2counter++;
                            }
                        }
                        else if (intsensorval >= 8 && intsensorval < 12)
                        {
                            if (lvl1counter == 0)
                            {
                                threatlevel = "LEVEL 1";
                                popupNotifications("LEVEL 1 ALERT: Waiting For Your Confirmation!!!!! \n Alerts Will automatically send Within 15 Minitues");
                                lvl1counter++;
                            }

                        }
                        dangercount = 0;
                        normalcount = 0;
                       // connectionblinsert.AddSensorData("1", time, Convert.ToDouble(inn), status, point[0].Lat, point[0].Lng);
                        //here we need to add the details about the threat alerts
                    }
                }
                else
                {
                    foreach (var points in point)
                    {
                        ToolTip(new PointLatLng(Convert.ToDouble(point[i].Lat), Convert.ToDouble(point[i].Lng)), GMarkerGoogleType.blue_dot);
                        i++;
                    }
                    status = "NORMAL";
                 //   lbltime.Text = time.ToString();
                    lblsensor.Text = inn.ToString();
                    // txttime.Text = time.ToString();
                    normalcount++;
                    if (normalcount > 60)
                    {
                        notificationcount = 0;
                        dangercount = 0;
                        normalcount = 0;
                        lvl1counter = 0;
                        lvl2counter = 0;
                        lvl3counter = 0;
                    }


                }
            }
            //automatically deleting table
            cleartablessensorvalues();
        }


        //buttons///////////////////////////////////////////////
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Cinfirmation conm = new Cinfirmation();
            conm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            btnaffetectedarea = true;
            cardthreatlevel.Visible = true;
            closeholder.Visible = true;
        }

        private void level1button_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(map.Zoom.ToString());
            if ((lowerleveloverlay != null) || (mediumleveloverlay != null) || (highleveloverlay != null))
            {
                lowerleveloverlay.Polygons.Clear();
                lowerleveloverlay.Clear();
                mediumleveloverlay.Polygons.Clear();
                mediumleveloverlay.Clear();
                highleveloverlay.Polygons.Clear();
                highleveloverlay.Clear();
                map.Zoom = l + 1;
                map.Zoom = l;
                //map.Overlays.Add(polygonsoverlay1);

            }
            int j = 0;
            foreach (var points in point)
            {
                double lat = Convert.ToDouble(point[j].Lat);
                double lon = Convert.ToDouble(point[j].Lng);
                int segments = 100;
                double radius = lvl1waterlevel;

                //                Google

                // List<PointLatLng>
                gpollist = new List<PointLatLng>();
                double seg = Math.PI * 2 / segments;
                for (int i = 0; i < segments; i++)
                {
                    double theta = seg * i;
                    double a = lat + Math.Cos(theta) * radius;
                    double b = lon + Math.Sin(theta) * radius;
                    PointLatLng gpoi = new PointLatLng(a, b);
                    gpollist.Add(gpoi);
                }
                lowerlevelpolygon = new GMapPolygon(gpollist, "pol");
                lowerlevelpolygon.Stroke = new Pen(Color.LightBlue, 2);
                lowerlevelpolygon.Fill = new SolidBrush(Color.FromArgb(20, Color.LightGreen));
                lowerleveloverlay.Polygons.Add(lowerlevelpolygon);
                map.Overlays.Add(lowerleveloverlay);
                j++;
            }
            map.Zoom = l + 1;
            map.Zoom = l;
        }


        private void lvl2button_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(map.Zoom.ToString());
            if ((lowerleveloverlay != null) || (mediumleveloverlay != null) || (highleveloverlay != null))
            {
                lowerleveloverlay.Polygons.Clear();
                lowerleveloverlay.Clear();
                mediumleveloverlay.Polygons.Clear();
                mediumleveloverlay.Clear();
                highleveloverlay.Polygons.Clear();
                highleveloverlay.Clear();
                map.Zoom = l + 1;
                map.Zoom = l;
            }
            int j = 0;
            foreach (var points in point)
            {
                double lat = Convert.ToDouble(point[j].Lat);
                double lon = Convert.ToDouble(point[j].Lng);
                int segments = 100;
                double radius = lvl2waterlevel;
                //                Google
                gpollist = new List<PointLatLng>();
                double seg = Math.PI * 2 / segments;
                int y = 0;
                for (int i = 0; i < segments; i++)
                {
                    double theta = seg * i;
                    double a = lat + Math.Cos(theta) * radius;
                    double b = lon + Math.Sin(theta) * radius;
                    PointLatLng gpoi = new PointLatLng(a, b);
                    gpollist.Add(gpoi);
                }
                mediumlevelpolygon = new GMapPolygon(gpollist, "pol");
                mediumlevelpolygon.Stroke = new Pen(Color.DarkOrange, 2);
                mediumlevelpolygon.Fill = new SolidBrush(Color.FromArgb(10, Color.Yellow));
                mediumleveloverlay.Polygons.Add(mediumlevelpolygon);
                map.Overlays.Add(mediumleveloverlay);
                j++;
            }
            map.Zoom = l + 1;
            map.Zoom = l;
        }

        private void level3button_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(map.Zoom.ToString());
            if ((lowerleveloverlay != null) || (mediumleveloverlay != null) || (highleveloverlay != null))
            {
                lowerleveloverlay.Polygons.Clear();
                lowerleveloverlay.Clear();
                mediumleveloverlay.Polygons.Clear();
                mediumleveloverlay.Clear();
                highleveloverlay.Polygons.Clear();
                highleveloverlay.Clear();
                map.Zoom = l + 1;
                map.Zoom = l;
            }
            int j = 0;
            foreach (var points in point)
            {
                double lat = Convert.ToDouble(point[j].Lat);
                double lon = Convert.ToDouble(point[j].Lng);
                int segments = 100;
                double radius = lvl3waterlevel;
                //                Google
                gpollist = new List<PointLatLng>();
                double seg = Math.PI * 2 / segments;
                int y = 0;
                for (int i = 0; i < segments; i++)
                {
                    double theta = seg * i;
                    double a = lat + Math.Cos(theta) * radius;
                    double b = lon + Math.Sin(theta) * radius;

                    PointLatLng gpoi = new PointLatLng(a, b);

                    gpollist.Add(gpoi);
                }
                highlevelpolygon = new GMapPolygon(gpollist, "pol");
                highlevelpolygon.Stroke = new Pen(Color.DarkRed, 2);
                highlevelpolygon.Fill = new SolidBrush(Color.FromArgb(10, Color.Red));
                highleveloverlay.Polygons.Add(highlevelpolygon);
                map.Overlays.Add(highleveloverlay);
                j++;
            }
            map.Zoom = l + 1;
            map.Zoom = l;
        
    }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            btnsafelocation = true;
            closeholder.Visible = true;
            GmapLoading();
            safelocations = new List<PointLatLng>();
            safelocations.Add(new PointLatLng(6.81283593827915, 79.8790168762207));
            safelocations.Add(new PointLatLng(6.81905729621839, 79.9005603790283));
            safelocations.Add(new PointLatLng(6.81057748015267, 79.8793172836304));

            int i = 0;
            foreach (var safelocation in safelocations)
            {
                LoadMap(new PointLatLng(Convert.ToDouble(safelocations[i].Lat), Convert.ToDouble(safelocations[i].Lng)));
                AddSafeAreaMarker(new PointLatLng(Convert.ToDouble(safelocations[i].Lat), Convert.ToDouble(safelocations[i].Lng)), GMarkerGoogleType.green_dot);

               // markersafelocation = new PointLatLng((Convert.ToDouble(point[i].Lat), Convert.ToDouble(point[i].Lng)), GMarkerGoogleType.blue_dot);
                i++;
            }
        }

        private void btnAddSensors_Click(object sender, EventArgs e)
        {
            AddLocations addLocations = new AddLocations();
            addLocations.Show();
        }



        private void map_Load(object sender, EventArgs e)
        {

        }

        private void closesafearea_Click(object sender, EventArgs e)
        {
            if (btnsafelocation == true)
            {
                safelocations.Clear();
                safelocationoverlay.Clear();
                map.Refresh();
                closeholder.Visible = false;
                btnsafelocation = false;
            }
            if(btnaffetectedarea == true)
            {
                if ((lowerleveloverlay != null) || (mediumleveloverlay != null) || (highleveloverlay != null))
                {
                    lowerleveloverlay.Polygons.Clear();
                    lowerleveloverlay.Clear();
                    mediumleveloverlay.Polygons.Clear();
                    mediumleveloverlay.Clear();
                    highleveloverlay.Polygons.Clear();
                    highleveloverlay.Clear();
                    map.Zoom = map.Zoom + 1;
                    map.Zoom = map.Zoom - 1;

                }
                cardthreatlevel.Visible = false;
            }
        }

        /// <summary>
        /// /buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex1"></param>


        //database parts----------------------------------------------------------------------------------------------------------------
        private void InsertData(object sender, System.Timers.ElapsedEventArgs ex1)
        {
            try
            {
                if (!time.Equals("") && !inn.Equals("") && !status.Equals(""))
                {

                    datetime = DateTime.Now;
                    String date = datetime.Year + "-" + datetime.Month + "-" + datetime.Date;
                    connectionblinsert.AddSensorData("1", Convert.ToDouble(inn), status, point[0].Lat, point[0].Lng);
                    connectionblinsert.ADDDailySync("1", Convert.ToDouble(inn), status, point[0].Lat, point[0].Lng, date);
                    uploadWaterLevl(Convert.ToDouble(inn));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //getpastthreatdetails

        private void getThreatdetials()
        {
            DataTable dt = new DataTable();
            //  DataRow rows = dt.NewRow();
            dt = connectionblselect.selectthreatlevel1details();
            lvl1waterlevel = Convert.ToDouble(dt.Rows[0]["AffectedRange"].ToString());
            lastupdatelvl1 = dt.Rows[0]["LastUpdate"].ToString();
            dt = connectionblselect.selectthreatlevel2details();
            lvl2waterlevel = Convert.ToDouble(dt.Rows[0]["AffectedRange"].ToString());
            lastupdatelvl2 = dt.Rows[0]["LastUpdate"].ToString();
            dt = connectionblselect.selectthreatlevel3details();
            lvl3waterlevel = Convert.ToDouble(dt.Rows[0]["AffectedRange"].ToString());
            lastupdatelvl3 = dt.Rows[0]["LastUpdate"].ToString();
            // string name = dt.rows["AffectedRange"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Visible = true;
        }

        //cleare the sensortempvalue table every day midninght
        private void cleartablessensorvalues()
        {
            String[] substring1 = time.Split(':');
            string h = substring1[0].ToString().Trim();
            string m = substring1[1].ToString().Trim();
            if (h.Equals("00") && m.Equals("00"))
            {
                connectionbldelete.DeleteSensorData();
            }
        }



        //datasetter and getters
        public string callsenso0rvalues()
        {
            return status + "/" + threatlevel + "/";
        }



        //firebase part//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            }catch(Exception e)
            {
                Console.WriteLine("Error in Status :-" + e);
            }

        }

        public async void uploadWaterLevl(Double level)
        {
            String lvl = level.ToString().Trim();
            try
            {
                var waterlel = new WaterLevel
                {
                    level = lvl
                };

                SetResponse setResponse = await firebaseclient.SetTaskAsync("WaterLevl", waterlel);
                WaterLevel results = setResponse.ResultAs<WaterLevel>();
                MessageBox.Show("Water Level Updates");
            }catch(Exception e)
            {
                MessageBox.Show("Error While Updating Water Level");
            }
        }

    }
}
