using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMnagerScript : MonoBehaviour
{
    public AudioSource myAudio;

    public AudioClip[] clips;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        StartCoroutine("DelayedAudio");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            myAudio.PlayOneShot(clips[0]);
        }
    }

    public void PlayMusic(int trackNumber)
    {
        myAudio.PlayOneShot(clips[trackNumber]);
    }

    public IEnumerator DelayedAudio()
    {
        yield return new WaitForSeconds(5f);
        PlayMusic(0);
        yield return new WaitForSeconds(10f);
        PlayMusic(1);
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(0);
    }
}
