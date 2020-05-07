using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;
public class LightController : MonoBehaviour
{
    public VRTK.Controllables.ArtificialBased.VRTK_ArtificialRotator rotator;
    public Light light;

    private bool hasBeenActivated = false;


    protected virtual void OnEnable()
    {
        rotator = (rotator == null ? GetComponent<VRTK.Controllables.ArtificialBased.VRTK_ArtificialRotator>() : rotator);
        rotator.ValueChanged += ValueChanged;
        rotator.MaxLimitReached += MaxLimitReached;
        rotator.MinLimitReached += MinLimitReached;
    }

    protected virtual void ValueChanged(object sender, ControllableEventArgs e)
    {
        //TODO sound ?
        // Debug.Log(rotator.GetValue());
    }

    protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
    {
        light.intensity = 0;
        this.hasBeenActivated = true;

    }

    protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
    {
        if (hasBeenActivated) {
            this.rotator.SetAngleTarget(0);
            this.rotator.isLocked = true;
        }
        light.intensity = 1;
    }

}
