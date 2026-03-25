using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public void jugarConAnimacion(BotonSpriteAnimado boton)
{
    boton.OnPointerClick(null);
}

    public void salir()
    {
        Application.Quit();
    }
}
