﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary> ウィンドウを作成するクラス </summary>
public class Window : EditorWindow
{
    /// <summary> ウィンドウを表示する </summary>
    [MenuItem("Window/Window to display text")] 　//ツールバーのWindow下に作成
    static void Open()
    {
        var window = GetWindow<Window>();

        //EditorWindowsのタイトルを描画するために使用されるGUIContent。
        window.titleContent = new GUIContent("俺のウィンドウ");
    }

    /// <summary> ウィンドウにテキスト表示 </summary>
    private void OnGUI()
    {
        EditorGUILayout.BeginVertical("Box");
        EditorGUILayout.LabelField("テキストおおおおおおおおおおおおおおおおおおお");
        EditorGUILayout.EndVertical();

        EditorGUILayout.Space();

        EditorGUILayout.BeginVertical("Box");
        EditorGUILayout.LabelField("オリジナルのウィンドウを作ろう！");
        EditorGUILayout.LabelField("EditorGUILayout.BeginVerticalを使うと縦に並ぶ。");
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("EditorGUILayout.BeginHorizontalを使えば");
        EditorGUILayout.LabelField("横に並べることもできます。");
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();

        EditorGUILayout.Space();

        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("こちらはスタイルなしバージョン。");
        EditorGUILayout.LabelField("周りが囲われていません。");
        EditorGUILayout.EndVertical();
    }
}
