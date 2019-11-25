using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarescena : MonoBehaviour
{
    // Start is called before the first frame update
    public void cambiar(string LevelIntro)
    {

        SceneManager.LoadScene(1);
    }
}
