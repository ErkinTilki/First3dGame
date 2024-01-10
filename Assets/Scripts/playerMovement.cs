using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float xValueSpeed = 4f;
    [SerializeField] float zValueSpeed = 4f;
    void Start()
    {
        
    }

    
    void Update()
    {
        movePlayer();
    }
    
    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * xValueSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * zValueSpeed;
        transform.Translate(xValue, 0f, zValue );
    }
}
