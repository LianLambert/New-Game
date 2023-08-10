using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    private float secondsCount;
    private int minutesCount;
    private int hoursCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }

    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", hoursCount, minutesCount, secondsCount);

        if (secondsCount >= 60)
        {
            minutesCount++;
            secondsCount = 0;
        }
        else if (minutesCount >= 60)
        {
            hoursCount++;
            minutesCount = 0;
        }
    }


}
