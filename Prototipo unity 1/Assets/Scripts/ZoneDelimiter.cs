using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneDelimiter : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject zone;

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(false);
    }
}
