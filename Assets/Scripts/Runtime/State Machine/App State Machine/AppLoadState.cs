using Assets.Scripts.Runtime.Save_System;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

public class AppLoadState : State
{
    private readonly SaveLoadHandler saveHandler;

    public bool IsComplete => saveHandler.IsLoaded;

    public AppLoadState(SaveLoadHandler saveHandler) =>
        this.saveHandler = saveHandler;

    public override void OnEnter()
    {
        base.OnEnter();

        saveHandler.LoadAsync();
    }
}