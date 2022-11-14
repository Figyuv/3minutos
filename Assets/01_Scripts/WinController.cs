using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinController : MonoBehaviour
{
    public Animator anim;
    public AudioClip sfx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level_2");
            Debug.Log("You Win");
        }

        if (other.gameObject.CompareTag("Pato"))
        {
            SceneManager.LoadScene("Level_3");
            Debug.Log("You Win");
        }
    }
}
