using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject Panel1;
    int counter;
    // Start is called before the first frame update
    public void showPanel()
    {
        counter++;
        if (counter%2 ==1)
        {
            Panel1.gameObject.SetActive(false);
        }
        else
        {
            Panel1.gameObject.SetActive(true);
        }
    }
    
}
