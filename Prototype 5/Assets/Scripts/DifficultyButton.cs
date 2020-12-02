using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    public int difficulty;
    
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        // Deactive Title Screen
        transform.parent.gameObject.SetActive(false);

        Debug.Log(button.gameObject.name + " was clicked!");
        gameManager.StartGame(difficulty);
    }
}
