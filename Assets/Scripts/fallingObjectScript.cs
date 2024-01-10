using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingObjectScript : MonoBehaviour
{
    
    Rigidbody  myRigidBody;
    MeshRenderer myMeshRenderer;

    [SerializeField] float fallTriggerTime = 7f;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();

        myRigidBody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    
    void Update()
    {
        if(Time.time >= fallTriggerTime)
        {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;

        }
        //Debug.Log(Time.time);
    }
}
