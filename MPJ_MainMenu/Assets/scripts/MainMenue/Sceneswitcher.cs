using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneswitcher : MonoBehaviour
{
    public string gameChoose = "GameChosse";
    public string Settings = "Settings";
    public string CharacterSelect = "CharacterChoose";
    public string BacktoMenu = "MainMenu";
    public string RocketRun = "RocketRun";
    public string MciJump = "MciJump";

    public void PlayGame()
    {
        SceneManager.LoadScene(gameChoose);
    }

    public void back()
    {
        SceneManager.LoadScene(BacktoMenu);
    }

    public void Characterselection()
    {
        SceneManager.LoadScene(CharacterSelect);
    }

    public void CharacterselectionExit()
    {
        SceneManager.LoadScene(BacktoMenu);
    }

    public void settings()
    {
        SceneManager.LoadScene(Settings);
    }

    public void SettingsExit()
    {
        SceneManager.LoadScene(BacktoMenu);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void RocketRunEntry()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Rucket Run load");
    }

    public void MciJumpEntry()
    {
        SceneManager.LoadScene(MciJump);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
