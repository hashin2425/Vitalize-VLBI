
namespace VLBI_Terminal
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GPS_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.latitude_textbox = new System.Windows.Forms.TextBox();
            this.longitude_textbox = new System.Windows.Forms.TextBox();
            this.gps_button = new System.Windows.Forms.Button();
            this.clock_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.offset_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.day_offset_textbox = new System.Windows.Forms.TextBox();
            this.hour_offset_textbox = new System.Windows.Forms.TextBox();
            this.minute_offset_textbox = new System.Windows.Forms.TextBox();
            this.second_offset_textbox = new System.Windows.Forms.TextBox();
            this.follow_time_checkbox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTopmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.target_star_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.star_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dir_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hei_label = new System.Windows.Forms.Label();
            this.timer_1sec = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GPS_group.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.clock_group.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.offset_tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.target_star_group.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPS_group
            // 
            this.GPS_group.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.GPS_group, "GPS_group");
            this.GPS_group.Name = "GPS_group";
            this.GPS_group.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.latitude_textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.longitude_textbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gps_button, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // latitude_textbox
            // 
            resources.ApplyResources(this.latitude_textbox, "latitude_textbox");
            this.latitude_textbox.Name = "latitude_textbox";
            // 
            // longitude_textbox
            // 
            resources.ApplyResources(this.longitude_textbox, "longitude_textbox");
            this.longitude_textbox.Name = "longitude_textbox";
            // 
            // gps_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gps_button, 2);
            resources.ApplyResources(this.gps_button, "gps_button");
            this.gps_button.Name = "gps_button";
            this.gps_button.UseVisualStyleBackColor = true;
            this.gps_button.Click += new System.EventHandler(this.Gps_button_Click);
            // 
            // clock_group
            // 
            resources.ApplyResources(this.clock_group, "clock_group");
            this.clock_group.Controls.Add(this.tableLayoutPanel4);
            this.clock_group.Name = "clock_group";
            this.clock_group.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.offset_tableLayoutPanel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.follow_time_checkbox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker, 0, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // offset_tableLayoutPanel
            // 
            resources.ApplyResources(this.offset_tableLayoutPanel, "offset_tableLayoutPanel");
            this.offset_tableLayoutPanel.Controls.Add(this.label4, 0, 0);
            this.offset_tableLayoutPanel.Controls.Add(this.label5, 1, 0);
            this.offset_tableLayoutPanel.Controls.Add(this.label6, 1, 1);
            this.offset_tableLayoutPanel.Controls.Add(this.label7, 1, 2);
            this.offset_tableLayoutPanel.Controls.Add(this.label8, 1, 3);
            this.offset_tableLayoutPanel.Controls.Add(this.day_offset_textbox, 2, 0);
            this.offset_tableLayoutPanel.Controls.Add(this.hour_offset_textbox, 2, 1);
            this.offset_tableLayoutPanel.Controls.Add(this.minute_offset_textbox, 2, 2);
            this.offset_tableLayoutPanel.Controls.Add(this.second_offset_textbox, 2, 3);
            this.offset_tableLayoutPanel.Name = "offset_tableLayoutPanel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.offset_tableLayoutPanel.SetRowSpan(this.label4, 4);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // day_offset_textbox
            // 
            resources.ApplyResources(this.day_offset_textbox, "day_offset_textbox");
            this.day_offset_textbox.Name = "day_offset_textbox";
            this.day_offset_textbox.ShortcutsEnabled = false;
            this.day_offset_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Allow_nums2textbox_KeyPress);
            // 
            // hour_offset_textbox
            // 
            resources.ApplyResources(this.hour_offset_textbox, "hour_offset_textbox");
            this.hour_offset_textbox.Name = "hour_offset_textbox";
            this.hour_offset_textbox.ShortcutsEnabled = false;
            this.hour_offset_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Allow_nums2textbox_KeyPress);
            // 
            // minute_offset_textbox
            // 
            resources.ApplyResources(this.minute_offset_textbox, "minute_offset_textbox");
            this.minute_offset_textbox.Name = "minute_offset_textbox";
            this.minute_offset_textbox.ShortcutsEnabled = false;
            this.minute_offset_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Allow_nums2textbox_KeyPress);
            // 
            // second_offset_textbox
            // 
            resources.ApplyResources(this.second_offset_textbox, "second_offset_textbox");
            this.second_offset_textbox.Name = "second_offset_textbox";
            this.second_offset_textbox.ShortcutsEnabled = false;
            this.second_offset_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Allow_nums2textbox_KeyPress);
            // 
            // follow_time_checkbox
            // 
            resources.ApplyResources(this.follow_time_checkbox, "follow_time_checkbox");
            this.follow_time_checkbox.Checked = true;
            this.follow_time_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.follow_time_checkbox.Name = "follow_time_checkbox";
            this.follow_time_checkbox.UseVisualStyleBackColor = true;
            this.follow_time_checkbox.CheckedChanged += new System.EventHandler(this.Follow_time_checkbox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.Calc_direction);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileXToolStripMenuItem,
            this.displayDToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileXToolStripMenuItem
            // 
            this.fileXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem});
            this.fileXToolStripMenuItem.Name = "fileXToolStripMenuItem";
            resources.ApplyResources(this.fileXToolStripMenuItem, "fileXToolStripMenuItem");
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            resources.ApplyResources(this.exitXToolStripMenuItem, "exitXToolStripMenuItem");
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // displayDToolStripMenuItem
            // 
            this.displayDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTopmostToolStripMenuItem});
            this.displayDToolStripMenuItem.Name = "displayDToolStripMenuItem";
            resources.ApplyResources(this.displayDToolStripMenuItem, "displayDToolStripMenuItem");
            // 
            // showTopmostToolStripMenuItem
            // 
            this.showTopmostToolStripMenuItem.Name = "showTopmostToolStripMenuItem";
            resources.ApplyResources(this.showTopmostToolStripMenuItem, "showTopmostToolStripMenuItem");
            this.showTopmostToolStripMenuItem.Click += new System.EventHandler(this.ShowTopmostToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // target_star_group
            // 
            this.target_star_group.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.target_star_group, "target_star_group");
            this.target_star_group.Name = "target_star_group";
            this.target_star_group.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.star_combo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dir_label, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.hei_label, 1, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // star_combo
            // 
            resources.ApplyResources(this.star_combo, "star_combo");
            this.star_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.star_combo.FormattingEnabled = true;
            this.star_combo.Name = "star_combo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // dir_label
            // 
            resources.ApplyResources(this.dir_label, "dir_label");
            this.dir_label.Name = "dir_label";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // hei_label
            // 
            resources.ApplyResources(this.hei_label, "hei_label");
            this.hei_label.Name = "hei_label";
            // 
            // timer_1sec
            // 
            this.timer_1sec.Enabled = true;
            this.timer_1sec.Interval = 1000;
            this.timer_1sec.Tick += new System.EventHandler(this.Timer_1sec_Tick);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.target_star_group);
            this.Controls.Add(this.GPS_group);
            this.Controls.Add(this.clock_group);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GPS_group.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.clock_group.ResumeLayout(false);
            this.clock_group.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.offset_tableLayoutPanel.ResumeLayout(false);
            this.offset_tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.target_star_group.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GPS_group;
        private System.Windows.Forms.Button gps_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latitude_textbox;
        private System.Windows.Forms.TextBox longitude_textbox;
        private System.Windows.Forms.GroupBox clock_group;
        private System.Windows.Forms.TableLayoutPanel offset_tableLayoutPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox day_offset_textbox;
        private System.Windows.Forms.TextBox hour_offset_textbox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timer_1sec;
        private System.Windows.Forms.GroupBox target_star_group;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox star_combo;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem showTopmostToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dir_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label hei_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox follow_time_checkbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minute_offset_textbox;
        private System.Windows.Forms.TextBox second_offset_textbox;
    }
}

