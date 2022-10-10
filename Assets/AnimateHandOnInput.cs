using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty indexAnimationAction;
    public InputActionProperty gripAnimationAction;
    public InputActionProperty PrimaryButtonAnimationAction;
    public Animator handAnimator;

    void Start()
    {

    }

    void Update()
    {
        float triggerValue = indexAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("indexAnimationAction", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);

        float PrimaryButtonValue = PrimaryButtonAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Thumb", PrimaryButtonValue);
    }
}
