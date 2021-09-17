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

    void Start(){
        startTouch = Vector2.zero;
    }
    // Start is called before the first frame update
    void Update(){
        if(Input.touches.Length > 0){
            Touch t = Input.touches[0];
            currspeed = (t.deltaPosition.y) / (t.deltaTime * Screen.height);

            if(currspeed > SpeedThreshold){
                Im.GotoPrev();
                ss.scrolldown();
                //Debug.Log("moving down");

            }else if(currspeed < -1* SpeedThreshold){
                        
                Im.GotoNext();
                ss.scrollup();
                //Debug.Log("moving up");
            }

            
        }
    }
}
