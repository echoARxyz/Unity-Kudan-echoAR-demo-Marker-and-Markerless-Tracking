/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kudan.AR;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    static GameObject KudanCamera = GameObject.Find("Kudan Camera");
    static KudanTracker Tracker = KudanCamera.GetComponent<KudanTracker>();

    static GameObject Marker = GameObject.Find("Marker");
    static MarkerTransformDriver Driver = Marker.GetComponent<MarkerTransformDriver>();

    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        

        // Qurey additional data to get the name
        string value = "";
        
        

        TrackingMethodBase method = Tracker.CurrentTrackingMethod;
        if (method is TrackingMethodMarker) {
            this.gameObject.transform.rotation = Quaternion.Euler(-90,0,0);
        }
        else {
            this.gameObject.transform.rotation = Quaternion.Euler(0.0f, -25.0f, 90.0f);
        }

        if (entry.getAdditionalData().TryGetValue("imageKey", out value)) {
            Driver._expectedId = value;
        }

        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }

        


    }

    // Update is called once per frame
    void Update()
    {
        string value = "";

        if (entry.getAdditionalData().TryGetValue("imageKey", out value)) {
            Driver._expectedId = value;
        }

    }
}