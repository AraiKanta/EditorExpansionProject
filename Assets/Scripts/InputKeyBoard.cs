using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// キーボード入力を行うクラス
/// </summary>
public class InputKeyBoard : MonoBehaviour
{
    /// <summary> InputFieldを参照する </summary>
    [SerializeField] private InputField m_inputField;
    /// <summary> Textを参照する </summary>
    [Header("入力された値がでるTextオブジェクトを入れる")]
    [SerializeField] private Text m_text;

    void Start()
    {
        // onEndEditイベントにUpdateTextメソッドを登録する
        m_inputField.onEndEdit.AddListener(UpdateText);
    }

    /// <summary>
    /// 入力されたテキストを更新するメソッド
    /// </summary>
    /// <param name="text"></param>
    private void UpdateText(string text)
    {
        // テキストを更新する
        m_text.text = text;
    }
}