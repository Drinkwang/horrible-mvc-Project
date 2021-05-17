using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using System;

namespace EditorTool
{
    public class ExcelTool
    {
        //读取表数据，生成对应的数组
        public static PlayerInfo[] CreateplayerInfoArray(string filePath)
        {
            int columnNum = 0, rowNum = 0;
            DataRowCollection collect = ReadExcel(filePath, ref columnNum, ref rowNum);
            PlayerInfo[] array = new PlayerInfo[rowNum - 1];
            for(int i = 2; i < rowNum; i++)
            {
                PlayerInfo playerInfo = new PlayerInfo();
                playerInfo.RoleId = uint.Parse(collect[i][0].ToString());
                playerInfo.RoleName = collect[i][1].ToString();
                playerInfo.occupation = (Occupation)Enum.Parse(typeof(Occupation), collect[i][2].ToString());
                playerInfo.luck = int.Parse( collect[i][3].ToString());
                playerInfo.speed= int.Parse(collect[i][4].ToString());
                playerInfo.range= int.Parse(collect[i][5].ToString());
                playerInfo.Hp= int.Parse(collect[i][6].ToString());
                playerInfo.Mp = int.Parse(collect[i][7].ToString());
                playerInfo.Def= int.Parse(collect[i][8].ToString());
                playerInfo.Attack= int.Parse(collect[i][9].ToString());
                playerInfo.SkillIds = Array.ConvertAll(collect[i][10].ToString().Split(','), new Converter<string, int>(StrToInt));
                playerInfo.maxItemNum = int.Parse(collect[i][11].ToString());
                //playerInfo.SkillIds = Array.ConvertAll(collect[i][12].ToString().Split(','), new Converter<string, int>(StrToInt));
                playerInfo.breathing = float.Parse(collect[i][13].ToString());
                playerInfo.breathingRate = float.Parse(collect[i][14].ToString());
                array[i - 2] = playerInfo;
            }
            return array;
        }
        public static int StrToInt(string str)
        {
            return int.Parse(str);
        }
        static DataRowCollection ReadExcel(string filePath,ref int columnNum,ref int rowNum)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            //IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //DataSet result = excelReader.AsDataSet();
            //columnNum = result.Tables[0].Columns.Count;
            //rowNum = result.Tables[0].Rows.Count;
            //return result.Tables[0].Rows;
            return null;
        }
    }

}
