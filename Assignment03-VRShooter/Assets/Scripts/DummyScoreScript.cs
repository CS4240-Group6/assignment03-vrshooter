using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyScoreScript : MonoBehaviour
{
    //1. Add public variable for canvas score counter UI
    private GameObject ScoreCounter;

    private GameObject ScorePanel;
    private Text ScarecrowScoreText;
    private Text FruitScoreText;

    private GameObject CircularProgressBar;
    private Image LoadingBar;
    private Image Center;
    private Text ProgressIndicator;
    private Text ProgressText;
   




    //2. Add private variable to keep track of:
    //How Many fruits thrown
    private int fruitThrown = 0;
    //How many scarecrows hit
    private int scarecrowHit = 0;
    //Constant of the total number of scarecrows
    public const int TOTALSCARECROW = 10;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCounter = GameObject.Find("Canvas");

        ScorePanel = ScoreCounter.transform.GetChild(0).gameObject;
        ScarecrowScoreText  = ScorePanel.transform.GetChild(0).GetComponent<Text>();
        FruitScoreText = ScorePanel.transform.GetChild(1).GetComponent<Text>();

        CircularProgressBar = ScorePanel.transform.GetChild(2).gameObject;
        LoadingBar = CircularProgressBar.transform.GetChild(0).GetComponent<Image>();
        Center = CircularProgressBar.transform.GetChild(1).GetComponent<Image>();
        ProgressIndicator = Center.transform.GetChild(0).GetComponent<Text>();
        ProgressText = Center.transform.GetChild(1).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCounter.SetActive(true);
        //3. Update variables here etc.
        if (scarecrowHit < TOTALSCARECROW)
        {
            fruitThrown++;
            scarecrowHit++;
        }

        /*
        //4. When button is clicked to show UI, Call update text method
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MOUSE BUTTON IS CLICKED");
            if (ScoreCounter.activeSelf)
            {
                Debug.Log("SCORE COUNTER IS ACTIVE, CALL REMOVEUI");
                removeUI();
            } else {
                Debug.Log("SCORE COUNTER IS NOT ACTIVE, CALL SHOWUI");
                showUI();
            }
                
        } */
        showUI();
    }

    
    void showUI()
    {
        ScoreCounter.SetActive(true);
        updateText();
        updateProgressBar();

    }

    void updateText()
    {
        FruitScoreText.text = ((int)fruitThrown).ToString();
        ScarecrowScoreText.text = ((int) scarecrowHit).ToString();
    }

    void updateProgressBar()
    {
       float progress = scarecrowHit / (float) TOTALSCARECROW;

        LoadingBar.fillAmount = progress;

        progress = progress * 100;
        ProgressIndicator.text = ((int)progress).ToString() + "%";

        if (progress >= 100)
            ProgressText.text = "Completed!";
    }

    void removeUI()
    {
       ScoreCounter.SetActive(false);
    }
    
}
