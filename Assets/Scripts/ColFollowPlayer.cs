using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ColFollowPlayer : MonoBehaviour
{
    public XROrigin xrOrigin;
    private CharacterController collider;

    void Start()
    {
        collider = GetComponent<CharacterController>();
    }

    void Update()
    {
        var center = xrOrigin.CameraInOriginSpacePos;
        collider.center = new Vector3(center.x, collider.center.y, center.z);
    }
}
