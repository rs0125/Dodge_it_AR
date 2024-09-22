using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnKumar : MonoBehaviour 
{

    public GameObject MyObject;
    public ARRaycastManager RaycastManager;
    public static bool spawn = false;
    public static GameObject cur;
    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !spawn)
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();

            RaycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

            
            cur = Instantiate(MyObject, touches[0].pose.position, touches[0].pose.rotation);
            spawn = true;   
            
        }
        
    }
}
