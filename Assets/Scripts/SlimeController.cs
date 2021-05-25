using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> ScriptableObjectを参照してコンソールで出るか試すクラス </summary>
public class SlimeController : MonoBehaviour
{
    public ParameterData m_parameterData;

    void Start()
    {
        ShowScriptableObject();
    }

   void ShowScriptableObject()
   {
        Debug.Log("\n名前" + m_parameterData.enemyName + "\n体力" + m_parameterData.maxHp + "\n攻撃力" + m_parameterData.atk + 
                  "\n防御力" + m_parameterData.def + "\n素早さ" + m_parameterData.agl + "\n経験値" + m_parameterData.exp + "\nゴールド" + m_parameterData.gold);
   }
}
