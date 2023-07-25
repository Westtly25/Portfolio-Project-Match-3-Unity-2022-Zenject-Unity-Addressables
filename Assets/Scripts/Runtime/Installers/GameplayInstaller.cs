using Zenject;
using Assets.Code.Scripts.Runtime.State_Machine.StateMachine;

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
        }
    }
}
