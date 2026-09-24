using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoTitle : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
