using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoRotator : MonoBehaviour
{
    [SerializeField]
    private List<VideoPlayer> Players;

    [SerializeField]
    private List<string> VideoUrl = new List<string>();

    public List<VideoPlayer> orderedPlayers;
    public int topImageIndex;
    public int bottomImageIndex;

    void Start()
    {
        VideoUrl.Clear();
        for(int i = 0;i < ApiManager.Reels.Length; i++)
        {
            VideoUrl.Add(ApiManager.Reels[i].url);
        }
        VideoUrl.Add(ApiManager.Reels[ApiManager.Reels.Length - 1].url);
        VideoUrl.Add(ApiManager.Reels[ApiManager.Reels.Length - 1].url);
        for (int i = 0;i < orderedPlayers.Count; i++)
        {
            orderedPlayers[i].url = VideoUrl[i];
            if(i != 0)
            {
                orderedPlayers[i].Pause();
            }
        }
    }

    public int GetTopIndex()
    {
        return topImageIndex;
    }

    public int GetBottomIndex()
    {
        return bottomImageIndex;
    }

    public void IncTop()
    {
        topImageIndex += 1;
    }

    public void IncBottom()
    {
        bottomImageIndex += 1;
    }

    public void decTop()
    {
        topImageIndex -= 1;
    }

    public void decBot()
    {
        bottomImageIndex -= 1;
    }

    public void changeTex(int PlayerIndex, int VideoIndex)
    {
        if (PlayerIndex < 0 || VideoIndex < 0) return;
        Players[PlayerIndex].url = VideoUrl[VideoIndex];
        Players[PlayerIndex].Pause();
    }


}
