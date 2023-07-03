using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject xWinCase;
    [SerializeField] private GameObject oWinCase;
    [SerializeField] private GameObject drawCase;

    private void Start()
    {
        if(xWinCase.activeSelf)
            xWinCase.SetActive(false);
        
        if(oWinCase.activeSelf)
            oWinCase.SetActive(false);
        
        if(drawCase.activeSelf)
            drawCase.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = GameManager.Instance.ScoreX + " : " + GameManager.Instance.ScoreO;

        if (GameManager.Instance.IsGameEnded)
        {
            switch (WinCheck.Instance.WinObject)
            {
                case "X(Clone)":
                    xWinCase.SetActive(true);
                    break;
                case "O(Clone)":
                    oWinCase.SetActive(true);
                    break;
                case "":
                    drawCase.SetActive(true);
                    break;
            }
        }
    }
}
