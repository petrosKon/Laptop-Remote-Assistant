using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    [Header("Properties")]
    public ButtonConfigHelper buttonConfigHelper;
    public Animator platonicAnimator;
    public int maximumSteps = 10;

    private int stepsCounter = 0;
    private readonly string animator_trigger_name = "Animation";
    
    public void MoveToNext()
    {
        if(stepsCounter < maximumSteps)
        {
            stepsCounter++;
        }

        platonicAnimator.SetTrigger(animator_trigger_name + " " + stepsCounter.ToString());
        buttonConfigHelper.MainLabelText = stepsCounter.ToString() + "/" + maximumSteps.ToString();
        Debug.Log("Pushed");
    }

    public void MoveToPrevious()
    {
        if(stepsCounter != 0)
        {
            stepsCounter--;
        }
        platonicAnimator.SetTrigger(animator_trigger_name + " " + stepsCounter.ToString());
        buttonConfigHelper.MainLabelText = stepsCounter.ToString() + "/" + maximumSteps.ToString();
    }
}
