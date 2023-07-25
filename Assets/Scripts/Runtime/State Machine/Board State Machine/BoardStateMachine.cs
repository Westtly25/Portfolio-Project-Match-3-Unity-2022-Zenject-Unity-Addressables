using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;
using Assets.Scripts.Runtime.Data;
using Assets.Scripts.Runtime.Pause;
using Zenject;

namespace Assets.Scripts.Runtime.State_Machine.Board_State_Machine
{
    public class BoardStateMachine : StateMachine, IPauseListener
    {
        private readonly PauseHandler pauseHandler;

        private bool isPaused = false;

        [Inject]
        public BoardStateMachine(PlayerTurns playerTurns,
                                 PlayerScore playerScore,
                                 PauseHandler pauseHandler)
        {
            this.pauseHandler = pauseHandler;

            State[] states =
            {
                //new BoardInitializationState(playerTurns, playerScore),
                new BoardPopulatingState(),
            };

            AddStates(states);
        }

        public override void Run()
        {
            if (isPaused)
                return;

            base.Run();
        }

        public void Pause(bool isPaused) =>
            this.isPaused = isPaused;
    }
}