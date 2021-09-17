using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;

public class InputManager : MonoBehaviour
{
   [SerializeField]
   private SimpleScrollSnap ss;

   public  void GotoNext(){
       ss.GoToNextPanel();       
   }


    public void GotoPrev(){
        ss.GoToPreviousPanel();
   }
}
