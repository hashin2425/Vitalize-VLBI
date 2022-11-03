using System;
using System.Device.Location;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VLBI_Terminal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            star_infos.Add(new FixedStar_info
            {
                name_en = "Sagittarius",
                name_jp = "射手座",
                longitude = 290.882875f,
                latitude = -40.0f,
            });

            InitializeComponent();
        }

        private struct FixedStar_info
        {
            public string name_en;
            public string name_jp;
            public double longitude;
            public double latitude;
        }
        private readonly List<FixedStar_info> star_infos = new List<FixedStar_info>();

        private void Gps_button_Click(object sender, EventArgs e)
        {
            for (var retry_count = 0; retry_count < 3; retry_count++)
            {
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
                watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
                GeoCoordinate coord = watcher.Position.Location;

                if (coord.IsUnknown != true)
                {
                    latitude_textbox.Text = coord.Latitude.ToString();
                    longitude_textbox.Text = coord.Longitude.ToString();
                    return;
                }
            }
            MessageBox.Show("Unknown latitude and longitude.\nPlease retry or turn on GPS on device.", "GPS Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";

            //
            foreach (var item in star_infos) star_combo.Items.Add(item.name_jp);
            star_combo.SelectedIndex = 0;

            //
            showTopmostToolStripMenuItem.Checked = true;
            TopMost = true;

            //
            follow_time_checkbox.Checked = true;
            dateTimePicker.Enabled = false;
            offset_tableLayoutPanel.Enabled = true;
        }

        private void Timer_1sec_Tick(object sender, EventArgs e)
        {
            if (follow_time_checkbox.Checked)
            {
                DateTime time = DateTime.Now;
                try
                {
                    time = time.AddDays(Convert.ToInt16(day_offset_textbox.Text));
                    time = time.AddHours(Convert.ToInt16(hour_offset_textbox.Text));
                    time = time.AddMinutes(Convert.ToInt16(minute_offset_textbox.Text));
                    time = time.AddSeconds(Convert.ToInt16(second_offset_textbox.Text));
                }
                catch { }
                dateTimePicker.Value = time;
            }
        }
        public double ToRadian(double angle) => (double)(angle * Math.PI / 180);

        public double ToAngle(double radian) => (double)(radian * 180 / Math.PI);

        public void Calc_direction(object sender, EventArgs e)
        {
            try
            {
                double TARGET_LAT_DEG = star_infos[star_combo.SelectedIndex].latitude;
                double TARGET_LON_DEG = star_infos[star_combo.SelectedIndex].longitude;
                double OBSERVER_IS_WESTERN_LONGITUDE = -1.0f; // 観測地点は西経かどうか：西経は1、東経は-1：アジア圏は全て(-1)

                double _year = dateTimePicker.Value.ToUniversalTime().Year;
                double _month = dateTimePicker.Value.ToUniversalTime().Month;
                double _day = dateTimePicker.Value.ToUniversalTime().Day;
                double _hour = dateTimePicker.Value.ToUniversalTime().Hour;
                double _minute = dateTimePicker.Value.ToUniversalTime().Minute;
                double _second = dateTimePicker.Value.ToUniversalTime().Second;
                double gps_longitude_deg = Convert.ToDouble(longitude_textbox.Text);
                double gps_latitude_deg = Convert.ToDouble(latitude_textbox.Text);

                // Calculate modified Julian date
                if (_month == 1 || _month == 2)
                {
                    _year--;
                    _month += 12;
                }
                double Modified_Julian_Dates = 0.0;
                Modified_Julian_Dates += (double)((int)(365.25 * _year));
                Modified_Julian_Dates += (double)((int)(_year / 400.0));
                Modified_Julian_Dates -= (double)((int)(_year / 100.0));
                Modified_Julian_Dates += (double)((int)(30.59 * (_month - 2.0)));
                Modified_Julian_Dates += (double)(_day);
                Modified_Julian_Dates += (double)((double)_hour / 24.0);
                Modified_Julian_Dates += (double)((double)_minute / 1440.0);
                Modified_Julian_Dates += (double)((double)_second / 86400.0);
                Modified_Julian_Dates -= (double)(678912.00);

                double temp_lst = 0.67239 + (1.00273781 * (Modified_Julian_Dates - 40000.0));
                double GreenwichSiderealTime = ToRadian((360.0 * (temp_lst - (double)((int)temp_lst))));

                while (GreenwichSiderealTime > (Math.PI * 2.0))
                {
                    GreenwichSiderealTime -= (Math.PI * 2.0);
                }
                double LocalSiderealTime = ((GreenwichSiderealTime) - (OBSERVER_IS_WESTERN_LONGITUDE * ToRadian(gps_longitude_deg)));
                while (LocalSiderealTime > (Math.PI * 2.0))
                {
                    LocalSiderealTime -= (Math.PI * 2.0);
                }
                double hour_angle_rad = (double)(LocalSiderealTime - ToRadian(TARGET_LON_DEG));
                double temp_a_rad = Math.Acos(Math.Sin(ToRadian(TARGET_LAT_DEG)) * Math.Sin(ToRadian(gps_latitude_deg)) + Math.Cos(ToRadian(TARGET_LAT_DEG)) * Math.Cos(ToRadian(gps_latitude_deg)) * Math.Cos(hour_angle_rad));
                double temp_alt_rad = (Math.PI / 2.0f) - temp_a_rad;
                double temp_sinA = Math.Cos(ToRadian(TARGET_LAT_DEG)) * Math.Sin(hour_angle_rad) / Math.Sin(temp_a_rad);
                double temp_cosA = (-1.0f * Math.Sin(ToRadian(TARGET_LAT_DEG)) * Math.Cos(ToRadian(gps_latitude_deg)) + Math.Cos(ToRadian(TARGET_LAT_DEG)) * Math.Sin(ToRadian(gps_latitude_deg)) * Math.Cos(hour_angle_rad)) / Math.Sin(temp_a_rad);
                double temp_azm_rad = Math.Atan2(temp_sinA, temp_cosA) + Math.PI;
                double res_azm_deg = ToAngle(temp_azm_rad);
                double res_alt_deg = ToAngle(temp_alt_rad);

                dir_label.Text = String.Format("{0:F4}", res_alt_deg);
                hei_label.Text = String.Format("{0:F4}", res_azm_deg);
            }
            catch { return; }
        }

        private void ShowTopmostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showTopmostToolStripMenuItem.Checked = !showTopmostToolStripMenuItem.Checked;
            TopMost = showTopmostToolStripMenuItem.Checked;
        }

        private void Allow_nums2textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || '-' == e.KeyChar)
            {
                return;
            }
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Follow_time_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            //
            dateTimePicker.Enabled = !follow_time_checkbox.Checked;
            offset_tableLayoutPanel.Enabled = follow_time_checkbox.Checked;
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
