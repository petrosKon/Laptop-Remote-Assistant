using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    public ButtonConfigHelper buttonConfigHelper;
    public int maximumSteps = 10;

    private int stepsCounter = 1;
    private int firstStep = 1;
    
    public void MoveToNext()
    {
        if(stepsCounter < maximumSteps)
        {
            stepsCounter++;
        }
        buttonConfigHelper.MainLabelText = stepsCounter.ToString() + "/" + maximumSteps.ToString();
        Debug.Log("Pushed");
    }

    public void MoveToPrevious()
    {
        if(stepsCounter != firstStep)
        {
            stepsCounter--;
        }
        buttonConfigHelper.MainLabelText = stepsCounter.ToString() + "/" + maximumSteps.ToString();
    }
}
