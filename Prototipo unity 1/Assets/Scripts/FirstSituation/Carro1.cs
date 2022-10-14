using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro1 : MonoBehaviour
{
    public GameObject carroMonstruo;
    public GameObject carroRojo;
    public GameObject carroSemaforo;

    public float time = 15f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            carroMonstruo.SetActive(true);
            LeanTween.moveX(carroMonstruo, 52f, time);

            carroRojo.SetActive(true);
            LeanTween.moveX(carroRojo, -10f, time);

            carroSemaforo.SetActive(true);
            LeanTween.moveX(carroSemaforo, -4f, 10f).setEaseOutSine().setDelay(1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
