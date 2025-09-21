using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == null) return;
        if (other.CompareTag("Player") || other.GetComponent<PlayerController>() != null)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.IncreaseScore();
                Debug.Log("ScoreTrigger activated by " + other.name);
            }
            else
            {
                Debug.LogWarning("GameManager.Instance is null. Make sure GameManager exists in the scene.");
            }
        }
    }
}
