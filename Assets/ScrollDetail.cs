using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollDetail : MonoBehaviour
{
    public int curIndex = 0;
    public int TopIndex = 1;
    public int BottomIndex = 2;
    public int TopImageIndex = 0;
    public int BottomImageIndex = 2;
    public int totalPanels = 3;


    public void scrolldown(){
        BottomIndex = TopIndex;
        TopIndex -= 1;
        if(TopIndex < 0){
            TopIndex = totalPanels - 1;
            
        }
    }

    public void scrollup(){
        TopIndex = BottomIndex;
        BottomIndex += 1;
        if(BottomIndex == totalPanels){
            BottomIndex = 0;
            
        }
    }
}
