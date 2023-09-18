using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset;
    public CinemachineVirtualCamera Camera;
   
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Camera.enabled = false;
        transform.position = new Vector3(player.transform.position.x, 0f, player.transform.position.z) + offset;
           
    }
   
}
