using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLVLWater : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D()
    {
        StartCoroutine(Wait(0.3f));
    }

    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(0.3f); // таймер, через 10 секунд
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // выполнится эта строка
    }
}