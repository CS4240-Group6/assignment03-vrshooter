using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircularProgressBar : MonoBehaviour
{
    public Image LoadingBar;
    public Text ProgressIndicator;
    public Text ProgressText;

    int targetsShot = 10;
    int totalTargets = 20; //Insert the total number of scarecrow targets here
    float progress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress = targetsShot / (float) totalTargets;

        LoadingBar.fillAmount = progress;

        progress = progress * 100;
        ProgressIndicator.text = ((int)progress).ToString() + "%";

        if (progress >= 100)
            ProgressText.text = "Completed!";
    }
}
