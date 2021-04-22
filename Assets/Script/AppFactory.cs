using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AppFactory : MonoBehaviour
{
    public static AppFactory instances;
    public controller c;
    public view v;


    public RendertoViewcommand render;
    public AddGoodscommand add;
    public Oncesessioncommand once;
    public AddTaskcommand task;
    public RenderTaskcommand rtask;
    public Colorcommand colorcommand;

    public bool isopenpackage = false;
    public Gameobjpool mainpool;
    public GameObject quiver, enemy;

    public TipTaskcommand tip;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("xxxx");
            AppFactory.instances.Todo(new Observer("RendertoViewcommand"));
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            AppFactory.instances.Todo(new Observer(Cmd.showTip,"你真牛逼"));
        }

    }

    void Awake()
    {
        instances = this;
    }

    public void AdjustCommand(string msg, IC i)
    {
        this.c.AdjustCommand(msg, i);

    }


    void Start()
    {


        c = new controller();
        v = new view();
        render = new RendertoViewcommand();
        add = new AddGoodscommand();
        once = new Oncesessioncommand();
        task = new AddTaskcommand();
        rtask = new RenderTaskcommand();
        
        //	Packageview packageview = 
        //THIS IS MORE VIEW BE WRITTER

        AdjustView(new Packageview());
        AdjustView(new dialogview());
        AdjustView(new taskview());
        AdjustCommand("once", once);
        AdjustCommand("RendertoViewcommand", render);
        AdjustCommand(Cmd.addItem, add);
        // later will be add delete task
        AdjustCommand("addtask", task);
        AdjustCommand("rtask", rtask);
        //Tip的操作
        tip = new TipTaskcommand();
        AdjustCommand(Cmd.showTip, tip);
        colorcommand = new Colorcommand();
        AdjustCommand(Cmd.showColor, colorcommand);
    }


    void AdjustView(Vmediator mediator)
    {
        if (mediator != null)
        {

            v.AdjustView(mediator);

        }
    }
    public void viewTodo(Observer mediator)
    {
        if (mediator != null)
        {
            v.viewTodo(mediator);
        }

    }
    public void Todo(Observer o)
    {
        c.Todo(o);


    }
    public void showColor1()
    {
        AppFactory.instances.Todo(new Observer(Cmd.showColor, Color.red));
    }




    //public void diaglog()
    //{
    //    List<string> a = new List<string>();
    //    a.Add("player");
    //    a.Add("不好！！");
    //    Todo(new Observer("once", a));
    //}
    //对话框使用案例，对话系统建议废弃
    //List<string> a = new List<string>();
    //a.Add("player");
    //a.Add("我感觉有一股神秘的邪恶力量正在逼近");
    //a.Add("不管怎么样，我都得去看看了");

    //a.Add("啊哈...");
    //Todo(new Observer("addtask", 1));
    //Todo(new Observer("once", a));
    //playercontrolpower.enabled = true;
    //public void sayingonething(string a)
    //{

    //    Todo(new Observer("once", a));


    //}
    public void StartGame()
    {



    }


    //线程池使用案例
    //mainpool.GetObject("eneyNum").GetComponent<MonsterWander>().initialPosition = t.position;
    //mainpool.GetObject("eneyNum").transform.position = t.position;
    //mainpool.CreatePool("eneyNum", enemy, 3, 5, false);
    //mainpool.CreatePool("quiverNum", quiver, 2, 10, false);
    public void GetEnemy(Transform t)
    {


    }


}
