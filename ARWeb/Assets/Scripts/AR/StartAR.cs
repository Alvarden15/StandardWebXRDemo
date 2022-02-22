using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.XR;
using WebXR;

public class StartAR : MonoBehaviour
{


    private void Awake()
    {
        /*
         if (WebXRManager.Instance.isSupportedAR)
        {
            WebXRManager.Instance.ToggleAR();
        }
        else
        {
            Debug.Log("Estandar");
        }
         */

    }

    void Start()
    {
        //WebXRManager.Instance.ToggleAR();



        //subsystem?.ToggleAR();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
