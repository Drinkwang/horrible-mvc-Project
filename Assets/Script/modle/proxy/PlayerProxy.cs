using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProxy : Baseproxy<PlayerRoleInfo>
{

    private static PlayerProxy instance;
    public static PlayerProxy instances()
    {
        if (instance == null)
        {
                    instance = new PlayerProxy();
        }
        instance.ModelToDoView();
        return instance;
    }



    public PlayerProxy():base()
    {
        //PlayerRoleInfo player1 = ArchiveManager.Instance.GetSampleInIndex<PlayerRoleInfo>(0);
        //PlayerRoleInfo player2 = ArchiveManager.Instance.GetSampleInIndex<PlayerRoleInfo>(1);
        //PlayerRoleInfo player3 = ArchiveManager.Instance.GetSampleInIndex<PlayerRoleInfo>(2);
        //this.addmodeltolist(player1);
        //this.addmodeltolist(player2);
        //this.addmodeltolist(player3);
        List<PlayerRoleInfo> playerRoleInfos = ArchiveManager.Instance.GetSamplelist<PlayerRoleInfo>();
        modellist = playerRoleInfos;
        Debug.Log(modellist[0].RoleName);
    }
    public void ImproveAttack(int id,int value,out PlayerRoleInfo model)
    {

        model = modellist[id];
        model.Attack += value;
        Debug.Log(model.Attack);
    }

}
