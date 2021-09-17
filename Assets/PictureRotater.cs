using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureRotater : MonoBehaviour
{

   

    [SerializeField]
    private List<Sprite> cheem;

    public List<Image> Panels;
    public static int c=0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < Panels.Count;i++)  
        {  
            Panels[i].sprite = cheem[i];
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
