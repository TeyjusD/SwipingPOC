using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine.UI;
using UnityEngine.Video;

public class InputManager : MonoBehaviour
{
   [SerializeField]
   private SimpleScrollSnap ss;

    public List<VideoPlayer> Players;

    //new change 1

   public void GotoNext(){
       ss.GoToNextPanel();
        PlayPauseVideo((ss.CurrentPanel + 1 > 4) ? 0 : ss.CurrentPanel + 1);
   }


    public void GotoPrev(){
        ss.GoToPreviousPanel();
        PlayPauseVideo((ss.CurrentPanel - 1 < 0)? 4 : ss.CurrentPanel - 1);
   }

    public void PlayPauseVideo(int curVid)
    {
        for(int i = 0;i < 5; i++)
        {
            if(i != curVid)
            {
                Players[i].Stop();
            }
            else
            {
                Debug.Log("playing this" + curVid);
                Players[i].Play();
            }
        }
    }
}
