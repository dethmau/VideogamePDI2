using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarSkin : MonoBehaviour
{
    public GameObject obj;
    public GameObject Skin;

    public void panelOpen()
    {
        if (obj != null)
        {
            Skin.SetActive(true);
            obj.SetActive(false);
            
        }
    }
}
