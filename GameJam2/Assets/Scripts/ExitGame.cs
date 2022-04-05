
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void SalirJuego()
    {
        Application.Quit();
        Debug.Log("Saliendo...");
    }
}