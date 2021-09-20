using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class jugaadscript : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer videoPlayer;

    public int i = 0;

    void Start()
    {
        videoPlayer.url = videoUrl[0];
    }

    public List<string> videoUrl = new List<string>
    {
        "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
        "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4",
        "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerBlazes.mp4"
    };
    public void Play()
    {
        videoPlayer.Play();
    }

    public void pause()
    {
        
        i += 1;
        if(i == 3)
        {
            i = 0;
        }
        changeVideo(i);
        //videoPlayer.Stop();
    }

    private void changeVideo(int videoInd)
    {
        videoPlayer.url = videoUrl[videoInd];
    }
}
