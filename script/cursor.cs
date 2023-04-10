using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
   void Start()
    {
        Debug.Log("Curseur desactiver");
        // Verrouiller le curseur à l'intérieur de la fenêtre de jeu
        Cursor.lockState = CursorLockMode.Locked;

        // Masquer le curseur
        Cursor.visible = false;
    }
}
