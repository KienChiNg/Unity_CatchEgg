using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public int moveSpeed;
    float xDirection;
    GameControler m_gc;
    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindObjectOfType<GameControler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_gc.GetGameOverState())
        {
            return;
        }
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        if((transform.position.x < -11.92 && xDirection < 0) || (transform.position.x > 12.02 && xDirection > 0)){
            return;
        }
        transform.position += new Vector3(moveStep, 0, 0);
    }
}
