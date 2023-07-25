using UnityEngine;
using Assets.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

public class BoardWaitingState : State
{
    private readonly PlayerTurns turnsData;

    public BoardWaitingState(PlayerTurns turnsData) =>
        this.turnsData = turnsData;

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnRun()
    {
        base.OnRun();
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}