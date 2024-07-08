﻿namespace MaaFramework.Binding.Interop.Native;

/// <summary>
///     A class providing implementation for managing marshaled parameters in <see cref="Binding"/>.
/// </summary>
/// <typeparam name="T">The marshaled api.</typeparam>
internal sealed class MaaMarshaledApis<T>
{
    private readonly Dictionary<string, T> _apis = [];

    public bool Set(string key, T tuple)
    {
        _apis[key] = tuple;
        return true;
    }

    public bool Remove(string name)
    {
        return _apis.Remove(name);
    }

    public bool Clear()
    {
        _apis.Clear();
        return true;
    }
}
