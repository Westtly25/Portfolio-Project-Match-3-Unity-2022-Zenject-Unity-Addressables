using Zenject;
using Assets.Scripts.Runtime.Data;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;
using Assets.Scripts.Runtime.State_Machine.Board_State_Machine;
using Assets.Scripts.Runtime.Pause;

namespace Assets.Scripts.Runtime.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BoardStateMachine>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.Bind<PlayerTurns>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.Bind<PlayerScore>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<PauseHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();
        }
    }
}
