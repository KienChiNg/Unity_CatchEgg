using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    GameControler m_gc;
    UIManager m_ui;

    private void Start()
    {
        m_gc = FindObjectOfType<GameControler>();
        m_ui = FindObjectOfType<UIManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            Destroy(gameObject);
            Debug.Log("Da va cham voi thanh chan");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            Destroy(gameObject);
            m_gc.SetGameOverState(true);
            m_ui.ShowGameOverPanel(true);
            Debug.Log("Da va cham voi deathzone");
        }
    }
}
