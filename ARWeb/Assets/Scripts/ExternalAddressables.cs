using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class ExternalAddressables : MonoBehaviour
{
    /*
     [SerializeField]
    private AssetReference modelReference;

    

     */

    [SerializeField]
    private string array;
    
    // Start is called before the first frame update
    void Start()
    {

        //StartCoroutine(CargarModelo());

        StartCoroutine(CargarNormal(array));
    }

    public async Task Cargar(string label)
    {

        var locations = await Addressables.LoadResourceLocationsAsync(label).Task;

        foreach(var location in locations)
        {
            await Addressables.InstantiateAsync(location).Task;
        }
        //modelReference.InstantiateAsync();


    }

    /*
    
     */

    IEnumerator CargarNormal(string label)
    {

        var locations = Addressables.LoadResourceLocationsAsync(label);

        yield return locations;

        if(locations.Status == AsyncOperationStatus.Succeeded)
        {
            foreach (var location in locations.Result)
            {
                Addressables.InstantiateAsync(location);
            }
        }
        else
        {
            Debug.Log("Error en la importacion");
        }

        //modelReference.InstantiateAsync();


    }

    IEnumerator CargarModelo()
    {
        var objetos = Addressables.LoadResourceLocationsAsync(array);
        var objeto = Addressables.LoadAssetAsync<GameObject>("Assets/Models/Column_3.fbx");
        //var objeto = Addressables.LoadAssetAsync<GameObject>("C:/Users/Computer/Documents/LocalModels/Column_3.fbx");
        yield return objeto;

        if(objeto.Status == AsyncOperationStatus.Succeeded)
        {
            Object.Instantiate(objeto.Result);
            Addressables.Release(objeto);
        }
        else
        {
            Debug.Log("Error en la importacion");
        }


    }
}
