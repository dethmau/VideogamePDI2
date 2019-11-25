using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpend : MonoBehaviour
{
    public GameObject panel;
    public void panelOpen()
    {
        if(panel != null)
        {
            panel.SetActive(true);
        }
    }
}
