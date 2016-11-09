using System;
using Autofac.Util;

namespace Caliburn.Micro.Autofac
{
  /// <remarks>similar to Autofac.Util.ReleaseAction</remarks>
  public sealed class DisposableWrapper : Disposable
  {
    /// <exception cref="ArgumentNullException"><paramref name="action" /> is <see langword="null" />.</exception>
    public DisposableWrapper(System.Action action)
    {
      if (action == null)
      {
        throw new ArgumentNullException(nameof(action));
      }
      this.Action = action;
    }

    private System.Action Action { get; }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);

      if (disposing)
      {
        this.Action.Invoke();
      }
    }
  }
}
