namespace GUI_Comander
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_go = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_custom = new System.Windows.Forms.RadioButton();
            this.rbtn_pin_down = new System.Windows.Forms.RadioButton();
            this.rbtn_touch_down = new System.Windows.Forms.RadioButton();
            this.rbtn_home = new System.Windows.Forms.RadioButton();
            this.cbo_custom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tray_out = new System.Windows.Forms.Button();
            this.btn_Latch_Position = new System.Windows.Forms.Button();
            this.btn_dock = new System.Windows.Forms.Button();
            this.btn_force_out = new System.Windows.Forms.Button();
            this.btn_push_tray = new System.Windows.Forms.Button();
            this.btn_undock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_msg = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_demo_stop = new System.Windows.Forms.Button();
            this.btn_demo_start = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.timer_demo = new System.Windows.Forms.Timer(this.components);
            this.lbl_clear = new System.Windows.Forms.Label();
            this.chk_loop = new System.Windows.Forms.CheckBox();
            this.txt_loop_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.ForeColor = System.Drawing.Color.Navy;
            this.btn_go.Location = new System.Drawing.Point(204, 24);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(102, 106);
            this.btn_go.TabIndex = 0;
            this.btn_go.Text = "GO";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_custom);
            this.groupBox1.Controls.Add(this.rbtn_pin_down);
            this.groupBox1.Controls.Add(this.rbtn_touch_down);
            this.groupBox1.Controls.Add(this.rbtn_home);
            this.groupBox1.Controls.Add(this.cbo_custom);
            this.groupBox1.Controls.Add(this.btn_go);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HANDLER";
            // 
            // rbtn_custom
            // 
            this.rbtn_custom.AutoSize = true;
            this.rbtn_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_custom.Location = new System.Drawing.Point(8, 113);
            this.rbtn_custom.Name = "rbtn_custom";
            this.rbtn_custom.Size = new System.Drawing.Size(70, 20);
            this.rbtn_custom.TabIndex = 3;
            this.rbtn_custom.TabStop = true;
            this.rbtn_custom.Text = "Custom";
            this.rbtn_custom.UseVisualStyleBackColor = true;
            // 
            // rbtn_pin_down
            // 
            this.rbtn_pin_down.AutoSize = true;
            this.rbtn_pin_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_pin_down.Location = new System.Drawing.Point(8, 82);
            this.rbtn_pin_down.Name = "rbtn_pin_down";
            this.rbtn_pin_down.Size = new System.Drawing.Size(81, 20);
            this.rbtn_pin_down.TabIndex = 3;
            this.rbtn_pin_down.TabStop = true;
            this.rbtn_pin_down.Text = "Pin Down";
            this.rbtn_pin_down.UseVisualStyleBackColor = true;
            // 
            // rbtn_touch_down
            // 
            this.rbtn_touch_down.AutoSize = true;
            this.rbtn_touch_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_touch_down.Location = new System.Drawing.Point(8, 59);
            this.rbtn_touch_down.Name = "rbtn_touch_down";
            this.rbtn_touch_down.Size = new System.Drawing.Size(100, 20);
            this.rbtn_touch_down.TabIndex = 3;
            this.rbtn_touch_down.TabStop = true;
            this.rbtn_touch_down.Text = "Touch Down";
            this.rbtn_touch_down.UseVisualStyleBackColor = true;
            // 
            // rbtn_home
            // 
            this.rbtn_home.AutoSize = true;
            this.rbtn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_home.Location = new System.Drawing.Point(8, 36);
            this.rbtn_home.Name = "rbtn_home";
            this.rbtn_home.Size = new System.Drawing.Size(62, 20);
            this.rbtn_home.TabIndex = 3;
            this.rbtn_home.TabStop = true;
            this.rbtn_home.Text = "Home";
            this.rbtn_home.UseVisualStyleBackColor = true;
            // 
            // cbo_custom
            // 
            this.cbo_custom.FormattingEnabled = true;
            this.cbo_custom.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbo_custom.Location = new System.Drawing.Point(81, 114);
            this.cbo_custom.Name = "cbo_custom";
            this.cbo_custom.Size = new System.Drawing.Size(58, 21);
            this.cbo_custom.TabIndex = 2;
            this.cbo_custom.SelectedIndexChanged += new System.EventHandler(this.cbo_custom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tray_out);
            this.groupBox2.Controls.Add(this.btn_Latch_Position);
            this.groupBox2.Controls.Add(this.btn_dock);
            this.groupBox2.Controls.Add(this.btn_force_out);
            this.groupBox2.Controls.Add(this.btn_push_tray);
            this.groupBox2.Controls.Add(this.btn_undock);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PALETTE";
            // 
            // btn_tray_out
            // 
            this.btn_tray_out.ForeColor = System.Drawing.Color.Black;
            this.btn_tray_out.Location = new System.Drawing.Point(210, 92);
            this.btn_tray_out.Name = "btn_tray_out";
            this.btn_tray_out.Size = new System.Drawing.Size(87, 40);
            this.btn_tray_out.TabIndex = 2;
            this.btn_tray_out.Text = "TRAY OUT";
            this.btn_tray_out.UseVisualStyleBackColor = true;
            this.btn_tray_out.Click += new System.EventHandler(this.btn_tray_out_Click);
            // 
            // btn_Latch_Position
            // 
            this.btn_Latch_Position.ForeColor = System.Drawing.Color.Black;
            this.btn_Latch_Position.Location = new System.Drawing.Point(9, 77);
            this.btn_Latch_Position.Name = "btn_Latch_Position";
            this.btn_Latch_Position.Size = new System.Drawing.Size(109, 55);
            this.btn_Latch_Position.TabIndex = 1;
            this.btn_Latch_Position.Text = "LATCH POSITION";
            this.btn_Latch_Position.UseVisualStyleBackColor = true;
            this.btn_Latch_Position.Click += new System.EventHandler(this.btn_Latch_Position_Click);
            // 
            // btn_dock
            // 
            this.btn_dock.ForeColor = System.Drawing.Color.Navy;
            this.btn_dock.Location = new System.Drawing.Point(124, 24);
            this.btn_dock.Name = "btn_dock";
            this.btn_dock.Size = new System.Drawing.Size(79, 61);
            this.btn_dock.TabIndex = 0;
            this.btn_dock.Text = "DOCK";
            this.btn_dock.UseVisualStyleBackColor = true;
            this.btn_dock.Click += new System.EventHandler(this.btn_dock_Click);
            // 
            // btn_force_out
            // 
            this.btn_force_out.ForeColor = System.Drawing.Color.Navy;
            this.btn_force_out.Location = new System.Drawing.Point(124, 91);
            this.btn_force_out.Name = "btn_force_out";
            this.btn_force_out.Size = new System.Drawing.Size(79, 41);
            this.btn_force_out.TabIndex = 0;
            this.btn_force_out.Text = "FORCE OUT";
            this.btn_force_out.UseVisualStyleBackColor = true;
            this.btn_force_out.Click += new System.EventHandler(this.btn_force_out_Click);
            // 
            // btn_push_tray
            // 
            this.btn_push_tray.ForeColor = System.Drawing.Color.Navy;
            this.btn_push_tray.Location = new System.Drawing.Point(9, 24);
            this.btn_push_tray.Name = "btn_push_tray";
            this.btn_push_tray.Size = new System.Drawing.Size(109, 47);
            this.btn_push_tray.TabIndex = 0;
            this.btn_push_tray.Text = "PUSH TRAY";
            this.btn_push_tray.UseVisualStyleBackColor = true;
            this.btn_push_tray.Click += new System.EventHandler(this.btn_push_tray_Click);
            // 
            // btn_undock
            // 
            this.btn_undock.ForeColor = System.Drawing.Color.Navy;
            this.btn_undock.Location = new System.Drawing.Point(209, 24);
            this.btn_undock.Name = "btn_undock";
            this.btn_undock.Size = new System.Drawing.Size(88, 61);
            this.btn_undock.TabIndex = 0;
            this.btn_undock.Text = "UNDOCK";
            this.btn_undock.UseVisualStyleBackColor = true;
            this.btn_undock.Click += new System.EventHandler(this.btn_undock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(231, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Automated Test Equipment Simulation ";
            // 
            // lst_msg
            // 
            this.lst_msg.FormattingEnabled = true;
            this.lst_msg.Location = new System.Drawing.Point(6, 19);
            this.lst_msg.Name = "lst_msg";
            this.lst_msg.Size = new System.Drawing.Size(307, 355);
            this.lst_msg.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_msg);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(340, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 383);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Message Display";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_loop_count);
            this.groupBox4.Controls.Add(this.chk_loop);
            this.groupBox4.Controls.Add(this.btn_demo_stop);
            this.groupBox4.Controls.Add(this.btn_demo_start);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 71);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEMO";
            // 
            // btn_demo_stop
            // 
            this.btn_demo_stop.ForeColor = System.Drawing.Color.Navy;
            this.btn_demo_stop.Location = new System.Drawing.Point(160, 23);
            this.btn_demo_stop.Name = "btn_demo_stop";
            this.btn_demo_stop.Size = new System.Drawing.Size(68, 36);
            this.btn_demo_stop.TabIndex = 1;
            this.btn_demo_stop.Text = "STOP";
            this.btn_demo_stop.UseVisualStyleBackColor = true;
            this.btn_demo_stop.Click += new System.EventHandler(this.btn_demo_stop_Click);
            // 
            // btn_demo_start
            // 
            this.btn_demo_start.ForeColor = System.Drawing.Color.Navy;
            this.btn_demo_start.Location = new System.Drawing.Point(82, 23);
            this.btn_demo_start.Name = "btn_demo_start";
            this.btn_demo_start.Size = new System.Drawing.Size(72, 36);
            this.btn_demo_start.TabIndex = 1;
            this.btn_demo_start.Text = "START";
            this.btn_demo_start.UseVisualStyleBackColor = true;
            this.btn_demo_start.Click += new System.EventHandler(this.btn_demo_start_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txt_cmd);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(11, 452);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(648, 58);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Command Terminal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ">>";
            // 
            // txt_cmd
            // 
            this.txt_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmd.Location = new System.Drawing.Point(59, 19);
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(583, 26);
            this.txt_cmd.TabIndex = 0;
            this.txt_cmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cmd_KeyDown);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(11, 21);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(80, 28);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(97, 21);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(91, 28);
            this.btn_disconnect.TabIndex = 7;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // timer_demo
            // 
            this.timer_demo.Tick += new System.EventHandler(this.timer_demo_Tick);
            // 
            // lbl_clear
            // 
            this.lbl_clear.AutoSize = true;
            this.lbl_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_clear.Location = new System.Drawing.Point(629, 44);
            this.lbl_clear.Name = "lbl_clear";
            this.lbl_clear.Size = new System.Drawing.Size(30, 13);
            this.lbl_clear.TabIndex = 8;
            this.lbl_clear.Text = "clear";
            this.lbl_clear.Click += new System.EventHandler(this.lbl_clear_Click);
            // 
            // chk_loop
            // 
            this.chk_loop.AutoSize = true;
            this.chk_loop.Checked = true;
            this.chk_loop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_loop.Location = new System.Drawing.Point(24, 34);
            this.chk_loop.Name = "chk_loop";
            this.chk_loop.Size = new System.Drawing.Size(55, 17);
            this.chk_loop.TabIndex = 2;
            this.chk_loop.Text = "LOOP";
            this.chk_loop.UseVisualStyleBackColor = true;
            // 
            // txt_loop_count
            // 
            this.txt_loop_count.Location = new System.Drawing.Point(235, 32);
            this.txt_loop_count.Name = "txt_loop_count";
            this.txt_loop_count.Size = new System.Drawing.Size(72, 20);
            this.txt_loop_count.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loop Count";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(674, 522);
            this.Controls.Add(this.lbl_clear);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "Automated Test Equipment Simulation ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_custom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_dock;
        private System.Windows.Forms.Button btn_force_out;
        private System.Windows.Forms.Button btn_push_tray;
        private System.Windows.Forms.Button btn_undock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_msg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_demo_stop;
        private System.Windows.Forms.Button btn_demo_start;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.RadioButton rbtn_home;
        private System.Windows.Forms.RadioButton rbtn_custom;
        private System.Windows.Forms.RadioButton rbtn_pin_down;
        private System.Windows.Forms.RadioButton rbtn_touch_down;
        private System.Windows.Forms.Button btn_Latch_Position;
        private System.Windows.Forms.Button btn_tray_out;
        private System.Windows.Forms.Timer timer_demo;
        private System.Windows.Forms.Label lbl_clear;
        private System.Windows.Forms.CheckBox chk_loop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_loop_count;
    }
}

