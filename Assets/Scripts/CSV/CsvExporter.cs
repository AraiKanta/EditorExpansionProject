
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> CSVファイル書き出し用ScriptableObjectのクラス </summary>
[CreateAssetMenu(menuName = "MyScriptable/Create CSV Exporter")]
public class CsvExporter : ScriptableObject
{
	public string fileName;
}
