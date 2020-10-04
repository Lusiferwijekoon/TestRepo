using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectPrivei2020
{
    public partial class AddLocations : Form
    {
        static List<PointLatLng> point;
        static BL.SelectBL connectionblselect = new BL.SelectBL();
        double lvl1waterlevel, lvl2waterlevel, lvl3waterlevel;
        string lastupdatelvl1, lastupdatelvl2, lastupdatelvl3;


        private static double lat, lon;
        private static string sesorlocationaddress;

        public AddLocations()
        {
            InitializeComponent();
        }


        private void AddLocations_Load(object sender, EventArgs e)
        {
            //setup the API key
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAVR9eQglFrAKCpuSWlnCV9Ao9QXEwJJCA";


            //configure the cache and create the cache folder
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            mMap.CacheLocation = @"MapCache";
            mMap.DragButton = MouseButtons.Left;
            mMap.ShowCenter = false;


            //set up the defaut map
            mMap.MapProvider = GMapProviders.GoogleMap;
            mMap.SetPositionByKeywords("Colombo, Sri Lanka");
            mMap.MinZoom = 1;
            mMap.MaxZoom = 18;
            mMap.Zoom = 15;
        }

        public void sensorLocations()
        {
            //map module opening
            point = new List<PointLatLng>();
            object[,] sensorLocations = connectionblselect.getLatLngOfSensors();
            int rows = sensorLocations.GetLength(0);
            int columns = sensorLocations.GetLength(1);
            for (int k = 0; k < rows; k++)
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
        }


        private void mMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var point = mMap.FromLocalToLatLng(e.X, e.Y);
                lat = point.Lat;
                lon = point.Lng;
                txtLatitude.Text = lat.ToString().Trim();
                txtLongitude.Text = lon.ToString().Trim();
                // MessageBox.Show(e.X + " " + e.Y);
                //load location
                LoadMap(point);
                //Adding marker
                AddMarker(point);
                //Get Addresses
                var addresses = GetAddresses(point);
                sesorlocationaddress = addresses[0].Trim();
                //display address
                if (addresses != null)
                {
                    richTextBox2.Text = "Address: \n----------------------------------\n " + addresses[0];
                }
                else
                {
                    richTextBox2.Text = "Unable to Load ADdress";
                }
            }
        }

        private void LoadMap(PointLatLng point)
        {
            mMap.Position = point;
        }

        private void AddMarker(PointLatLng pointtoadd, GMarkerGoogleType markertype = GMarkerGoogleType.blue_dot)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointtoadd, markertype)
            {
                ToolTipText = $"Latitude : {Math.Round(mMap.Position.Lat, 3)},\nLongitude: {Math.Round(mMap.Position.Lng, 3)}"
            };
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
            mMap.Overlays.Add(markers);
        }


        private List<String> GetAddresses(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                List<String> addresses = new List<string>();
                foreach (var placemark in placemarks)
                {
                    //addresses.Add(placemark.Address + "" + placemark.DistrictName);
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;
        }

        private void btnClearMap_Click(object sender, EventArgs e)
        {
            if (mMap.Overlays.Count > 0)
            {
                mMap.Overlays.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("NO OVERLAYES FOUND");
            }
            mMap.Refresh();

        }

        private void radioSensor_CheckedChanged(object sender, EventArgs e)
        {
            sensorLocations();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                float lat = float.Parse(txtLatitude.Text.Trim());
                BL.InsertBL insertBL = new BL.InsertBL();
                insertBL.AddSensorMetDat(float.Parse(txtLatitude.Text.ToString().Trim()), float.Parse(txtLongitude.Text.ToString().Trim()), "Active", sesorlocationaddress);
                MessageBox.Show("New Location Is Added");
            }catch (Exception eq)
            {
                Console.WriteLine("Error In converting values - " + eq);
                MessageBox.Show("Location Adding Failed");
            }

        }


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
    }

    
}
