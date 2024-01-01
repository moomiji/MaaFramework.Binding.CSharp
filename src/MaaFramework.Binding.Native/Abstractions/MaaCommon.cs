﻿using MaaFramework.Binding.Interop.Native;

namespace MaaFramework.Binding.Abstractions.Native;

/// <summary>
///     An abstract class providing common members for <see cref="MaaController"/>, <see cref="MaaInstance"/> and <see cref="MaaResource"/>.
/// </summary>
public abstract class MaaCommon : MaaDisposableHandle<nint>, IMaaCommon
{
    /// <inheritdoc/>
    public event EventHandler<MaaCallbackEventArgs>? Callback;

    /// <summary>
    ///     Raises the Callback event.
    /// </summary>
    /// <param name="msg">The MaaStringView.</param>
    /// <param name="detail">The MaaStringView.</param>
    /// <param name="arg">The MaaCallbackTransparentArg.</param>
    /// <remarks>
    ///     Usually invoked by MaaFramework.
    /// </remarks>
    protected virtual void OnCallback(MaaStringView msg, MaaStringView detail, MaaCallbackTransparentArg arg)
    {
        Callback?.Invoke(this, new MaaCallbackEventArgs(
            msg.ToStringUTF8() ?? string.Empty,
            detail.ToStringUTF8() ?? "{}"));
    }

    /// <summary>
    ///     Gets the delegate to avoid garbage collection before MaaFramework calls <see cref="OnCallback"/>.
    /// </summary>
    protected MaaAPICallback MaaApiCallback { get; }

    /// <summary>
    ///     Initializes <see cref="MaaApiCallback"/>.
    /// </summary>
    protected MaaCommon()
        : base(invalidHandleValue: nint.Zero)
    {
        MaaApiCallback = OnCallback;
    }
}
