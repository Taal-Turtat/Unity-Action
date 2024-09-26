using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{
    [SerializeField] 
    private bool isfallen;

    public bool SetGet_isfallen{
        get { return isfallen; }
        set { isfallen = value; }
    }

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = this.GetComponent<Rigidbody2D>();
        isfallen = true;
    }

    void OnCollisionEnter2D(Collision2D col){
        if(isfallen){
            if(col.gameObject.tag == "Player"){
                rig.gravityScale = 1;
            }
        }
    }

    IEnumerator Wait(float time){
        yield return new WaitForSeconds(time);
    }
}
