using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            //ゲームクリア処理
            Debug.Log("ゲームクリア!");
        }
    }
}
