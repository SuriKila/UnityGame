using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Trigg"))
        {
            StartCoroutine(Wait(0.2f));
        }
        
    }

    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(0.2f); // таймер, через 10 секунд
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // выполнится эта строка
    }
}
