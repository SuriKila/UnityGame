using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class ReloadLVL : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            StartCoroutine(Wait(0.4f));
        }
    }
    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(0.4f); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}