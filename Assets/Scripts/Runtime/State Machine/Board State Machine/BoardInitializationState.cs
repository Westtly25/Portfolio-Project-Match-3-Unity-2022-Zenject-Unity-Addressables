using Assets.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

namespace Assets.Scripts.Runtime.State_Machine.Board_State_Machine
{
    public class BoardInitializationState : State
    {
        private readonly PlayerTurns turns;
        private readonly PlayerScore score;
        private readonly LevelConfig level;

        public BoardInitializationState(PlayerTurns playerTurns, PlayerScore playerScore, LevelConfig level)
        {
            this.turns = playerTurns;
            this.score = playerScore;
            this.level = level;
        }
    }
}
