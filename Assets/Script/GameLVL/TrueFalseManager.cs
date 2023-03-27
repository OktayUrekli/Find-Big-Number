using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueFalseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject trueIcon, falseIcon;

    GameManager gameManager;

    void Start()
    {
        ScaleKapat();
    }

    public void IconAc(bool tfKontrol)
    {
        if (tfKontrol)
        {
            trueIcon.GetComponent<RectTransform>().localScale = Vector3.one;
            falseIcon.GetComponent<RectTransform>().localScale=Vector3.zero;
        }
        else
        {
            falseIcon.GetComponent<RectTransform>().localScale = Vector3.one;
            trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        Invoke("ScaleKapat", 0.3f);
    }

    public void ScaleKapat()
    {
        trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
        falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
    }

   

}
