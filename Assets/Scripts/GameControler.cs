using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject egg;
    public int spawnBall;

    UIManager m_ui;

    int m_score;
    bool m_gameOver;
    float m_spawnBall;
    int m_record;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnBall = 0;
        m_score = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_gameOver)
        {
            m_record = (m_record < m_score) ? m_score : m_record;
            m_ui.SetRecord("Record: "+m_record);
            m_score = 0;
            return;
        }
        m_spawnBall -= Time.deltaTime;
        Debug.Log(Time.deltaTime);
        if(m_spawnBall <=0)
        {
            SpawnBall();
            m_spawnBall=spawnBall;
        }
    }

    public void Replay()
    {
        m_gameOver = false;
        m_spawnBall = 0;
        m_score = 0;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameOverPanel(false);

    }

    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-10, 10), 6);
        if (egg)
        {
            Instantiate(egg,spawnPos,Quaternion.identity);
        }
    }

    public void IncrementScore()
    {
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }

    public void SetGameOverState(bool state)
    {
        m_gameOver = state;
    }
    public bool GetGameOverState()
    {
        return m_gameOver;
    }
}
