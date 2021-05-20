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
    public InputFieldcommand input;
    public BoolCommend boolCommend;
    public StringCommand stringCommand;
    public LightImageCommand lightImageCommand;
    public Studentcommand studentCommand;
    public PlayerCommand playerCommand;
    // Update is called once per frame
    void Update()
    {
        //{
        if (Input.GetKeyDown(KeyCode.E))
        {
            AppFactory.instances.Todo(new Observer("RendertoViewcommand"));
            AppFactory.instances.Todo(new Observer(Cmd.addItem, 1));
        }
        //    if (Input.GetKeyDown(KeyCode.B))
        //    {
        //        AppFactory.instances.Todo(new Observer(Cmd.showTip,"你真牛逼"));
        //    }
        if (Input.GetKeyDown(KeyCode.I))
        {
            instances.Todo(new Observer(Cmd.ImproveAttack,0, 1));
        }
      

    }

    void Awake()
    {
        instances = this;
        init(); 
      //  AppFactory.instances.Todo(new Observer("FindScoreMax"));
    }

    public void AdjustCommand(string msg, IC i)
    {
        this.c.AdjustCommand(msg, i);

    }


    void init()
    {


        c = new controller();
        v = new view();
        render = new RendertoViewcommand();
        add = new AddGoodscommand();
        once = new Oncesessioncommand();
        task = new AddTaskcommand();
        rtask = new RenderTaskcommand();
        input = new InputFieldcommand();
        boolCommend = new BoolCommend();
        stringCommand = new StringCommand();
        lightImageCommand = new LightImageCommand();
        studentCommand = new Studentcommand();
        playerCommand = new PlayerCommand();
        //	Packageview packageview = 
        //THIS IS MORE VIEW BE WRITTER

        AdjustView(new Packageview());
        AdjustView(new dialogview());
        AdjustView(new taskview());
        AdjustView(new Studentview());
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
        AdjustCommand(Cmd.ShowImageAndText, input);
        AdjustCommand(Cmd.changeColor, input);
        AdjustCommand(Cmd.ChangeBool, boolCommend);
        AdjustCommand(Cmd.ChangeString, stringCommand);
        AdjustCommand(Cmd.ChangeColorInImage, lightImageCommand);
        AdjustCommand(Cmd.DeleteMinScore, studentCommand);
        AdjustCommand(Cmd.ShowStudentInformtion, studentCommand);
        AdjustCommand(Cmd.ShowMajorColor, studentCommand);
        AdjustCommand(Cmd.GetStudentModel, studentCommand);
        AdjustCommand(Cmd.ImproveAttack, playerCommand);
        //List<PlayerRoleInfo> playerInfo =  ArchiveManager.Instance.GetSamplelist<PlayerRoleInfo>();
        //Log(playerInfo[0].Attack);
        //PlayerRoleInfo player1 = ArchiveManager.Instance.GetSampleInIndex<PlayerRoleInfo>(0);
        //Debug.Log(player1.BreathingRate);
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
    //public void showColor1()
    //{
    //    AppFactory.instances.Todo(new Observer(Cmd.showColor, ColorModel.instances().red));
    //}




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
