
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
            this.GPS_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gps_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.latitude_textbox = new System.Windows.Forms.TextBox();
            this.longitude_textbox = new System.Windows.Forms.TextBox();
            this.clock_group = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.target_star_group.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPS_group
            // 
            this.GPS_group.Controls.Add(this.tableLayoutPanel1);
            this.GPS_group.Location = new System.Drawing.Point(12, 27);
            this.GPS_group.Name = "GPS_group";
            this.GPS_group.Padding = new System.Windows.Forms.Padding(6);
            this.GPS_group.Size = new System.Drawing.Size(198, 103);
            this.GPS_group.TabIndex = 1;
            this.GPS_group.TabStop = false;
            this.GPS_group.Text = "Location";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gps_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.latitude_textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.longitude_textbox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 79);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gps_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gps_button, 2);
            this.gps_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gps_button.Location = new System.Drawing.Point(3, 3);
            this.gps_button.Name = "gps_button";
            this.gps_button.Size = new System.Drawing.Size(180, 20);
            this.gps_button.TabIndex = 0;
            this.gps_button.Text = "Update GPS";
            this.gps_button.UseVisualStyleBackColor = true;
            this.gps_button.Click += new System.EventHandler(this.Gps_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latitude_textbox
            // 
            this.latitude_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latitude_textbox.Location = new System.Drawing.Point(63, 29);
            this.latitude_textbox.Name = "latitude_textbox";
            this.latitude_textbox.Size = new System.Drawing.Size(120, 19);
            this.latitude_textbox.TabIndex = 2;
            this.latitude_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // longitude_textbox
            // 
            this.longitude_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longitude_textbox.Location = new System.Drawing.Point(63, 55);
            this.longitude_textbox.Name = "longitude_textbox";
            this.longitude_textbox.Size = new System.Drawing.Size(120, 19);
            this.longitude_textbox.TabIndex = 3;
            this.longitude_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clock_group
            // 
            this.clock_group.Controls.Add(this.tableLayoutPanel2);
            this.clock_group.Location = new System.Drawing.Point(12, 136);
            this.clock_group.Name = "clock_group";
            this.clock_group.Padding = new System.Windows.Forms.Padding(6);
            this.clock_group.Size = new System.Drawing.Size(198, 149);
            this.clock_group.TabIndex = 2;
            this.clock_group.TabStop = false;
            this.clock_group.Text = "Clock";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.19048F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.97619F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.23809F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.tableLayoutPanel2.SetRowSpan(this.label4, 4);
            this.label4.Size = new System.Drawing.Size(43, 100);
            this.label4.TabIndex = 1;
            this.label4.Text = "Offset";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(52, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "day";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(52, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "hour";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(52, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "min";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(52, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "sec";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(104, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(104, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 19);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(104, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 19);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(104, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 19);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dateTimePicker1, 3);
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 19);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileXToolStripMenuItem,
            this.displayDToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(433, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileXToolStripMenuItem
            // 
            this.fileXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitXToolStripMenuItem});
            this.fileXToolStripMenuItem.Name = "fileXToolStripMenuItem";
            this.fileXToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileXToolStripMenuItem.Text = "File (&X)";
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitXToolStripMenuItem.Text = "Exit";
            // 
            // displayDToolStripMenuItem
            // 
            this.displayDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTopmostToolStripMenuItem});
            this.displayDToolStripMenuItem.Name = "displayDToolStripMenuItem";
            this.displayDToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.displayDToolStripMenuItem.Text = "Display (&D)";
            // 
            // showTopmostToolStripMenuItem
            // 
            this.showTopmostToolStripMenuItem.Name = "showTopmostToolStripMenuItem";
            this.showTopmostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTopmostToolStripMenuItem.Text = "Keep on top";
            this.showTopmostToolStripMenuItem.Click += new System.EventHandler(this.showTopmostToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // target_star_group
            // 
            this.target_star_group.Controls.Add(this.tableLayoutPanel3);
            this.target_star_group.Location = new System.Drawing.Point(12, 291);
            this.target_star_group.Name = "target_star_group";
            this.target_star_group.Size = new System.Drawing.Size(198, 102);
            this.target_star_group.TabIndex = 3;
            this.target_star_group.TabStop = false;
            this.target_star_group.Text = "Target Star";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85417F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.14583F));
            this.tableLayoutPanel3.Controls.Add(this.star_combo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dir_label, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.hei_label, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 84);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // star_combo
            // 
            this.star_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.star_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.star_combo.FormattingEnabled = true;
            this.star_combo.Location = new System.Drawing.Point(68, 3);
            this.star_combo.Name = "star_combo";
            this.star_combo.Size = new System.Drawing.Size(121, 20);
            this.star_combo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Target";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Direction";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dir_label
            // 
            this.dir_label.AutoSize = true;
            this.dir_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dir_label.Location = new System.Drawing.Point(68, 28);
            this.dir_label.Name = "dir_label";
            this.dir_label.Size = new System.Drawing.Size(121, 28);
            this.dir_label.TabIndex = 3;
            this.dir_label.Text = "NaN";
            this.dir_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 28);
            this.label11.TabIndex = 4;
            this.label11.Text = "Height";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hei_label
            // 
            this.hei_label.AutoSize = true;
            this.hei_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hei_label.Location = new System.Drawing.Point(68, 56);
            this.hei_label.Name = "hei_label";
            this.hei_label.Size = new System.Drawing.Size(121, 28);
            this.hei_label.TabIndex = 5;
            this.hei_label.Text = "NaN";
            this.hei_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_1sec
            // 
            this.timer_1sec.Enabled = true;
            this.timer_1sec.Interval = 1000;
            this.timer_1sec.Tick += new System.EventHandler(this.Timer_1sec_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(216, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.target_star_group);
            this.Controls.Add(this.GPS_group);
            this.Controls.Add(this.clock_group);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "VLBI Terminal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GPS_group.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.clock_group.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
    }
}

