using System;
using DG.Tweening;
using UnityEngine;

namespace TicTacToe.Animations
{
    public class UIAnimation : MonoBehaviour
    {
        private void OnEnable()
        {
            transform.DOScale(Vector3.one,0.5f).From(Vector3.zero);
        }
    }    
}


