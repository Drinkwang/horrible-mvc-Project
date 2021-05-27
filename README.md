# mvc 框架的(已经升级成mvvm)

## 1.框架设计目的
 该框架最初是制作Mmo所做，后来又应用到个人Horrible game（恐怖fps游戏所作）项目，以及最近与好有协助开发roguelike game，再此基础不断改进而成。框架适合模块化开发，协同工作，此后也会不断改进提升。

<p align="center">
    <img width="400px" src="https://github.com/Drinkwang/drinkwang.github.io/blob/master/img/git.png?raw=true">    
</p>

# 

## 2.框架的内容

```内容构成
* controller(包括继承IC接口的command类，以及管理所有command的controller类)
* model(数据类，主要指代Model和Proxy类)
* view(包括继承Vmediator接口的XXXView类，以及管理所有XXXView的view类)
* appfactory(工厂类，用来初始化mvc，也是mvc的入口)
* ovserver(监听器类，用来传参)

```
### 3.使用教程
该框架是一个MVC框架，所以关键在于MVC三个模块之间的互相调用
* M（数据层）
* V（视图层）
* C（控制层）
#### 1.Controller模块调用Model模块 C --> M 
使用首先我们需要注册Controller类，需要在Appfactory类中创建新的Controller类
```c#  
   public AddGoodscommand add;//添加物品的命令
```
然后我们需要在`Appfactory`的`init`方法中，将命令给`实例化`,并将其绑定对应的字符常量，对应`Cmd`类里的字段
```c#   
   void init()
   {
      add = new AddGoodscommand(); //实例化add方法
      AdjustCommand(Cmd.addItem, add);//绑定字符常量，Cmd.addItem="AddGoodscommand"
   }
```
再次之后，我们只需要在任意位置调用
```c# 
   AppFactory.instances.Todo(new Observer(Cmd.addItem, "大宝剑"));//大宝剑是参数，可省略
```
就可以进入`AddGoodscommand`类的`Todo`方法啦。
所以我们就来看看`AddGoodscommand`类的写法
首先它需要继承`IC`这个类，并且实现`Todo`的抽象方法，而我们的`Todo`方法也就是具体功能类，这里用来写我们需要开发的功能，我们可以这么写
```c#   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGoodscommand : IC
{
    PackProxy packproxy = PackProxy.instances();//Model对象，指代背包数据


    public void Todo(Observer io)
    {
       if(io.msg=="Cmd.addItem")
       {
          //此处代码为PackProxy增加一个新物品，具体可以参考源代码的内容
       }
    }
}
```

这样就成功实现Controller调用Model了

</br>

#### Controller模块调用Coponent对象 C --> V 
1.此处有二种方法，一个是在上面写的Controller的Todo方法中直接调用具体组件对象的实例

```c#   

    public void Todo(Observer o)
    {
       packageComponent.instante.showPackage((List<Packagemodel> model)o.body)
    }
```
> 但是这样处理解耦合不够彻底，新入门的开发者可以这样学习和使用。但最好的办法是在`Todo`方法里调用View模块，来实现`mvvm`。
```c#   

    public void Todo(Observer o)
    {
        AppFactory.instances.ViewTodo(new Observer(Cmd.show,(List<Packagemodel> model)o.body));
	//具体为什么这么写可以调用view模块，请接着把下面的内容看完
    }
```

2.view模块写法

> View模块是一个类似于command对象的实现，首先还是需要在`Appfactory`对象的`init`方法进行View绑定

```c#   

    void init()
    {
       AdjustView(new Packageview());
      
    }
```

> 这样就绑定好了。接下来我们来看Packageview的实现，首先我们需要重写`Vmediator` 的抽象字段和方法，我们要在name的返回值给出View的名字，并在msglist中添加可以使用的`命令字符`


```c#
    public class Packageview : Vmediator {
	packageComponent pack;
	// Use this for initialization
	public Packageview()
	{
           pack=packageComponent.instante;
	}

	public override string name {
	   get {
	      return "Packageview";
	   }
	}
    
	public override List<string> msglist {
	   get {
	      List<string> mlist = new List<string> ();
	      mlist.Add ("show");//这里也可以用Cmd.show来替代
	      return mlist;
           }
	}


     }
```

最后当然不要忘了我们的`todo`方法

```c#   
	packageComponent pack;
        public override void Todo (Observer o)
	{
	   if(o.msg=="show"){	
   	      pack.show((List<Packagemodel> model)o.body)
	   }
	}
```

这样做之后，就能通过  `AppFactory.instances.ViewTodo`进行调用
</br>
</br>
#### Model对象
Model对象只是一个单例的数据对象，可以由自己完全编写，当然也可以使用该框架提供的Proxy类和Model类进行便捷处理，这方面的内容待续..
</br>
### Mvvm升级内容介绍（新）
> 实际上是 M --> V的方法 
#### 使用教程

本次升级为model直接调用view提供桥梁，在每次修改具体model实例时都会刷新view（界面），使部分功能开发更为高效..

新升级内容完全兼容之前的内容，之前代码无需修改，仅在适宜自己功能需要时使用。

使用方法，在Model模块的单例模式的return instance前调用`instance.ModelToDoView();`这样每次获取model对象进行操作时候都会对View进行刷新

```c#
    public static AllTaskproxy instances()
    {
        if (instance == null)
        {
            instance = new AllTaskproxy();

        }
        instance.ModelToDoView();
        return instance;

    }
```

另外需要在任意unity对象中绑定指定的view，也就是调用

` Proxy.instance.regiestNewComponent（Vmediator）;`

这样桥梁就成功搭建了,此后每次调用Model对象单例时候都会调用View.refresh方法。


#### 框架修改（仅配合理解框架）

具体框架修改内容如下：

model模块也就是Proxy的基类当中增加了二个方法，用来刷新“View”模块，也就是具体的Vmediator类

增加方法如下:

```c#
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
```

以及调用单例的方法

```c#
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
```



</br>


### 数据处理

目前数据文件是excel，但处理走的是json相关的逻辑。需要通过excel2json工具转换成对应`cs类和json`文件

下载链接和资料：https://neil3d.github.io/coding/excel2json.html

将`json文件和cs文件`导入到具体文件夹后，具体数据处理相关使用`ArchiveManager`这个类的单例，使用 `GetSamplelist<T>()`可以获取对应序列化实例对象的链表。直接可以用来使用。

![参考1](https://github.com/Drinkwang/jekyll2/blob/master/assets/cooperation/json1.png?raw=true)

![参考2](https://github.com/Drinkwang/jekyll2/blob/master/assets/cooperation/json2.png?raw=true)

```c#
//源码参考,其他非示例参考代码请自行理解
    public List<T> GetSamplelist<T>()where T:class {
        var t = ArchiveManager.Instance.Retrieve<T>();
        var content = t.ToJson();
        List<T> list = JsonMapper.ToObject<List<T>>(content);
        return list;
    }
    
```

</br>



## Authors

* **Drinker·wang** - [Github](https://github.com/Drinkwang)
<br>[B站 Follow](https://space.bilibili.com/13061595)  

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
