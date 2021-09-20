using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DanielLochner.Assets.SimpleScrollSnap;

public class TouchScript : MonoBehaviour
{

    Vector2 startTouch;
    public float SpeedThreshold = 2f;
    public InputManager Im;
    public float currspeed;
    public static bool isgoingup=false;
    public static bool isgoingdown=false;
    bool ismoving=false;
    public int c=0;
    public int maxsize = 20;

    void Start(){
        maxsize = ApiManager.Reels.Length - 1;
        startTouch = Vector2.zero;
    }
    // Start is called before the first frame update
    void Update(){
        if(Input.touches.Length > 0){
            Touch t = Input.touches[0];
            currspeed = (t.deltaPosition.y) / (t.deltaTime * Screen.height);
            
            if(currspeed > SpeedThreshold && !isgoingup && c<maxsize && !ismoving){
                Im.GotoPrev();
                isgoingup=true;
                ismoving=true;
                c++;
                Debug.Log("moving down" + c);

            }else if(currspeed < -1* SpeedThreshold && !isgoingdown && c>0 && !ismoving){
                        
                Im.GotoNext();
                isgoingdown = true;
                ismoving=true;
                c--;
            }

            if(t.phase == TouchPhase.Ended){
                ismoving=false;
            }

            
        }
    }
}
