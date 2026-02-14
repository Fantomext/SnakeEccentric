using Player;
using VContainer;
using VContainer.Unity;

public class LevelLifeTimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        base.Configure(builder);
        
        builder.RegisterComponentInHierarchy<PlayerCamera>();
    }
}
