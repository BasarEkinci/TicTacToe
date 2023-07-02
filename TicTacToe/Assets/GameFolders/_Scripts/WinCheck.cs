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
        CheckWin();
    }

    void CheckWin()
    {
        //Rows
        if (areaArray[0, 0].name == areaArray[0, 1].name && areaArray[0, 0].name == areaArray[0, 2].name)
        {
            Debug.Log(areaArray[0,0].name.ToUpper() + "Win the game");
        }
        if (areaArray[1, 0].name == areaArray[1, 1].name && areaArray[1, 0].name == areaArray[1, 2].name)
        {
            Debug.Log(areaArray[1,0].name.ToUpper() + "Win the game");
        }
        if (areaArray[2, 0].name == areaArray[2, 1].name && areaArray[2, 0].name == areaArray[2, 2].name)
        {
            Debug.Log(areaArray[2,0].name.ToUpper() + "Win the game");
        }
        
        
        //Columns
        if (areaArray[0, 0].name == areaArray[1, 0].name && areaArray[0, 0].name == areaArray[2, 0].name)
        {
            Debug.Log(areaArray[0,0].name.ToUpper() + "Win the game");
        }
        if (areaArray[0, 1].name == areaArray[1, 1].name && areaArray[0, 0].name == areaArray[2, 1].name)
        {
            Debug.Log(areaArray[0,1].name.ToUpper() + "Win the game");
        }
        if (areaArray[0, 2].name == areaArray[1, 2].name && areaArray[0, 2].name == areaArray[2, 2].name)
        {
            Debug.Log(areaArray[2,2].name.ToUpper() + "Win the game");
        }
        
        //Cross
        if (areaArray[0, 0].name == areaArray[1, 1].name && areaArray[0, 0].name == areaArray[2, 2].name)
        {
            Debug.Log(areaArray[2,2].name.ToUpper() + "Win the game");
        }
        if (areaArray[0, 2].name == areaArray[1, 1].name && areaArray[0, 2].name == areaArray[2, 0].name)
        {
            Debug.Log(areaArray[0,2].name.ToUpper() + "Win the game");
        }        
        
    }
}
