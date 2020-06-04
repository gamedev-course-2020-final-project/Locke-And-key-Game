using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    [SerializeField] RawImage rawImage;
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rawImage.GetComponent<RawImage>().enabled = false;
    }

    /*
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rawImage.GetComponent<RawImage>().enabled = true;
            StartCoroutine(PlayVideo());
        }
    }*/

    public IEnumerator PlayVideo()
    {
        rawImage.GetComponent<RawImage>().enabled = true;
        videoPlayer.Prepare();
        yield return new WaitForSeconds(2);
        videoPlayer.Play();
        audioSource.Play();
        yield return new WaitForSeconds(25);
        rawImage.GetComponent<RawImage>().enabled = false;
    }
}
