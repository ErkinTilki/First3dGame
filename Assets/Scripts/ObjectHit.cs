using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    GameObject mygameobject;
    MeshRenderer mymeshRenderer;
    Material myMaterial;

    void Start()
    {
        mygameobject = GetComponent<GameObject>();
        mymeshRenderer = GetComponent<MeshRenderer>();
        myMaterial = GetComponent<Material>();
    }

    

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            mymeshRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    } 
    
}
