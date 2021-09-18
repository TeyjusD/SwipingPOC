using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{

    Vector2 startTouch;
    public float SpeedThreshold = 2f;
    public InputManager Im;
    public float currspeed;
    public ScrollDetail ss;
    public static bool isgoingup=false;
    public static bool isgoingdown=false;
    bool ismoving=false;
    public int c=0;
    void Start(){
        startTouch = Vector2.zero;
    }
    // Start is called before the first frame update
    void Update(){
        if(Input.touches.Length > 0){
            Touch t = Input.touches[0];
            currspeed = (t.deltaPosition.y) / (t.deltaTime * Screen.height);
            
            if(currspeed > SpeedThreshold && !isgoingup && c<20 && !ismoving){
                Im.GotoPrev();
                ss.scrolldown();
                isgoingup=true;
                ismoving=true;
                c++;
                //Debug.Log("moving down");

            }else if(currspeed < -1* SpeedThreshold && !isgoingdown && c>0 && !ismoving){
                        
                Im.GotoNext();
                ss.scrollup();
                isgoingdown = true;
                ismoving=true;
                c--;
                //Debug.Log("moving up");
            }

            if(t.phase == TouchPhase.Ended){
                ismoving=false;
            }
            // if(t.deltaPosition.y){

            // }

            
        }
    }
}
