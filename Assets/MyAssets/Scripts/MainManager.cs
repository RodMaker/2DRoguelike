using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainManager : MonoBehaviour
{
    //public Text ScoreText;
    public TextMeshProUGUI CurrentPlayerName;

    void Start()
    {
        CurrentPlayerName.text = Data.Instance.PlayerName;
    }
}
