using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CargarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public void siguiente()
    {
        SceneManager.LoadScene(1);
    }
    
}
