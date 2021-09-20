using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureRotater : MonoBehaviour
{

   

    [SerializeField]
    private List<Texture> cheem;

    public List<RawImage> Panels;
    public List<RawImage> OrderedPanels;
    public  int topImageIndex = 0;
    public  int bottomImageIndex = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("testing git");
        topImageIndex = -2;
        bottomImageIndex = Panels.Count - 3;
        for(int i = 0;i < OrderedPanels.Count;i++)  
        {  
            OrderedPanels[i].texture = cheem[i];
        }
        
    }

    public  int GetTopIndex(){
        return topImageIndex;
    }

    public  int GetBottomIndex(){
        return bottomImageIndex;
    }

    public  void IncTop(){
        topImageIndex += 1;
    }

    public  void IncBottom(){
        bottomImageIndex += 1;
    }

    public  void decTop(){
        topImageIndex -= 1;
    }

    public  void decBot(){
        bottomImageIndex -= 1;
    }

    public void changeTex(int PanelIndex, int ImageIndex){
        if(PanelIndex < 0 || ImageIndex < 0)return;
        Panels[PanelIndex].texture = cheem[ImageIndex];
    }
    
}
