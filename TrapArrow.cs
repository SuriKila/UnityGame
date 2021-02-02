using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapArrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    private void Start()
    {
        Instantiate(enemy);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Instantiate(enemy);
        

        

    }
}
