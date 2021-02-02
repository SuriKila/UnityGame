using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private Animator _anim;


    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //_anim.SetBool("Des", true);

        Destroy(GetComponent<BoxCollider2D> (), 1.2f);
        Destroy(gameObject, 2);
        StartCoroutine(Wait(0.3f));
        

    }
    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(0.2f); 
        _anim.SetBool("Des", true);
        
        

        
    }
   
}
