using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float twerkAmount = 1.0f;
    [SerializeField] float boostAmount = 30.0f;
    [SerializeField] float basesSpeed = 1.0f;
 

    Rigidbody2D harry;
    SurfaceEffector2D snowEffector2D;
    bool move = true;

    void Start()
    {
        harry = GetComponent<Rigidbody2D>();
        snowEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (move)
        {
            rotationing();
            boosting();
        }
        else
        {

        }
    }
    
    void rotationing()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            harry.AddTorque(twerkAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            harry.AddTorque(-twerkAmount);
        }
    }

    void boosting()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            snowEffector2D.speed = boostAmount;
        }
        else
        {
            snowEffector2D.speed = basesSpeed;
        }
    }

    public void DisableControls()
    {
        move = false;
    }
}
