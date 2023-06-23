using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace GUI_Comander
{
    public partial class frm_main : Form
    {
        MSG dbg;
        Websocket_Client client;
        int FSM_index = 0;
        List<string> list = new List<string>();
        bool command_Send = false;
        int loop_count = 0;

        public frm_main()
        {
            InitializeComponent();
            dbg=new MSG(lst_msg);
            client = new Websocket_Client();

            list.Add("<Palette#Latch_Position@000>,<Palette#Latch_Position@status>");
            list.Add("<Palette#Push_Tray@000>,<Palette#Push_Tray@status>");
            list.Add("<Palette#Dock@000>,<Palette#Dock@status>");
            list.Add("<Handler#Go_Touch_Down@000>,<Handler#Go_Touch_Down@status>");
            list.Add("<Handler#Go_Pin_Down@000>,<Handler#Go_Pin_Down@status>");
            list.Add("<Handler#Go_Home@000>,<Handler#Go_Home@status>");
            list.Add("<Palette#UnDock@000>,<Palette#UnDock@status>");
            list.Add("<Palette#Tray_Out@000>,<Palette#Tray_Out@status>");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbg.push("System Started...");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!client.connected)
            {

                if (client.open())
                {
                    dbg.push("Websocket Client Opened");
                }
                else
                {
                    dbg.push("Error!!!!Unable to Open Client");
                }
            }
            else
            {
                dbg.push("Already connected");
            }

        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            client.close();
            dbg.push("Client Closed");
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            string cmd = "";

            if(rbtn_home.Checked) 
            {
                cmd="<Handler#Go_Home@000>"; 
            }
            if (rbtn_touch_down.Checked) 
            { 
                cmd= "<Handler#Go_Touch_Down@000>";
            }
            if (rbtn_pin_down.Checked) 
            { 
                cmd= "<Handler#Go_Pin_Down@000>";
            }
            if (rbtn_custom.Checked)
            { 
                cmd="<Handler#Go_Pos@"+cbo_custom.SelectedIndex.ToString()+">";
            }
           if(!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("Send Simulator: "+cmd);
        }

        private void btn_push_tray_Click(object sender, EventArgs e)
        {
            string cmd = "<Palette#Push_Tray@000>";
            if (!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("Send Simulator: "+"Palette#Push_Tray");
        }

        private void btn_dock_Click(object sender, EventArgs e)
        {
            string cmd = "<Palette#Dock@000>";
            if (!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("Send Simulator: "+"Palette#Dock");
        }

        private void btn_undock_Click(object sender, EventArgs e)
        {
            string cmd = "<Palette#UnDock@000>";
 
            if (!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("Send Simulator: "+"Palette#UnDock");
        }

        private void btn_force_out_Click(object sender, EventArgs e)
        {
            string cmd = "<Palette#Force_Out@000>";
            if (!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("Send Simulator: "+"Palette#Force_Out");
        }

        private void btn_demo_start_Click(object sender, EventArgs e)
        {
            txt_loop_count.Text = loop_count.ToString();
            FSM_index = 0;
            timer_demo.Enabled = true;
            timer_demo.Interval = 500;
            //string cmd = "<Demo#Start@000>";
            //if (!client.send(cmd))
            //{
            //    client.open();
            //    client.send(cmd);
            //}
            //dbg.push("Send Simulator: "+"Demo#Start");
        }

        private void btn_demo_stop_Click(object sender, EventArgs e)
        {
            timer_demo.Enabled = false;

            //string cmd = "<Demo#Stop@000>";
            //if (!client.send(cmd))
            //{
            //    client.open();
            //    client.send(cmd);
            //}
            //dbg.push("Send Simulator: "+"Demo#Stop");
        }

        private void txt_cmd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string cmd = "<Terminal#" + txt_cmd.Text.ToString() + "@000>";
                if (!client.send(cmd))
                {
                    client.open();
                    client.send(cmd);
                }
                dbg.push("<Terminal#"+txt_cmd.Text.ToString()+">");
            }
        }

        private void cbo_custom_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtn_custom.Checked = true;
        }

        private void btn_Latch_Position_Click(object sender, EventArgs e)
        {
            string cmd = "<Palette#Latch_Position@000>";
            if (!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("<Palette#Latch_Position@000>");
        }

        private void btn_tray_out_Click(object sender, EventArgs e)
        {
            string cmd = "<Palette#Tray_Out@000>";
            if (!client.send(cmd))
            {
                client.open();
                client.send(cmd);
            }
            dbg.push("<Palette#Tray_Out@000>");
        }

        private void timer_demo_Tick(object sender, EventArgs e)
        {
            if (Command_Executed(list[FSM_index]))
            {
                FSM_index++;
            }
            if(FSM_index >= list.Count) 
            {
                FSM_index = 0;
                loop_count++;
                txt_loop_count.Text=loop_count.ToString();
              if (!chk_loop.Checked)  timer_demo.Enabled= false; 
            }
        }

        public bool Command_Executed(string cmd)
        {
            if(!command_Send)
            {
                int i = cmd.IndexOf('>');
                string s=cmd.Substring(0, i+1);
                client.send(s);
                command_Send = true;
                return false;
            }
            ////////////////////////
           int indx= cmd.IndexOf(',');
            string cmd_status= cmd.Substring(indx+1);
            client.send(cmd_status);

            if (client.response != "")
            {
                if(client.response =="OnGoing")
                {
                    return false;
                }
                if (client.response == "Completed")
                {
                    command_Send = false;
                    return true;
                }  
            }
            return false;        
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            lst_msg.Items.Clear();
        }
    }
}
