using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    [SerializeField] List<GameObject> areaList;

    private GameObject[,] areaArray = new GameObject[3, 3];

    private void Start()
    {
        for (int i = 0; i < areaArray.GetLength(0); i++)
        {
            for (int j = 0; j < areaArray.GetLength(1); j++)
            {
                if(i == 0)
                    areaArray[i, j] = areaList[j];
                else if (i == 1)
                    areaArray[i, j] = areaList[j + 3];
                else if(i == 2)
                    areaArray[i, j] = areaList[j + 6];
            }
        }
    }

    private void Update()
    {
        if(CheckWinObject() == "O(Clone)")
            GameManager.Instance.AddScoreToO();
        else if(CheckWinObject() == "X(Clone)")
            GameManager.Instance.AddScoreToX();
        
    }

    private string CheckWinObject()
    {
        string winObject = "";
        //Rows
        if (areaArray[0, 0].name == areaArray[0, 1].name && areaArray[0, 0].name == areaArray[0, 2].name)
        {
            winObject = areaArray[0, 0].name;
        }
        if (areaArray[1, 0].name == areaArray[1, 1].name && areaArray[1, 0].name == areaArray[1, 2].name)
        {
            winObject = areaArray[0, 0].name;
        }
        if (areaArray[2, 0].name == areaArray[2, 1].name && areaArray[2, 0].name == areaArray[2, 2].name)
        {
            winObject = areaArray[0, 0].name;
        }
        
        
        //Columns
        if (areaArray[0, 0].name == areaArray[1, 0].name && areaArray[0, 0].name == areaArray[2, 0].name)
        {
            winObject = areaArray[0, 0].name;
        }
        if (areaArray[0, 1].name == areaArray[1, 1].name && areaArray[0, 0].name == areaArray[2, 1].name)
        {
            winObject = areaArray[0, 0].name;
        }
        if (areaArray[0, 2].name == areaArray[1, 2].name && areaArray[0, 2].name == areaArray[2, 2].name)
        {
            winObject = areaArray[0, 0].name;
        }
        
        //Cross
        if (areaArray[0, 0].name == areaArray[1, 1].name && areaArray[0, 0].name == areaArray[2, 2].name)
        {
            winObject = areaArray[0, 0].name;
        }
        if (areaArray[0, 2].name == areaArray[1, 1].name && areaArray[0, 2].name == areaArray[2, 0].name)
        {
            winObject = areaArray[0, 0].name;
        }

        return winObject;

    }
}
