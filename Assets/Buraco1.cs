using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buraco1 : MonoBehaviour
{
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ball"))
        {
            player.position = new Vector3(98, 2, 38);
        }
    }
}
