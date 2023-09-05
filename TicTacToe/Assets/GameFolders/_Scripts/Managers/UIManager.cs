using TicTacToe.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        scoreText.text = PlayerPrefs.GetInt("ScoreX") + " : " + PlayerPrefs.GetInt("ScoreO");

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

    public void RestartButton()
    {
        GameManager.Instance.IsGameEnded = false;
        SceneManager.LoadScene(1);
    }
}
