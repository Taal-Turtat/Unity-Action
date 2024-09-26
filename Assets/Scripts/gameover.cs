using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{

    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip[] clips = new AudioClip[2];
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="Player"){
            Debug.Log("ゲームオーバー!");
            col.gameObject.GetComponent<Animator>().SetBool("explode",true);
            motion.isGameover = true;
            source.PlayOneShot(clips[0]);//音を鳴らす
            //最初に戻る
        }
    }
}
