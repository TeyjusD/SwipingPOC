using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

public class ApiManager : MonoBehaviour
{
    
    public  TextAsset JsonResponse;
    public static Reel[] Reels;
    void Start()
    {
        //Account account = JsonConvert.DeserializeObject<Account>(json);
        Reels = JsonConvert.DeserializeObject<Reel[]>(JsonResponse.ToString());
        if(Reels != null)
        {
            SceneManager.LoadScene(1);
        }
    }

    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("api url");
        yield return www.SendWebRequest();

        if (www.isHttpError || www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);
        }
    }
}



