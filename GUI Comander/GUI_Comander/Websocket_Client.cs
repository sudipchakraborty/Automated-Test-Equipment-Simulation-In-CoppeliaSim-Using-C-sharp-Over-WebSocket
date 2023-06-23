using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSocketSharp;

// install WebSocketSharp-NonPreRelease by sta, swiftyspiffy (cole)

namespace Tools
{
    public class Websocket_Client
    {
        WebSocket ws;
        public string response = "";
        public bool connected = false;

    public Websocket_Client()
    {

    }

    public bool open(string url="ws://localhost:8088")
    {
        ws = new WebSocket(url);
        ws.OnMessage +=ws_OnMessage;
        ws.Connect();  
        connected = true;
        return true;   
    }

    private void ws_OnMessage(object sender, MessageEventArgs e)
    {
        response = e.Data;
    }

    public void close()
    {
        if(ws!= null)
        {
            ws.Close();
            connected = false;
        }
    }

    public bool send(string message)
    {
        if (!connected) open();

        try
        {
            if(ws != null)
            {
                ws.Send(message);
                return true;
            } 
        }   
        catch(Exception ex)
        {
                connected = false;
            }
            return false;
        }

















    }
}
