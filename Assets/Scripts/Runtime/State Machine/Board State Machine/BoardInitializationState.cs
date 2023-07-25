using Assets.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

namespace Assets.Scripts.Runtime.State_Machine.Board_State_Machine
{
    public class BoardInitializationState : State
    {
        private readonly PlayerTurns turns;
        private readonly PlayerScore score;

        public BoardInitializationState(PlayerTurns playerTurns, PlayerScore playerScore)
        {
            this.turns = playerTurns;
            this.score = playerScore;
        }
    }
}
