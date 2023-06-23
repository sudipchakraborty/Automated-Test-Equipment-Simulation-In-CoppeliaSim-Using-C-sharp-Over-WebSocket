local dut=require "object_handler"
-- Example code
-- local ws=require "joint_prismatic"
-- function sysCall_init()
--    ws.Init(8088)
-- end
-- function sysCall_actuation()
-- if(ws.received==true) then
--     print(ws.cmd)
--     ws.send("sdsdd")
--  end
-----------------------------------------
palette = {}
 local mtr
 local target
 local lt_max,lt_min
 local step=0.001
 local pos=0

local FSM="FSM_IDLE"

local virtual_delay=0
local idle_count=0
local palette_motor_speed= 0.005
local Palette_current_pos=0

cnvr_palette_feed=sim.getObjectHandle('./cnvr_palette_feed')
sensor_motor_out_left=sim.getObjectHandle('sensor_motor_out_left')
sensor_motor_out_right=sim.getObjectHandle('sensor_motor_out_right')
sensor_palette_entry_left=sim.getObjectHandle('sensor_palette_entry_left')
sensor_palette_entry_right=sim.getObjectHandle('sensor_palette_entry_right')

palette_left_motor=sim.getObjectHandle('palette_left_motor')
palette_right_motor=sim.getObjectHandle('palette_right_motor')

sensor_motor_dock_L=sim.getObjectHandle('sensor_motor_dock_L')
sensor_motor_dock_R=sim.getObjectHandle('sensor_motor_dock_R')

DUT_Base=sim.getObjectHandle('DUT_Base')

local process_status=""

--___________________________________________________________________________________________________________________________________
function palette.process() 
    if(FSM=="FSM_IDLE") then
        virtual_delay=virtual_delay+1
        if(virtual_delay>50) then
          --  print("Palette Idle State="..idle_count)
            virtual_delay=0
            idle_count=idle_count+1
        end  
    end
    -----------------------------------------
    if(FSM=="FSM_PUSH_PALETTE") then
        sim.writeCustomTableData(cnvr_palette_feed,'__ctrl__',{vel=-0.05}) 
        r,d,dP=sim.checkProximitySensor(sensor_palette_entry_left,sim.handle_all)
        r1,d1,dP1=sim.checkProximitySensor(sensor_palette_entry_right,sim.handle_all)
        if((r==1)and (r1==1)) then
            sim.writeCustomTableData(cnvr_palette_feed,'__ctrl__',{vel=0}) 
            print("Palette Is in Position")
            dut.Update_Current_position()
            FSM="FSM_IDLE"
            process_status="Completed"
        end
    end
    -----------------------------------------
    if(FSM=="FSM_LATCH_POSITION") then
      --  if(process_state==false) then
        sim.setJointPosition(palette_left_motor,Palette_current_pos)
        sim.setJointPosition(palette_right_motor,Palette_current_pos)
        Palette_current_pos=Palette_current_pos+palette_motor_speed
       -- print("Palette_current_pos="..Palette_current_pos)
        ------------
        r,d,dP=sim.checkProximitySensor(sensor_motor_out_left,sim.handle_all)
        r1,d1,dP1=sim.checkProximitySensor(sensor_motor_out_right,sim.handle_all)
      --  print("left="..r)
       -- print("right="..r1)
        if((r==1)and (r1==1)) then
            print("Latch Is in Position..Going to Idle..")
            FSM="FSM_IDLE"
            process_status="Completed"
        end
    end
    -----------------------------------------
    if(FSM=="FSM_DOCK") then

        sim.setJointPosition(palette_left_motor,Palette_current_pos)
        sim.setJointPosition(palette_right_motor,Palette_current_pos)
        dut.position_Inc_X_By(palette_motor_speed)
        Palette_current_pos=Palette_current_pos-palette_motor_speed
  
     --   print("Palette_current_pos="..Palette_current_pos)
        ------------
        r,d,dP=sim.checkProximitySensor(sensor_motor_dock_L,sim.handle_all)
        r1,d1,dP1=sim.checkProximitySensor(sensor_motor_dock_R,sim.handle_all)
       -- print("left="..r)
       -- print("right="..r1)
        if((r==1)and (r1==1)) then
            print("Latch Is in Dock Position..Going to Idle..")
            FSM="FSM_IDLE"
            process_status= "Completed"
        end
    end
    -----------------------------------------
    if(FSM=="FSM_UNDOCK") then
        sim.setJointPosition(palette_left_motor,Palette_current_pos)
        sim.setJointPosition(palette_right_motor,Palette_current_pos)
        dut.position_Dec_X_By(palette_motor_speed)
        Palette_current_pos=Palette_current_pos+palette_motor_speed
        print("Palette_current_pos="..Palette_current_pos)
        ------------
        r,d,dP=sim.checkProximitySensor(sensor_motor_out_left,sim.handle_all)
        r1,d1,dP1=sim.checkProximitySensor(sensor_motor_out_right,sim.handle_all)
      --  print("left="..r)
      --  print("right="..r1)
        if((r==1)and (r1==1)) then
            print("Undock OK..Going to Idle..")
            FSM="FSM_IDLE"
            process_status= "Completed"
        end   
    end
    -----------------------------------------
    if(FSM=="FSM_FORCEOUT") then
        sim.setJointPosition(palette_left_motor,Palette_current_pos)
        sim.setJointPosition(palette_right_motor,Palette_current_pos)
        Palette_current_pos=Palette_current_pos+palette_motor_speed
        print("Palette_current_pos="..Palette_current_pos)
        ------------
        r,d,dP=sim.checkProximitySensor(sensor_motor_out_left,sim.handle_all)
        r1,d1,dP1=sim.checkProximitySensor(sensor_motor_out_right,sim.handle_all)
        print("left="..r)
        print("right="..r1)
        if((r==1)and (r1==1)) then
            print("Latch Is in Position..Going to Idle..")
            FSM="FSM_IDLE"
            process_status= "Completed"
        end     
    end
    -----------------------------------------
    if(FSM=="FSM_TRAYOUT") then
        sim.writeCustomTableData(cnvr_palette_feed,'__ctrl__',{vel=0.05}) 
        p=dut.Get_pos_X()
        print(p)
        if(p<=(-2.232)) then
            sim.writeCustomTableData(cnvr_palette_feed,'__ctrl__',{vel=0.0}) 
            print("DUT is OUT. Going Idle..")
            FSM="FSM_IDLE"
            process_status= "Completed"
        end
    end
    -----------------------------------------




    


   -- print(mtr)
end
--___________________________________________________________________________________________________________________________________
function palette.init() 
    sim.writeCustomTableData(cnvr_palette_feed,'__ctrl__',{vel=0}) 
    dut.init("DUT_Base")
    return "OK"
  --  mtr=motor_name
  --  mtr=sim.getObjectHandle(motor_name)
end
--___________________________________________________________________________________________________________________________________
function palette.update(cmd)  
   FSM=cmd
   process_status='OnGoing'
   return "OK"
end
--___________________________________________________________________________________________________________________________________
function palette.target(value)  
   target=value
   return "OK"
end
--___________________________________________________________________________________________________________________________________
function palette.step(step_val)  
    step=step_val
    return "OK"
 end
 --___________________________________________________________________________________________________________________________________
function palette.pos(pos_val)  
    pos=pos_val
    return "OK"
 end
--___________________________________________________________________________________________________________________________________
function palette.Get_Status()  
    return  process_status
 end
--___________________________________________________________________________________________________________________________________

return palette