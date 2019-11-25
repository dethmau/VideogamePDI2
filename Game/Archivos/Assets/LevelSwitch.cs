using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();

    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "siguiente")
        {
            SceneManager.LoadScene(0);
        }
    }

   

}
