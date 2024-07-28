﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable CS1573 // 参数在 XML 注释中没有匹配的 param 标记
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

global using MaaControllerApiTuple = (
    System.Runtime.InteropServices.GCHandle Handle,
    MaaFramework.Binding.Custom.IMaaCustomController Managed,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.ConnectDelegate ConnectMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.RequestUuidDelegate RequestUuidMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.StartAppDelegate StartAppMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.StopAppDelegate StopAppMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.ScreencapDelegate ScreencapMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.ClickDelegate ClickMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.SwipeDelegate SwipeMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.TouchDownDelegate TouchDownMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.TouchMoveDelegate TouchMoveMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.TouchUpDelegate TouchUpMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.PressKeyDelegate PressKeyMethod,
    MaaFramework.Binding.Interop.Native.IMaaCustomControllerExtension.InputTextDelegate InputTextMethod
);

using MaaFramework.Binding.Buffers;
using MaaFramework.Binding.Custom;
using System.Runtime.InteropServices;

namespace MaaFramework.Binding.Interop.Native;

/// <summary>
///     The custom controller API.
/// </summary>
/// <remarks>
///     To create a custom controller, you need to implement this API.
///     You do not have to implement all the functions in this API. Instead, just implement the functions you need. Do note that if an unimplemented function is called, the framework will likely crash.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public class MaaCustomControllerApi
{
    public nint ConnectFunctionPointer;
    public nint RequestUuidFunctionPointer;
    public nint StartAppFunctionPointer;
    public nint StopAppFunctionPointer;
    public nint ScreencapFunctionPointer;
    public nint ClickFunctionPointer;
    public nint SwipeFunctionPointer;
    public nint TouchDownFunctionPointer;
    public nint TouchMoveFunctionPointer;
    public nint TouchUpFunctionPointer;
    public nint PressKeyFunctionPointer;
    public nint InputTextFunctionPointer;
}

