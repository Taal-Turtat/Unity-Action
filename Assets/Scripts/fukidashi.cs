using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fukidashi : MonoBehaviour
{

    private SpriteRenderer sprite;
    private int flags = 0;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(255,255,255,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(chukan.isChukan){
            //中間なら表示する
            sprite.color = new Color(255,255,255,255);
        }
        else{
            //中間でない場合は非表示にする
            sprite.color = new Color(255,255,255,0);
        }
    }
}
