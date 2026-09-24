using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private Transform player;
    private Transform goal;
    public float winDistance = 1.5f;

    private bool hasWon = false;

    void Update()
    {
        goal = GameObject.Find("Goal").transform;
        player = GameObject.Find("Player").transform;

        if (hasWon) return;

        float distance = Vector3.Distance(player.position, goal.position);

        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }
    }

    void WinGame()
    {
        SceneManager.LoadScene("Win Screen");
    }
}
