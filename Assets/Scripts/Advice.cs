using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Advice : MonoBehaviour
{
    TextMeshProUGUI text;
    [SerializeField]
    WarningMessage message;

    void Awake() {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {

            Debug.Log(message.Message);
            //text.text = message.Message;

        }    
    }
}
