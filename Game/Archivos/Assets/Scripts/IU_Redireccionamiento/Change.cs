using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject chara;
    public GameObject chara2;
    public GameObject chara3;
    public GameObject chara4;
    public void panelOpen()
    {
        if (chara != null)
        {
            chara.SetActive(true);
            chara2.SetActive(false);
            chara3.SetActive(false);
            chara4.SetActive(false);
        }
    }
}
