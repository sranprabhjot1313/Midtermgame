using UnityEngine;
using UnityEngine.SceneManagement;

public class Border : MonoBehaviour
{
    private bool gameOverShown = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball") && !gameOverShown)
        {
            Debug.Log("Game Over! Ball fell out of bounds.");
            gameOverShown = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
