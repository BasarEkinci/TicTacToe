using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Order { get; private set; }
    private bool oneTime = false;

    public bool IsGameEnded = false;
    public bool IsGameDraw;
    public int ScoreX { get; private set; }
    public int ScoreO { get; private set; }
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        Order = Random.Range(0,2);
    }

    public void AddScoreToX()
    {
        if(!oneTime)
        {
            ScoreX++;
            IsGameEnded = true;
            oneTime = true;
        }
    }
    
    public void AddScoreToO()
    {
        if(!oneTime)
        {
            ScoreO++;
            IsGameEnded = true;
            oneTime = true;
        }
    }
    public void ChangeOrder()
    {
        if (Order == 1)
            Order = 0;
        else if (Order == 0)
            Order = 1;
    }
}
