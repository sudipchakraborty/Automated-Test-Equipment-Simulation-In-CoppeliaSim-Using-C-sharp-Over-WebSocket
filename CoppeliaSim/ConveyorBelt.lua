 
-- Example
--local belt= require "ConveyorBelt"
--belt.Init(sim.getObjectHandle("conveyor"))
-----------------------------------------
ConveyorBelt = {}

local belt=0
local speed=0
local direction=1
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.Init(belt_handler) 
  belt=belt_handler
end
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.set_speed(sp) 
  speed=sp 
  sim.writeCustomTableData(belt,'__ctrl__',{vel=speed*direction})
  
end
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.stop()  
  sim.writeCustomTableData(belt,'__ctrl__',{vel=0})
end 
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.start() 
    sim.writeCustomTableData(belt,'__ctrl__',{vel=speed*direction})
end 
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.forward() 
  direction=1
  sim.writeCustomTableData(belt,'__ctrl__',{vel=speed*direction})
end 
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.reverse()
  direction=-1 
  sim.writeCustomTableData(belt,'__ctrl__',{vel=speed*direction})
end 
--___________________________________________________________________________________________________________________________________
function ConveyorBelt.Auto_Direction(running_val,min, mid,max)
  if(running_val<mid) then 
    ConveyorBelt.reverse()
  else
    ConveyorBelt.forward()
  end
  sim.writeCustomTableData(belt,'__ctrl__',{vel=speed*direction})
end 
--___________________________________________________________________________________________________________________________________

return ConveyorBelt