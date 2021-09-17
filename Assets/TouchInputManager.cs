using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TouchInputManager : MonoBehaviour
{
    private const float DEADZONE = 200f;
   // public static touchInputs Instance { set; get; }

    private bool tap, swipeUp, swipeDown;
    private Vector2 swipeDelta, startTouch;

    /*public bool Tap { get { return tap; } }
    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public bool SwipeRight { get { return swipeRight; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeUp { get { return swipeUp; } }
    public bool SwipeDown { get { return swipeDown; } }*/

    public RawImage img;
    public float minspeed;
    public float currspeed = 0f;
    public float curpos = 0f;
    private float screenheight = Screen.height;
    private float startTime;

    private void Awake()
    {
       // Instance = this;
        startTouch = swipeDelta = Vector2.zero;
        Debug.Log(screenheight);
    }
    private void Update()
    {
        tap =  swipeUp = swipeDown = false;

       
        #region Mobile Inputs
        if (Input.touches.Length != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                startTouch = Input.touches[0].position;
                startTime = Time.time;
                Debug.Log("tapped(mobile)" + startTouch);
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                Debug.Log("lost");
                float endTime = Time.time;
                float duration = endTime - startTime;
                currspeed = (Input.touches[0].deltaPosition.y) / (Input.touches[0].deltaTime*screenheight);

                if (currspeed > minspeed)
                {                  
                    img.rectTransform.anchoredPosition = new Vector2(0, screenheight);
                }
                else if(currspeed < -1 * minspeed)
                {
                    img.rectTransform.anchoredPosition = new Vector2(0, -1*screenheight);

                }
                else if (swipeDelta.y >= 0.5)
                {
                    img.rectTransform.anchoredPosition = new Vector2(0, screenheight);

                }
                else if (swipeDelta.y < 0.5 && swipeDelta.y >0)
                {
                    img.rectTransform.anchoredPosition = new Vector2(0,0);

                }
                else if(swipeDelta.y<= -0.5)
                {
                    img.rectTransform.anchoredPosition = new Vector2(0, -1 * screenheight);

                }
                else if(swipeDelta.y>-0.5 && swipeDelta.y < 0)
                {
                    img.rectTransform.anchoredPosition = new Vector2(0, 0);

                }
                startTouch = swipeDelta = Vector2.zero;
            }
        }

        #endregion

        //calc dist
        swipeDelta = Vector2.zero;
        if (startTouch != Vector2.zero)
        {           
            if (Input.touches.Length != 0)
            {
                swipeDelta = (Input.touches[0].position - startTouch)/screenheight;
            }
            float y = swipeDelta.y;
            Debug.Log(y);

            currspeed = (Input.touches[0].deltaPosition.y) / (Input.touches[0].deltaTime * screenheight);

            if (y < 0f)
            {
                swipeDown = true;
                Debug.Log("swipe down");
            }
            else if(y > 0f)
            {
                swipeUp = true;
                Debug.Log("swipe up");
            }
            img.rectTransform.anchoredPosition = new Vector2(0f,y * screenheight);
        }

    }
}
