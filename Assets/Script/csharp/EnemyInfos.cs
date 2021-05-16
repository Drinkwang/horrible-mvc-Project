//
// Auto Generated Code By excel2json
// https://neil3d.gitee.io/coding/excel2json.html
// 1. 每个 Sheet 形成一个 Struct 定义, Sheet 的名称作为 Struct 的名称
// 2. 表格约定：第一行是变量名称，第二行是变量类型

// Generate From EnemyInfos.xlsx

public class EnemyInfos
{
	public string EnemyId; // 编号
	public string EnemyName; // 敌人名字
	public float Hp; // 初始生命值
	public float Attack; // 攻击力
	public float Range; // 攻击范围（100是近战）
	public float AttackFreq; // 攻击力频率
	public float Def; // 防御力
	public float Speed; // 单位移动速度
	public int[] Skills; // 技能组(enemy组)
	public int Levels; // 出现在那些关卡
	public float IQ; // 智商高低
}


// End of Auto Generated Code
