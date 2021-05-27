using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CsvImporter))]
public class CSVImporterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var csvImpoter = target as CsvImporter;

        DrawDefaultInspector();

        if (GUILayout.Button("敵データの作成"))
        {
            SetCsvDataToScriptableObject(csvImpoter);
            //Debug.Log("敵データ作成");
        }
    }
    void SetCsvDataToScriptableObject(CsvImporter csvImporter) 
    {
        // ボタンを押されたらパース実行
        if (csvImporter.csvFile == null)
        {
            Debug.LogWarning(csvImporter.name + ":読み込むcsvファイルがセットされていません");
            return;
        }

        // csvファイルをstring形式に変換
        string csvText = csvImporter.csvFile.text;

        // 改行ごとにパース
        string[] afterParse = csvText.Split('\n');

        // ヘッダー行を除いてインポート
        for (int i = 1; i < afterParse.Length; i++)
        {
            string[] parseByComma = afterParse[i].Split(',');

            int column = 0;

            // 先頭の列が空であればその行は読み込まない
            if (parseByComma[column] == "")
            {
                continue;
            }

            // 行数をIDとしてファイルを作成
            string fileName = "enemyData_" + i.ToString("D4") + ".aseet";
            string path = "Assets/DataConverter/CreatEnemyData/" + fileName;

            // EnemyDataのインスタンスをメモリ上に作成
            var parameterData = CreateInstance<ParameterData>();

            //名前
            parameterData.enemyName = parseByComma[column];

            //体力
            column += 1;
            parameterData.maxHp = int.Parse(parseByComma[column]);

            //攻撃力
            column += 1;
            parameterData.atk = int.Parse(parseByComma[column]);

            //防御力
            column += 1;
            parameterData.def = int.Parse(parseByComma[column]);

            //素早さ
            column += 1;
            parameterData.agl = int.Parse(parseByComma[column]);

            //経験値
            column += 1;
            parameterData.exp = int.Parse(parseByComma[column]);

            //ゴールド
            column += 1;
            parameterData.gold = int.Parse(parseByComma[column]);

            // インスタンス化したものをアセットとして保存
            var asset = (ParameterData)AssetDatabase.LoadAssetAtPath(path, typeof(ParameterData));
            if (asset == null)
            {
                // 指定のパスにファイルが存在しない場合は新規作成
                AssetDatabase.CreateAsset(parameterData, path);
            }
            else
            {
                // 指定のパスに既に同名のファイルが存在する場合は更新
                EditorUtility.CopySerialized(parameterData, asset);
                AssetDatabase.SaveAssets();
            }
            AssetDatabase.Refresh();
        }
        Debug.Log(csvImporter.name + " : 敵データの作成が完了しました。");
    }
}
