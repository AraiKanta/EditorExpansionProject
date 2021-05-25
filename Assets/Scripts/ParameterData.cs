using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> EnemyのDataをScriptableObjectにするクラス </summary>
[CreateAssetMenu(menuName = "MyScriptable/Create PrameterData")]
public class ParameterData : ScriptableObject
{
    /// <summary> 敵の名前 </summary>
    [Header("敵の名前")]
    public string enemyName;
    /// <summary> 体力 </summary>
    [Header("体力")]
    public int maxHp;
    /// <summary> 攻撃力 </summary>
    [Header("攻撃力")]
    public int atk;
    /// <summary> 防御力 </summary>
    [Header("防御力")]
    public int def;
    /// <summary> 素早さ </summary>
    [Header("素早さ")]
    public int agl;
    /// <summary> 経験値 </summary>
    [Header("経験値")]
    public int exp;
    /// <summary> ゴールド </summary>
    [Header("ゴールド")]
    public int gold;
}
