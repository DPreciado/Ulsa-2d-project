using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   
   TextMeshProUGUI score;
   [SerializeField]
   int currentScore = 0;

   void Awake()
   {
       score = GetComponent<TextMeshProUGUI>();
   }

   public void AddPoints(int points)
   {
       currentScore += points;
       score.text = $"<b>Score:</b> <color=#ffff>{currentScore} pts</color>";
   }
}
