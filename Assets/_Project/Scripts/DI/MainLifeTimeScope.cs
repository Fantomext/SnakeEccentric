using _Game.Scripts.Helpers;
using _Game.Scripts.Helpers.DI;
using Helpers;
using Player;
using VContainer;
using VContainer.Unity;

public class MainLifeTimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<MainEntryPoint>();
        
        builder.Register<SceneLoader>(Lifetime.Singleton);
        builder.Register<InputHandler>(Lifetime.Singleton);

    }
}
