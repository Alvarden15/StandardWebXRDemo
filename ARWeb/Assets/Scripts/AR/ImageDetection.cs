using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR.Interactions;
using WebXR;

public class ImageDetection : MonoBehaviour
{
    public Transform originTransform;
    public GameObject visual;
    private WebXRController leftController;
    private WebXRController rightController;

    private bool isFollowing = false;

    private Vector3 originPosition;
    private Quaternion originRotation;

    private Transform arCameraTransform;


    private void OnEnable()
    {
        isFollowing = false;

        WebXRManager.OnXRChange += HandleOnXRChange;
    }


    private void Awake()
    {
        


    }

    private void HandleOnXRChange(WebXRState state, int viewsCount, Rect leftRect, Rect rightRect)
    {
        WebXRManager.Instance.transform.localPosition = originPosition;
        WebXRManager.Instance.transform.localRotation = originRotation;
        isFollowing = false;
        if (state == WebXRState.AR)
        {
            WebXRManager.OnViewerHitTestUpdate += HandleOnViewerHitTestUpdate;
            WebXRManager.Instance.StartViewerHitTest();
        }
        else
        {
            WebXRManager.OnViewerHitTestUpdate -= HandleOnViewerHitTestUpdate;
        }
    }

    void HandleOnViewerHitTestUpdate(WebXRHitPoseData hitPoseData)
    {
        visual.SetActive(hitPoseData.available);
        if (hitPoseData.available)
        {
            isFollowing = true;
            transform.localPosition = hitPoseData.position;
            transform.localRotation = hitPoseData.rotation;
            //FollowByViewRotation(hitPoseData);
        }
    }

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
