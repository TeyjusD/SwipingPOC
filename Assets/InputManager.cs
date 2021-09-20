using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;

public class InputManager : MonoBehaviour
{
   [SerializeField]
   private SimpleScrollSnap ss;

    //new change 1

   public  void GotoNext(){
       ss.GoToNextPanel();       
   }


    public void GotoPrev(){
        ss.GoToPreviousPanel();
   }
}
