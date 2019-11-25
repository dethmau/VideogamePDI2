using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiaImagen : MonoBehaviour
{
    public Image iuImage;
    // Start is called before the first frame update
    void Start()
    {
        iuImage = GameObject.Find("Character_Main").GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            iuImage.sprite = Resources.Load<Sprite>("Character/Es_1");

        }
        if (Input.GetKeyDown("w"))
        {
            iuImage.sprite = Resources.Load<Sprite>("Character/Es_3");

        }
    }
}
