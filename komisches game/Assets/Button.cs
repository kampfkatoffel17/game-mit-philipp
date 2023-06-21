using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string sceneName; // Name der Szene, die neu gestartet werden soll

    private void Start()
    {
        // Hinzufügen eines Listeners für den Button-Klick
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ResetScene);
    }

    private void ResetScene()
    {
        SceneManager.LoadScene(sceneName); // Szene neu laden
    }
}
