using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    [SerializeField]
    private float displayTime = 4.0f;

    [SerializeField]
    private GameObject dialogBox;

    private float timerDisplay;

    private void Start()
    {
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;
    }

    private void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
    }
}