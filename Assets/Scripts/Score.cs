using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   [SerializeField]
   Text score;
   [SerializeField]
   int currentScore = 0;

   void Awake()
   {
       score = GetComponent<Text>();
   }

   public void AddPoints(int points)
   {
       currentScore += points;
       score.text = $"Score: {currentScore} points";
   }
}
