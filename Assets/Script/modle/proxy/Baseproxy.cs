using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
public class Baseproxy<T> where T : Basemodel, new()
{
    protected List<T> modellist;
    protected List<Vmediator> IComponentList;
    public Baseproxy()
    {
        modellist = new List<T>();
    }

    public bool TryGetModel(int id, out T model)
    {
        model = modellist.FirstOrDefault(a => a.id == id);
        if (model == null)
        {
            return false;
        }
        else
        {

            return true;
        }

    }

    public void regiestNewComponent(Vmediator t)
    {
        if (IComponentList == null)
        {
            IComponentList = new List<Vmediator>();
        }
        IComponentList.Add(t);
    }

    public void removeNewComponent(Vmediator t)
    {
        if (IComponentList != null && IComponentList.Count > 0)
        {
            IComponentList.Remove(t);
        }

    }

    public void ModelToDoView()
    {
        if (IComponentList != null && IComponentList.Count > 0)
        {
            foreach (Vmediator t in IComponentList)
            {

                t.refresh();
            }
        }

    }

    public List<T> getmodellist()
    {
        return modellist;
    }

    public int getMaxid()
    {
        if (this.modellist.Count == 0)
            return 0;
        return this.modellist.Max(a => a.id);

    }


    public void update(int id, T model)
    {
        T temp = this.GetmodelbyId(id);
        model = temp;
    }

    public void addmodeltolist(T xxx)
    {
        modellist.Add(xxx);
    }

    public T GetmodelbyId(int id)
    {
        T model = modellist.FirstOrDefault(a => a.id == id);
        return model;
    }

}
