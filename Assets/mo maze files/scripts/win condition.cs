using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private Transform player;
    private Transform goal;
    public float winDistance = 1.5f;

    private bool hasWon = false;

    void Update()
    {
        //i'm not quite sure if this counts as a trigger for the goal or if it's still technically a check of position
        //but it's literally the only thing that i could get to work after getting help
        //script is checking for the position of the objects named Goal and Player in the scene in order to do its thing
        //the player doesn't win if they touch the goal, for some reason there is a certain gap between the player and goal that counts as a win
        //so the goal object is placed a little far from where the actual win area is, but it works
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
        Debug.Log("splish splash you win");
    }
}
