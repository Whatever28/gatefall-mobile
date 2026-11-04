using UnityEngine;
using UnityEngine.SceneManagement;

// Scene loading and panel visibility follow the teacher's Assignment 3 MenuButtons example.
public class UIFlow : MonoBehaviour
{
    public GameObject pausePanel;
    public void Play(){ Time.timeScale=1; MobileControls.ResetInput(); SceneManager.LoadScene("Game"); }
    public void Quit(){ Application.Quit(); Debug.Log("Quitting the game"); }
    public void SetPaused(bool paused)
    {
        pausePanel.SetActive(paused);
        Time.timeScale = paused ? 0f : 1f;
    }
    public void Pause(){ MobileControls.ResetInput(); SetPaused(true); }
    public void Resume(){ SetPaused(false); }
    public void Restart(){ Time.timeScale=1; MobileControls.ResetInput(); SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
    public void ToMenu(){ Time.timeScale=1; SceneManager.LoadScene("MainMenu"); }
    public void Menu(){ MobileControls.ResetInput(); ToMenu(); }
}

