using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Strelylka : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _dist1;

    private void Update()
    {
        transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y);

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
        if (col.CompareTag("Trigg"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
}
