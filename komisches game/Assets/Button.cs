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
    
    public KeyCode resetKey;  // Tastencode zum Auslösen des Neustarts

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();  // Szene neu starten, wenn die entsprechende Taste gedrückt wird
        }
    }
    
    
    private void ResetScene()
    {
        SceneManager.LoadScene(sceneName); // Szene neu laden
        playerController.Leben = 5; //Leben werden resettet
    }
}
