using UnityEngine;

public class Victory : MonoBehaviour
{
    private bool hasWon = false;

    void Update()
    {
        if (!hasWon && GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            Debug.Log("Victory! All bricks destroyed!");
            hasWon = true;
        }
    }
}
