using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public ChangeMyscene gs;
    void Start()
    {
        rawImageVideo.SetActive(false);
    }
    public void playerAttack()
    {
        playerAnimator.SetTrigger("isAttack");

    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        rawImageVideo.SetActive(true);
    }
    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }
    // Update is called once per frame
    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(10.0f);
        gs.ChangeMyScene("Menu");
    }
}