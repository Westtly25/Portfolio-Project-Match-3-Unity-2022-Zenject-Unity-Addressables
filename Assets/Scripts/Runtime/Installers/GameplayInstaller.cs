using Zenject;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;
using Assets.Scripts.Runtime.Data;

namespace Assets.Scripts.Runtime.Installers
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<StateMachine>()
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
        }
    }
}
