using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixar_Mao : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        this.transform.parent = other.transform;
        this.transform.localPosition = new Vector3(0, 0, 0);
        this.transform.localRotation = Quaternion.identity;
        this.GetComponent<Rigidbody>().isKinematic = true;
    }
}

}
