using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestWinCon : MonoBehaviour
{
    private Transform player;
    private Transform sun;
    private float winDistance = 1.5f;
    private bool hasWon = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("welcome to forest");
    }

    // Update is called once per frame
    void Update()
    {
        sun = GameObject.Find("Sun").transform;
        player = GameObject.Find("Player").transform;

        if (hasWon) return;

        float distance = Vector3.Distance(player.position, sun.position);

        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }
    }


void WinGame()
    {
        Debug.Log("You Win!");
        SceneManager.LoadScene("seal maze game");
    }
}


