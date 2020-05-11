using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;

public class TrapController : MonoBehaviour
{
    public VRTK.Controllables.ArtificialBased.VRTK_ArtificialRotator rotator;
    public GameObject trap = null;


    protected virtual void OnEnable()
    {
        rotator = (rotator == null ? GetComponent<VRTK.Controllables.ArtificialBased.VRTK_ArtificialRotator>() : rotator);
        rotator.MaxLimitReached += MaxLimitReached;
    }

    protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
    {
        this.trap.transform.Rotate(new Vector3(-160.0f, 0.0f, 0.0f));
        this.rotator.isLocked = true;
    }
}
