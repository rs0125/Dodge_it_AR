using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class spawnkumar : MonoBehaviour 
{

    public GameObject MyObject;
    public ARRaycastManager RaycastManager;

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();

            RaycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

            
            Instantiate(MyObject, touches[0].pose.position, touches[0].pose.rotation);
            
        }
        
    }
}
