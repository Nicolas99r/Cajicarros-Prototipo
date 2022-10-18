using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPauseScript : MonoBehaviour
{
    public GameObject objetito;

    public void PointerEnter()
    {
        LeanTween.scale(objetito.GetComponent<RectTransform>(), new Vector3(0.2f, 0.2f, 0.2f), 0.3f);
    }

    public void PointerExit()
    {
        LeanTween.scale(objetito.GetComponent<RectTransform>(), new Vector3(0.1593416f, 0.1593416f, 0.1593416f), 0.3f);
    }
}
