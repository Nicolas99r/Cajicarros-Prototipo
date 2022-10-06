using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    [SerializeField] GameObject buttonPlay;
    [SerializeField] GameObject maderita;
    [SerializeField] GameObject letra1;
    [SerializeField] GameObject letra2;
    [SerializeField] GameObject letra3;
    [SerializeField] GameObject letra4;
    [SerializeField] GameObject letra5;
    [SerializeField] GameObject letra6;
    [SerializeField] GameObject letra7;
    [SerializeField] GameObject letra8;
    [SerializeField] GameObject letra9;
    [SerializeField] GameObject letra10;

    // Start is called before the first frame update
    void Start()
    {
        //ANIMACIÓN MADERA
        LeanTween.scale(maderita, new Vector3(0.5703332f, 0.346726f, 0.6253173f), 1f).setEaseOutElastic().setDelay(0.5f);

        //ANIMACIÓN LETRAS INDIVIDUALES
        LeanTween.moveY(letra1.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(0.5f);
        LeanTween.moveY(letra2.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(0.8f);
        LeanTween.moveY(letra3.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(1.1f);
        LeanTween.moveY(letra4.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(1.4f);
        LeanTween.moveY(letra5.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(1.7f);
        LeanTween.moveY(letra6.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(2f);
        LeanTween.moveY(letra7.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(2.3f);
        LeanTween.moveY(letra8.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(2.6f);
        LeanTween.moveY(letra9.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(2.9f);
        LeanTween.moveY(letra10.GetComponent<RectTransform>(), 107.76f, 2f).setEaseOutElastic().setDelay(3.2f);

        //ANIMACIÓN BOTÓN PLAY
        LeanTween.scale(buttonPlay, new Vector3(0.8f, 0.8f, 0.8f), 1f).setEaseInOutCubic().setLoopPingPong().setDelay(3.5f);
        LeanTween.moveX(buttonPlay.GetComponent<RectTransform>(), -117f, 1.5f).setEaseOutElastic().setDelay(3.5f);
    }

}
