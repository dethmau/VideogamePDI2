using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioWall : MonoBehaviour
{
    public GameObject wall;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public void panelOpen()
    {
        if (wall != null)
        {
            wall.SetActive(true);
            wall2.SetActive(false);
            wall3.SetActive(false);
            wall4.SetActive(false);
            wall5.SetActive(false);
        }
    }
}
