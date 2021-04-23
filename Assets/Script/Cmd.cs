using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class Cmd
{
    public const string changeCamera = "changeCamera";
    public const string initCamera = "initCamera";
    public const string moveCamera = "moveCamera";
    public const string addCamera = "addCamera";


    //tv
    public const string changeTv = "changeTv";
    public const string playTv = "playTv";
    public const string initTv = "initTv";
    public const string stopTv = "stopTv";


    //item
    public const string addItem = "AddGoodscommand";
    public const string showItem = "showitem";
    public const string hideItem = "hideitem";
    public const string consumeItem = "consumeItem";

    //diaglog
    public const string dialogAdd = "dialogadd";
    public const string dialog = "dialog";
    public const string dialogReplace = "dialogReplace";
    public const string dialogClear = "dialogclear";


    //postEffect
    public const string postEffectOperate = "postEffectOperate";
    public const string initPostEffectOperate = "initPostEffectOperate";
    public const string initPostEffectModel = "initPostEffectModel";
    public const string shaderPostEffectOperate = "shaderPostEffectOperate";


    //changeButton
    public const string QuetionChangeButton = "QutionChangeButton";
    public const string QuetionChangeTitle = "QuetionChangeTitle";
    public const string QuetionShow = "QuetionShow";
    public const string QuetionChangeA = "QuetionChangeA";
    public const string QuetionCHnngeB = "QuetionChangeB";
    public const string showColor = "showColor";

    public const string showTip = "showTip";
    public const string ShowImageAndText = "ShowImageAndText";
    public const string changeColor = "color";
    //后续有可能的话，操作view和操作ctrl也进行分层
}

