using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Wall"){
            //Debug.Log("B(し)");
        }
    }
}
