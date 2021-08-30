using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

/// <summary> アプリケーションを終了させるクラス </summary>
public class ExitApp : MonoBehaviour
{
    /// <summary>
    /// 終了ボタン
    /// </summary>
    [System.Obsolete]
    private void OnApplicationQuit()
    {
        // 終了処理をキャンセル
        Application.CancelQuit();
    }

    /// <summary>
    /// 終了
    /// </summary>
    public void OnExit()
    {
        Application.Quit();

        End();
    }

    //終了
    [MenuItem("Custom/End")]
    private static void End()
    {
        EditorApplication.isPlaying = false;
    }
}