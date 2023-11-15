using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    private static ControladorJogador _instance;
    public static ControladorJogador Instance { get { return _instance; } }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TpPara(Vector3 position)
    {
        // Placeholder teleportation logic
        transform.position = position;
        Debug.Log("Teletransportado para: " + position);
        // You can add more logic here, like disabling controls during teleportation.
    }
}
