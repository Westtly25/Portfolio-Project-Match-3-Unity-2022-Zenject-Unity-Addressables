using Zenject;
using Assets.Scripts.Runtime.Utilities;
using Assets.Scripts.Runtime.Save_System;
using Assets.Scripts.Runtime.Audio_System;
using CodeBase.Infrastructure.AssetManagement;
using System.IO;
using Assets.Scripts.Runtime.Input_System;

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

            Container.BindInterfacesAndSelfTo<AudioService>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<SaveHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<CoroutineRunner>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<Logger>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<FileHandler>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();

            Container.BindInterfacesAndSelfTo<InputService>()
                     .FromNew()
                     .AsSingle()
                     .NonLazy();
        }
    }
}