/// <summary>
///     A static class providing extension methods for the converter of <see cref="IMaaCustomController"/>.
/// </summary>
public static class IMaaCustomControllerExtension
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool ConnectDelegate(MaaTransparentArg handleArg);

    /// <summary>
    ///     Write result to buffer.
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool RequestUuidDelegate(MaaTransparentArg handleArg, MaaStringBufferHandle buffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool StartAppDelegate([MarshalAs(UnmanagedType.LPUTF8Str)] string intent, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool StopAppDelegate([MarshalAs(UnmanagedType.LPUTF8Str)] string intent, MaaTransparentArg handleArg);

    /// <summary>
    ///     Write result to buffer.
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool ScreencapDelegate(MaaTransparentArg handleArg, MaaImageBufferHandle buffer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool ClickDelegate(int x, int y, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool SwipeDelegate(int x1, int y1, int x2, int y2, int duration, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool TouchDownDelegate(int contact, int x, int y, int pressure, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool TouchMoveDelegate(int contact, int x, int y, int pressure, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool TouchUpDelegate(int contact, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool PressKeyDelegate(int keycode, MaaTransparentArg handleArg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate MaaBool InputTextDelegate([MarshalAs(UnmanagedType.LPUTF8Str)] string text, MaaTransparentArg handleArg);
    public static MaaCustomControllerHandle Convert(this IMaaCustomController task, out MaaControllerApiTuple tuple)
    {
        MaaBool ConnectLocalMethod(MaaTransparentArg handleArg) => task.Connect().ToMaaBool();

        MaaBool RequestUuidLocalMethod(MaaTransparentArg handleArg, MaaStringBufferHandle buffer) => task.RequestUuid(new Buffers.MaaStringBuffer(buffer)).ToMaaBool();

        MaaBool StartAppLocalMethod(string intent, MaaTransparentArg handleArg) => task.StartApp(intent).ToMaaBool();

        MaaBool StopAppLocalMethod(string intent, MaaTransparentArg handleArg) => task.StopApp(intent).ToMaaBool();

        MaaBool ScreencapLocalMethod(MaaTransparentArg handleArg, MaaImageBufferHandle buffer) => task.Screencap(new MaaImageBuffer(buffer)).ToMaaBool();

        MaaBool ClickLocalMethod(int x, int y, MaaTransparentArg handleArg) => task.Click(x, y).ToMaaBool();

        MaaBool SwipeLocalMethod(int x1, int y1, int x2, int y2, int duration, MaaTransparentArg handleArg) => task.Swipe(x1, y1, x2, y2, duration).ToMaaBool();

        MaaBool TouchDownLocalMethod(int contact, int x, int y, int pressure, MaaTransparentArg handleArg) => task.TouchDown(contact, x, y, pressure).ToMaaBool();

        MaaBool TouchMoveLocalMethod(int contact, int x, int y, int pressure, MaaTransparentArg handleArg) => task.TouchMove(contact, x, y, pressure).ToMaaBool();

        MaaBool TouchUpLocalMethod(int contact, MaaTransparentArg handleArg) => task.TouchUp(contact).ToMaaBool();

        MaaBool PressKeyLocalMethod(int keycode, MaaTransparentArg handleArg) => task.PressKey(keycode).ToMaaBool();

        MaaBool InputTextLocalMethod(string text, MaaTransparentArg handleArg) => task.InputText(text).ToMaaBool();

        ConnectDelegate ConnectMethod = ConnectLocalMethod;
        RequestUuidDelegate RequestUuidMethod = RequestUuidLocalMethod;
        StartAppDelegate StartAppMethod = StartAppLocalMethod;
        StopAppDelegate StopAppMethod = StopAppLocalMethod;
        ScreencapDelegate ScreencapMethod = ScreencapLocalMethod;
        ClickDelegate ClickMethod = ClickLocalMethod;
        SwipeDelegate SwipeMethod = SwipeLocalMethod;
        TouchDownDelegate TouchDownMethod = TouchDownLocalMethod;
        TouchMoveDelegate TouchMoveMethod = TouchMoveLocalMethod;
        TouchUpDelegate TouchUpMethod = TouchUpLocalMethod;
        PressKeyDelegate PressKeyMethod = PressKeyLocalMethod;
        InputTextDelegate InputTextMethod = InputTextLocalMethod;

        var handle = GCHandle.Alloc(new MaaCustomControllerApi()
        {
            ConnectFunctionPointer = Marshal.GetFunctionPointerForDelegate<ConnectDelegate>(ConnectMethod),
            RequestUuidFunctionPointer = Marshal.GetFunctionPointerForDelegate<RequestUuidDelegate>(RequestUuidMethod),
            StartAppFunctionPointer = Marshal.GetFunctionPointerForDelegate<StartAppDelegate>(StartAppMethod),
            StopAppFunctionPointer = Marshal.GetFunctionPointerForDelegate<StopAppDelegate>(StopAppMethod),
            ScreencapFunctionPointer = Marshal.GetFunctionPointerForDelegate<ScreencapDelegate>(ScreencapMethod),
            ClickFunctionPointer = Marshal.GetFunctionPointerForDelegate<ClickDelegate>(ClickMethod),
            SwipeFunctionPointer = Marshal.GetFunctionPointerForDelegate<SwipeDelegate>(SwipeMethod),
            TouchDownFunctionPointer = Marshal.GetFunctionPointerForDelegate<TouchDownDelegate>(TouchDownMethod),
            TouchMoveFunctionPointer = Marshal.GetFunctionPointerForDelegate<TouchMoveDelegate>(TouchMoveMethod),
            TouchUpFunctionPointer = Marshal.GetFunctionPointerForDelegate<TouchUpDelegate>(TouchUpMethod),
            PressKeyFunctionPointer = Marshal.GetFunctionPointerForDelegate<PressKeyDelegate>(PressKeyMethod),
            InputTextFunctionPointer = Marshal.GetFunctionPointerForDelegate<InputTextDelegate>(InputTextMethod),
        }, GCHandleType.Pinned);

        tuple = (
            handle,
            task,
            ConnectMethod,
            RequestUuidMethod,
            StartAppMethod,
            StopAppMethod,
            ScreencapMethod,
            ClickMethod,
            SwipeMethod,
            TouchDownMethod,
            TouchMoveMethod,
            TouchUpMethod,
            PressKeyMethod,
            InputTextMethod
        );
        return handle.AddrOfPinnedObject();
    }
}
