
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadAdmin : MonoBehaviour
{
    public void ReloadKnopka()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
