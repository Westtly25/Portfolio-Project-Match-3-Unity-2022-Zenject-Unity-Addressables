using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;
using Assets.Scripts.Runtime.Data;
using Zenject;

namespace Assets.Scripts.Runtime.State_Machine.Board_State_Machine
{
    public class BoardStateMachine : StateMachine
    {
        [Inject]
        public BoardStateMachine(PlayerTurns playerTurns, PlayerScore playerScore)
        {
            State[] states =
            {
                new BoardInitializationState(playerTurns, playerScore),
                new BoardPopulatingState(),
            };

            AddStates(states);
        }
    }
}