using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Score;
    public Text Record;
    public GameObject GameOver;
    public void SetScoreText(string txt)
    {
        Score.text = txt;
    }
    public void ShowGameOverPanel(bool state)
    {
        GameOver.SetActive(state);
    }

    public void SetRecord(string txt)
    {
        Record.text = txt;
    }
}
