using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft;

public class LoadExternalModels : MonoBehaviour
{

    string filepath;

    private void Awake()
    {
        filepath = "file://C:/Users/Computer/Documents/LocalModels/Column_3.fbx";
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(filepath);

        yield return www.SendWebRequest();

        //var down = www.downloadHandler;
        
        if (www.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Ok, esta es la tonteria que descargue: "+ www.downloadHandler.text);

            //www.downloadHandler.data;
            //Debug.Log(file.name);

            //IMPORTANTE: Este script estara ahi por mientras hasta que sea posible convertir en tiempo real bytes a gameobject.
            //Es muy distinto convertir texto o imagenes que modelos 3d.
        }
        else
        {
            Debug.Log("No se encontro nada porque" + www.error);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
