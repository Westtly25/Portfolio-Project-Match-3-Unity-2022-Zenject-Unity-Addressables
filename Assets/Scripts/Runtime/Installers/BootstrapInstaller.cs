using Zenject;
using Assets.Scripts.Runtime.Save_System;
using CodeBase.Infrastructure.AssetManagement;

namespace Assets.Scripts.Runtime.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<AssetProvider>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<SaveHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();
        }
    }
}
