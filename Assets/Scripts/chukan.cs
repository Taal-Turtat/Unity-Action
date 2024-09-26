using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chukan : MonoBehaviour
{
    public static bool isChukan = false;

    void Update(){
        if(isChukan){
            if(Input.GetKeyDown(KeyCode.C)){
                if(motion.left==true){
                    motion.left = false;
                    motion.right = true;
                }
                else if(motion.right==true){
                    motion.left = true;
                    motion.right = false;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D cld){
        if(cld.gameObject.tag == "Player"){
            isChukan = true;   
        }
    }

    void OnTriggerExit2D(Collider2D cld){
        if(cld.gameObject.tag == "Player"){
            isChukan = false;   
        }
    }

    IEnumerator Wait(float delay){
        yield return new WaitForSeconds(delay);
    }
}
