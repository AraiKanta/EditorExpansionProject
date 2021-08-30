using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private Button[] m_button = default;
    [SerializeField] private string[] m_sceneName = default;
    private string m_scenesName = default;

    private void Start()
    {
        m_scenesName = m_sceneName[0];
        Debug.Log("スタート時" + m_scenesName);
    }

    public void OnClick()
    {
        if (m_button[0])
        {
            m_scenesName = m_sceneName[0];
            SceneManager.LoadScene(m_scenesName);
            Debug.Log("シーン遷移時" + m_scenesName);
        }
        else if (m_button[1])
        {
            m_scenesName = m_sceneName[1];
            SceneManager.LoadScene(m_scenesName);
            Debug.Log("シーン遷移時" + m_scenesName);
        }
    }
}
