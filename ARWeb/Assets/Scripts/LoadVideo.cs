using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadVideo : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer player;

    [SerializeField]
    private string url;
    
    void Start()
    {
        //player.url = System.IO.Path.Combine(Application.streamingAssetsPath, video_name);
        //player.Play();
    }

}
