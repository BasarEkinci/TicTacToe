using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Order { get; set; }
    
    public int ScoreX { get; private set; }
    public int ScoreO { get; private set; }
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        Order = 0;
    }

    public void AddScoreToX()
    {
        ScoreX++;
    }
    
    public void AddScoreToO()
    {
        ScoreO++;
    }
    public void ChangeOrder()
    {
        if (Order == 1)
            Order = 0;
        else if (Order == 0)
            Order = 1;
    }
}
