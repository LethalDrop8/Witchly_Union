using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMAnagerScript : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject startPanel;
    public GameObject registerPanel;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Llamar cuando el registro termine correctamente
    public void OnRegisterSuccess()
    {
        if (registerPanel != null) registerPanel.SetActive(false);
        if (startPanel != null) startPanel.SetActive(true);
    }
}
