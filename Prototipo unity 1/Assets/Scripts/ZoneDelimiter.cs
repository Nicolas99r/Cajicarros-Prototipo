using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneDelimiter : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject zone;

    [SerializeField] GameObject letreroCarretera;

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
            LeanTween.scale(letreroCarretera, new Vector3(0.5f,0.5f,0.5f), 0.5f).setEaseInOutBack();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //UIObject.SetActive(false);
        LeanTween.scale(letreroCarretera, new Vector3(0f,0f,0f), 0.5f).setEaseInOutBack();
    }
}
