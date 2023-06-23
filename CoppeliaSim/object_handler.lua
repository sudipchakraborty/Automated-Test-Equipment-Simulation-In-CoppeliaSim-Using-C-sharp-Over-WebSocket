object_handler = {}

local obj_id=0
local pos={0,-.6,1}
local tbl={}
local t={}
local step= 0.01        --0.001
--___________________________________________________________________________________________________________________________________
function object_handler.init(object_id) 
    obj_id=sim.getObjectHandle(object_id)
    tbl[1]=obj_id
    p= sim.getObjectPosition(obj_id,-1)
    pos[1]=p[1]
    pos[2]=p[2]
    pos[3]=p[3]
end
--___________________________________________________________________________________________________________________________________
function object_handler.add()  
    t=sim.copyPasteObjects(tbl,0)  
    sim.setObjectPosition(t[1],-1,pos)
    --this.Set_position()
   -- sim.setObjectPosition(t[1],-1,pos)

end
--___________________________________________________________________________________________________________________________________
function object_handler.Update_Current_position()  
    p= sim.getObjectPosition(obj_id,-1)
    pos[1]=p[1]
    pos[2]=p[2]
    pos[3]=p[3]
    sim.setObjectPosition(obj_id,-1,pos)
end
--___________________________________________________________________________________________________________________________________
function object_handler.Update_position(position)  
    pos[1]=position[1]
    pos[2]=position[2]
    pos[3]=position[3]
    sim.setObjectPosition(obj_id,-1,pos)
end
--___________________________________________________________________________________________________________________________________
function object_handler.Set_position()  
    sim.setObjectPosition(t[1],-1,pos)
end
--___________________________________________________________________________________________________________________________________
function object_handler.position_Inc_X() 
    sim.setObjectPosition(obj_id,-1,pos) 
  --  sim.setObjectPosition(t[1],-1,pos)
    pos[1]=pos[1]+step
    
end
--___________________________________________________________________________________________________________________________________
function object_handler.position_Dec_X() 
    sim.setObjectPosition(obj_id,-1,pos) 
  --  sim.setObjectPosition(t[1],-1,pos)
    pos[1]=pos[1]-step
    
end
--___________________________________________________________________________________________________________________________________
function object_handler.position_Inc_X_By(val)  
    sim.setObjectPosition(obj_id,-1,pos)
    pos[1]=pos[1]+val
end
--___________________________________________________________________________________________________________________________________
function object_handler.position_Dec_X_By(val)  
    sim.setObjectPosition(obj_id,-1,pos)
    pos[1]=pos[1]-val
end
--___________________________________________________________________________________________________________________________________
function object_handler.Get_pos_X()  
    p= sim.getObjectPosition(obj_id,-1)
    pos[1]=p[1]
    pos[2]=p[2]
    pos[3]=p[3]
    return pos[1]
end
--___________________________________________________________________________________________________________________________________





function object_handler.remove()  
        --   sim.removeObject(tbl)
end
--___________________________________________________________________________________________________________________________________
-- p=sim.getObjectPosition(tble[1],-1)
       
       









return object_handler