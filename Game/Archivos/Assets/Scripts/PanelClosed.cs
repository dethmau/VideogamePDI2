using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClosed : MonoBehaviour
{
    public GameObject panel;
    public void panelClose()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
}
