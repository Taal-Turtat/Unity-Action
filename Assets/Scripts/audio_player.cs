using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audio_player : MonoBehaviour
{
    [SerializeField]
    public AudioSource source;
    [SerializeField]
    public AudioClip[] clip;
    public static int flag = 0; //どの音楽を流すか?

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
}
