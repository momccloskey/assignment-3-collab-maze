using UnityEngine;

public class ForestMenu : MonoBehaviour
{
    public bool SetActive = false;
    public ForestMenu forestMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetActive = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            forestMenu.gameObject.SetActive(!forestMenu.gameObject.activeSelf);
        }
    }
}
