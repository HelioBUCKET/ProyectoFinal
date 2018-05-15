using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class IntroScreen : MonoBehaviour {

    public GameObject StartText;

    public AudioClip MusicClip;
    public AudioSource MusicSource;

    public Image black;
    public Animator anim;

    // Use this for initialization
    void Start () {
        InvokeRepeating("FlashLabel", 0, 1);
    }

    // Update is called once per frame
    void Update () {
        if (Input.anyKey)
        {


            MusicSource.Play();
            StartCoroutine("waitTime");
        }
    }

    void FlashLabel()
    {
        if (StartText.activeSelf)
            StartText.SetActive(false);
        else
            StartText.SetActive(true);
    }

    IEnumerator waitTime()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(()=>black.color.a==1);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }


}
