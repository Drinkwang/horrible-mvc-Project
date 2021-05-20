using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommand : IC
{
    PlayerProxy playerProxy= PlayerProxy.instances();

    public void Todo(Observer o)
    {
        List<PlayerRoleInfo> list = playerProxy.getmodellist();
        PlayerRoleInfo model = null;
        if (o.msg == Cmd.ImproveAttack)
        {
            playerProxy.ImproveAttack((int)o.body,(int)o.data,out model);
        }
    }
    
   
}
