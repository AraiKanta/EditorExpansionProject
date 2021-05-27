using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> このScriptableObjectアセットには読み込み対象のCSVファイルを参照させる </summary>
[CreateAssetMenu(menuName = "MyScriptable/Create CSV Impoter")]
public class CSVImporter : ScriptableObject
{
    public TextAsset csvFile;
}
