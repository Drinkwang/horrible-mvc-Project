//
// Auto Generated Code By excel2json
// https://neil3d.gitee.io/coding/excel2json.html
// 1. 每个 Sheet 形成一个 Struct 定义, Sheet 的名称作为 Struct 的名称
// 2. 表格约定：第一行是变量名称，第二行是变量类型

// Generate From E:\我的unity\华中师范研究生\horrible-mvc-Project\PlayerRoleInfo.xlsx.xlsx

public class PlayerRoleInfo
{
	public int RoleId; // 编号
	public string RoleName; // 角色名字(有新角色往下加)
	public string occupation; // 职业
	public int luck; // 运气
	public int speed; // 速度
	public int range; // 射程
	public int Hp; // 初始生命值
	public int Mp; // 初始魔法值
	public int Def; // 防御力
	public int Attack; // 攻击力
	public int[] SkillIds; // 技能ID
	public int MaxItemNum; // 初始背包数量
	public int[] LimitItemIds; // 限制使用物品ID
	public double Breathing; // 呼吸回血范围
	public double BreathingRate; // 呼吸回血速度/s
}


// End of Auto Generated Code
