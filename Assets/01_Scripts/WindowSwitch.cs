using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip explosionSound;
    public void PlayGame()
    {
        GameManager.instance.PlaySFX(explosionSound);
        StartCoroutine("espera");
        SceneManager.LoadScene("Level_1");
    }

    public void MainMenu()
    {
        GameManager.instance.PlaySFX(explosionSound);
        StartCoroutine("espera");
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        GameManager.instance.PlaySFX(explosionSound);
        StartCoroutine("espera");
        Application.Quit();
    }

    IEnumerator espera()
    {
        yield return new WaitForSeconds(2);
    }
}
