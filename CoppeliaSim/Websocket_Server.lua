
-- Example code
-- local ws=require "Websocket_Server"
-- function sysCall_init()
--    ws.Init(8088)
-- end
-- function sysCall_actuation()
-- if(ws.received==true) then
--     print(ws.cmd)
--     ws.send("sdsdd")
--  end
-----------------------------------------
Websocket_Server = {}

local received=false
local srv=''
local conn=''
local cmd=''
--___________________________________________________________________________________________________________________________________
function Websocket_Server.Init(server_port) 
    server=simWS.start(server_port)
    simWS.setMessageHandler(server, 'onMessage')
end
--___________________________________________________________________________________________________________________________________
function onMessage(server,connection,data)
    Websocket_Server.srv=server
    Websocket_Server.conn=connection
    Websocket_Server.cmd=data
    Websocket_Server.received=true
end
--___________________________________________________________________________________________________________________________________
function Websocket_Server.send(response)  
    simWS.send(Websocket_Server.srv,Websocket_Server.conn,response)
    Websocket_Server.received=false
end
--___________________________________________________________________________________________________________________________________
return Websocket_Server