using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorHandler : AnimatorHandler
{

    #region Initialization

    protected override void Awake()
    {
        base.Awake();
    }

    #endregion

    public void SetRruning(bool setTo)
    {
        myAnimator.SetBool(myAnimtorParameters[0].name, setTo);
    }

}