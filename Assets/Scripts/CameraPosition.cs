using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject player;
    void LateUpdate()
    {
        this.transform.LookAt(player.transform);
    }
}
