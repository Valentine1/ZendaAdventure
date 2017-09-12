using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public Teleporter exitTeleporter;
    public float exitOffset = 4.0f;

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Player>() != null)
        {
            if (exitTeleporter != null)
            {
                Player player = col.GetComponent<Player>();
                player.transform.position = exitTeleporter.transform.position + exitTeleporter.transform.forward * exitOffset;
            }
        }
    }
}
