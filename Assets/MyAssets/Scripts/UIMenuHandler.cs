using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif 


public class UIMenuHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerNameInput;

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        Data.Instance.PlayerName = playerNameInput.text;
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            //EditorApplication.ExitPlayMode();
        #else
            Application.Quit(); // original code to quit Unity Player
        #endif
    }
}
