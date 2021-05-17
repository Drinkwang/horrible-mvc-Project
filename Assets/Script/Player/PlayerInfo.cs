using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerInfo
{
    public uint RoleId;  //编号
    public string RoleName;//角色名字
    public Occupation occupation;//职业
    public int luck;//运气
    public int speed;//速度
    public int range;//射程
    public int Hp {set;get; }//初始生命值
    public int Mp { set; get; }//初始魔法值
    public int Def { set; get; }//防御力
    public int Attack { set; get; }//攻击力
    public int[] SkillIds;//技能ID
    public int maxItemNum;//初始背包数量
    public int[] limitItemIds;//限制使用物品ID
    public float breathing;//呼吸回血范围
    public float breathingRate;//呼吸回血速度/s
}
public enum Occupation
{
    女警官, 记者, 魔术师
}

