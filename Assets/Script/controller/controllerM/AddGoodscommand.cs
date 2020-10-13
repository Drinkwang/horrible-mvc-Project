using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGoodscommand : IC
{
    PackProxy packproxy = PackProxy.instances();
    Goodproxy goodproxy = Goodproxy.instances();


    public void Todo(Observer io)
    {
        int id = 1;
        Packagemodel model = null;
        if (!int.TryParse(io.body.ToString(), out id))
        {
            return;
        }
        if (packproxy.TryGeGoodtModel(id, out model))
        {
            ++model.count;
            packproxy.update(id, model);
        }
        else if (packproxy.isfull())
        {
            return;
        }
        else
        {
            model = packproxy.getback();
            model.goodid = id;
            model.count = 1;

        }
        AppFactory.instances.Todo(new Observer("RendertoViewcommand", "main"));


    }
}
