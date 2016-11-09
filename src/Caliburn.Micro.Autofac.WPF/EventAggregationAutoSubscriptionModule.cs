using Autofac;
using Autofac.Core;

namespace Caliburn.Micro.Autofac
{
  public class EventAggregationAutoSubscriptionModule : Module
  {
    protected override void AttachToComponentRegistration(IComponentRegistry registry,
                                                          IComponentRegistration registration)
    {
      if (registration.Activator.LimitType.IsAssignableTo<IHandle>())
      {
        registration.Activated += (sender,
                                   args) =>
                                  {
                                    var instance = args.Instance;

                                    var context = args.Context;
                                    var lifetimeScope = context.Resolve<ILifetimeScope>();
                                    var eventAggregator = lifetimeScope.Resolve<IEventAggregator>();

                                    eventAggregator.Subscribe(instance);

                                    var disposableWrapper = new DisposableWrapper(() =>
                                                                                  {
                                                                                    eventAggregator.Unsubscribe(instance);
                                                                                  });

                                    lifetimeScope.Disposer.AddInstanceForDisposal(disposableWrapper);
                                  };
      }
    }
  }
}
