using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Rectrash")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Grewaste") 
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Genwaste")
        {
            Destroy(other.gameObject);
        }
    }

}
