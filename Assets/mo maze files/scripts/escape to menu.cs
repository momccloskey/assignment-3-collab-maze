using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapetoMenu : MonoBehaviour
{
   void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
