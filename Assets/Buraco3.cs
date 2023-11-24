using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buraco3 : MonoBehaviour
{
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ball"))
        {
            player.position = new Vector3(66, 1, 53);
        }
    }
}
