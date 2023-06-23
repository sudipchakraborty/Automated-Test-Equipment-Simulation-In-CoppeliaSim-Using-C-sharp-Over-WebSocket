
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
motor_palette_right = {}
 local mtr
 local target
 local lt_max,lt_min
 local step=0.001
 local pos=0
--___________________________________________________________________________________________________________________________________
function motor_palette_right.init(motor_name) 
    mtr=motor_name
    mtr=sim.getObjectHandle(motor_name)
end
--___________________________________________________________________________________________________________________________________
function motor_palette_right.update(response)  
   
end
--___________________________________________________________________________________________________________________________________
function motor_palette_right.target(value)  
   target=value
end
--___________________________________________________________________________________________________________________________________
function motor_palette_right.step(step_val)  
    step=step_val
 end
 --___________________________________________________________________________________________________________________________________
function motor_palette_right.pos(pos_val)  
    pos=pos_val
 end
--___________________________________________________________________________________________________________________________________
function motor_palette_right.process()  
    sim.setJointPosition(mtr,pos)
    pos=pos+step
    print(mtr)
end
--___________________________________________________________________________________________________________________________________
return motor_palette_right