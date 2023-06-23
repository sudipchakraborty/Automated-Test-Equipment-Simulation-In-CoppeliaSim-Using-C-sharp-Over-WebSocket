
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
handler = {}
 local mtr
 local target
 local lt_max,lt_min
 local step=0.002
 local handler_pos=0
 local cmd='44'
 local sensor_DUT=0
 local FSM='FSM_IDLE'

 local pos_0=0.000
 local pos_1=0.014
 local pos_2=0.028
 local pos_3=0.042
 local pos_4=0.057
 local pos_5=0.071
 local pos_6=0.085
 local pos_7=0.100

 local pos_current=0
 local pos_target=0
 local idle_count=0
 local virtual_delay=0
--___________________________________________________________________________________________________________________________________
function handler.init(motor_name) 
  sensor_DUT=sim.getObjectHandle(motor_name)
  --handler.cmd='aa'
end
--___________________________________________________________________________________________________________________________________
function handler.step(step_val)  
    step=step_val
 end
 --___________________________________________________________________________________________________________________________________
function handler.pos(pos_val)  
    pos=pos_val
 end
--___________________________________________________________________________________________________________________________________
function handler.target(target_val) 
    
    if(target_val=='0') then
        target_val= pos_0 
    end
    
    if(target_val=='1') then
        target_val= pos_1 
    end

    if(target_val=='2') then
        target_val= pos_2 
    end

    if(target_val=='3') then
        target_val= pos_3 
    end

    if(target_val=='4') then
        target_val= pos_4 
    end

    if(target_val=='5') then
        target_val= pos_5
    end

    if(target_val=='6') then
        target_val= pos_6 
    end
    
    if(target_val=='7') then
        target_val= pos_7
    end

    pos_target=tonumber(target_val)
    print('set value='..pos_target)
 end
--___________________________________________________________________________________________________________________________________
function handler.cmd_update(command)  
   FSM=command
 end
--___________________________________________________________________________________________________________________________________
function handler.process() 
    -------------------------------
    if(FSM=='FSM_IDLE') then
        virtual_delay=virtual_delay+1
        if(virtual_delay>1000) then
            print("Handler Idle State="..idle_count)
            virtual_delay=0
        end
        idle_count=idle_count+1
    end
    -------------------------------
    if(FSM=="Go_Pos") then  

      --  print('pos_current'..pos_current)
      --  print('pos_target'..pos_target)

            if(pos_current>pos_target)then
                sim.setJointPosition(sensor_DUT,pos_current)
                pos_current =pos_current-step
                diff=pos_current-pos_target
                if(diff<=step) then
                    FSM='FSM_IDLE'
                    return -1
                else
                    return 0
                end    
            end
            -------------------------
            if(pos_current<pos_target) then
                print('pos_current<pos_3')
                sim.setJointPosition(sensor_DUT,pos_current)
                pos_current =pos_current+step
                diff=pos_target-pos_current
                if(diff<=step) then
                    FSM='FSM_IDLE'
                    return -1
                else
                    return 0
                end
            end
        end
    -------------------------------
end
--___________________________________________________________________________________________________________________________________
return handler