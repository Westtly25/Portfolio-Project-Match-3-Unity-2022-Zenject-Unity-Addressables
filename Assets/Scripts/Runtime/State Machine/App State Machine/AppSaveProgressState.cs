using UnityEngine;
using Assets.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

public class AppSaveProgressState : State
{
    private readonly SaveLoadHandler saveHandler;

    public AppSaveProgressState(SaveLoadHandler saveHandler) =>
        this.saveHandler = saveHandler;

    public override void OnEnter()
    {
        base.OnEnter();

        saveHandler.SaveAsync();
    }
}
