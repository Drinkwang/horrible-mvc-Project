using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
namespace EditorTool
{
    public class ExcelBuild : Editor
    {
        [MenuItem("CustomEditor/CreateItemAsset")]
        public static void CreatePlayerInfoAsset()
        {
            PlayerInfoManager manager = ScriptableObject.CreateInstance<PlayerInfoManager>();
            manager.playerInfoArray = ExcelTool.CreateplayerInfoArray(ExcelConfig.excelsFolderPath+ "PlayerRoleInfo.xlsx");
            if (!Directory.Exists(ExcelConfig.assetPath))
            {
                Directory.CreateDirectory(ExcelConfig.assetPath);
            }
            string assetPath = string.Format("{0}{1}.asset", ExcelConfig.assetPath, "Item");
            AssetDatabase.CreateAsset(manager, assetPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}

