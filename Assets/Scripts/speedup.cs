using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedup : MonoBehaviour
{

    private Rigidbody2D rigid_player;
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip[] clips = new AudioClip[2];
    private Vector3 force = new Vector3(150,0,0);

    void Start(){
        rigid_player = GameObject.Find("Protagonist").GetComponent<Rigidbody2D>();
        Debug.Log(rigid_player);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            rigid_player.AddForce(force);
            source.PlayOneShot(clips[0]);//音を鳴らす
        }
    }
}
