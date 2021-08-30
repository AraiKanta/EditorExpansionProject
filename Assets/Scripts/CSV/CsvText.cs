using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// CSVファイルを読み込み書き込みをテストするためのクラス
/// </summary>
public class CsvText : MonoBehaviour
{
    ///<summary>格納用の二次元は配列</summary>
    List<string[]> m_csvTexts = new List<string[]>();
    /// <summary> テキストの変数 </summary>
    [SerializeField] Text m_testText = null;
    /// <summary> csv </summary>
    TextAsset csvFile;
    /// <summary>  </summary>
    private string m_textData = default;
    /// <summary>  </summary>
    private string[] m_splitText = default;
    /// <summary> count用の変数 </summary>
    private int m_currentNum = 0;



    void Start()
    {
        CSVFile();

        #region
        ////TextAssetのTextの読み専用クラスであるStringRenderに格納
        //StringReader reader = new StringReader(m_textData);

        ////render.Peekが-1になるまで
        //int PeekInt = -1;
        //while (reader.Peek() != PeekInt)
        //{
        //    //一行ずつ読み込み
        //    string line = reader.ReadLine();

        //    //カンマで区切りリストに追加
        //    //m_csvTexts.Add(line.Split(','));


        //}
        #endregion
    }

    /// <summary>
    /// Resourcesフォルダのcsvファイルの読み込み
    /// </summary>
    private void CSVFile()
    {
        //Resourcesフォルダのcsvファイルの読み込み
        //Unityのテキスト読み込み様式であるTextAssetに変換
        csvFile = Resources.Load("Text") as TextAsset;

        m_textData = csvFile.text;

        m_splitText = m_textData.Split(char.Parse("\n"));

        m_testText.text = m_splitText[m_currentNum];

        //デバッグ用
        for (var x = 0; x < m_csvTexts.Count; x++)
        {
            for (var y = 0; y < m_csvTexts[x].Length; y++)
            {
                Debug.Log(m_csvTexts[x][y]);
            }
        }

        //書き込み
        #region

        FileInfo fileInfo = new FileInfo("Assets/Resources/WritingText.csv");
        Debug.Log(fileInfo);

        //StreamWriterに入れて中身を書き入れていく
        StreamWriter streamWriter = fileInfo.AppendText();
        for (var i = 0; i < m_csvTexts.Count; i++)
        {
            //※Join(“入れる文言”,配列など)は配列などの各項目の間に入れたい文言がある場合に使う
            //第一引数が入れる文言で、第二引数以降は入れられる各項目
            string csvString = string.Join(",", m_csvTexts[i]);

            streamWriter.WriteLine(csvString);

            //ファイルに書き出す処理
            streamWriter.Flush();
        }
        #endregion
    }

    public void OnClick()
    {
        // 数字を「０→１→２→０→１→２・・・」でループさせる方法（%；余り算の活用）
        m_currentNum = (m_currentNum + 1) % m_splitText.Length;

        m_testText.text = m_splitText[m_currentNum]; 
    }
}
