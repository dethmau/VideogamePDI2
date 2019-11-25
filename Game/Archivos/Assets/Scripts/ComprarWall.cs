using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarWall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject wall;

    public void cambiar()
    {
        if (obj != null)
        {
            wall.SetActive(true);
            obj.SetActive(false);

        }
    }
}
