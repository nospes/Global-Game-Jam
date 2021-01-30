using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;


    public void LoadNextLevel(int roomchangen)
    {
        StartCoroutine(LoadLevel(roomchangen));
    }

    IEnumerator LoadLevel(int actualroom)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(actualroom);
    }

}