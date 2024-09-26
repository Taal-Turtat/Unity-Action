using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift_controler : MonoBehaviour
{

    private lift lift;

    void Start()
    {
        lift = transform.parent.gameObject.GetComponent<lift>(); 
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="Player"){
            lift.SetGet_isfallen = false;
        }
    }

    void  OntriggerExit2D(Collider2D col){
        if (col.gameObject.tag=="Player"){
            lift.SetGet_isfallen = true;
        }
    }
}
