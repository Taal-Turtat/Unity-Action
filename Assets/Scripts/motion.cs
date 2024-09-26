using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    private const float gravity = 1.0f;

    public static float speed = 7.5f;
    private float jump = 8.0f;
    public static bool right = true;
    public static bool left = false;
    public static bool isGameover = false;
    private Animator anim = null;
    private Rigidbody2D rig = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isGameover==false){
            float vkey = Input.GetAxis("Vertical");
            if(right == true){
                anim.SetBool("right", true);
                anim.SetBool("left", false);
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
                if(vkey < 0.2f){
                    transform.position -= new Vector3(0, jump * Time.deltaTime, 0);
                }
                else if(vkey > 0.2f){
                    transform.position += new Vector3(0, jump * Time.deltaTime, 0);
                }
            }
            else if(left == true){
                anim.SetBool("right", false);
                anim.SetBool("left", true);
                transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
                if(vkey < 0.2f){
                    transform.position -= new Vector3(0, jump * Time.deltaTime, 0);
                }
                else if(vkey > 0.2f){
                    transform.position += new Vector3(0, jump * Time.deltaTime, 0);
                }
            }
        }
        else{
            StartCoroutine(Wait(1.0f));
            rig.gravityScale = 0;
        }
    }

    IEnumerator Wait(float delay){
        yield return new WaitForSeconds(delay);
    }
}
