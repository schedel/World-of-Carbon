﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarbonDisplay : MonoBehaviour {

    private Text text;
    private string displayText;
    private int numOfCarbons;

    //TODO: CHANGE TO FORMULA
	// Use this for initialization
	void Start () {
        text = gameObject.GetComponent<Text>();

        displayText = "Formula: ";
        numOfCarbons = 1;
        updateDisplay();
	}

    private void updateDisplay()
    {
        text.text = displayText + numOfCarbons;
    }
	
	public void setNumOfCarbons(int numOfCarbons)
    {
        this.numOfCarbons = numOfCarbons;
        updateDisplay();
    }
}
