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

    IEnumerator Start()
    {

        //WebXRManager webXRManager = new WebXRManager();
        yield return new WaitForSeconds(2f);

        if (WebXRManager.Instance.isActiveAndEnabled)
        {
            Debug.Log("Activado");
        }
        else
        {
            Debug.Log("Desactivado");
            //WebXRManager.OnXRChange();
        }
        //Debug.Log(webXRManager.XRState.ToString());
        //webXRManager.XRState.ToString();

    }


}
