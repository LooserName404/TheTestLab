using Rudder.Input;
using Rudder.Physics;
using Rudder.Wrappers;
using UnityEngine;
using Zenject;

namespace Rudder
{
    public class RudderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Camera>().FromInstance(Camera.main);
            Container.Bind<Canvas>().FromInstance(FindObjectOfType<Canvas>());
            Container.Bind<RudderInputSystem>().FromNew().AsSingle();
            Container.Bind<RudderInputHandler>().FromNew().AsSingle();
            Container.Bind<IGetRenderMode>().To<GetRenderMode>().AsSingle().Lazy();
            Container.Bind<IGetWorldToScreenPoint>().To<GetWorldToScreenPoint>().AsSingle().Lazy();
            Container.Bind<RudderScreenPositionHandler>().FromNew().AsSingle().Lazy();
            Container.Bind<AngleCalculator>().FromNew().AsSingle();
        }
    }
}