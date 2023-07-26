using UnityEngine;
using Assets.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

public class BoardWaitingPlayerTurnState : State
{
    private readonly PlayerTurns turnsData;

    public int AvailableTurns => turnsData.Turns;

    public BoardWaitingPlayerTurnState(PlayerTurns turnsData) =>
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
