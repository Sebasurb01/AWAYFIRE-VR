using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string FUEGO)
    {
        SceneManager.LoadScene(FUEGO);
    }
}
