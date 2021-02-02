using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKamen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    void Update()
    {
       
        
            StartCoroutine(Wait(2f));
        
    }
    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(2f); // таймер, через 10 секунд
        Instantiate(enemy);
    }
}
