﻿using MaaFramework.Binding.Abstractions;
using MaaFramework.Binding.Native.Interop;

namespace MaaFramework.Binding.UnitTests;

/// <summary>
///     Test <see cref="IMaaResource"/> and <see cref="MaaResource"/> and <see cref="MaaResourceGrpc"/>.
/// </summary>
[TestClass]
public class Test_IMaaResource
{
    public static Dictionary<MaaTypes, object> NewData => new()
    {
        { MaaTypes.Native, new MaaResource() },
        { MaaTypes.Grpc,   new MaaResourceGrpc(Common.GrpcChannel) },
    };
    public static Dictionary<MaaTypes, object> Data { get; private set; } = default!;

    [ClassInitialize]
    public static void InitializeClass(TestContext context)
    {
        Data = NewData;
        foreach (var data in Data.Values.Cast<IMaaResource>())
        {
            Assert.IsFalse(data.IsInvalid);
            data.Callback += Common.Callback;
        }
    }

    [ClassCleanup]
    public static void CleanUpClass()
    {
        Common.DisposeData(Data.Values.Cast<IMaaDisposable>());
    }

#pragma warning disable S2699 // Tests should include assertions
    [TestMethod]
    public void CreateInstances()
    {
        using var native1 = new MaaResource();
        using var native2 = new MaaResource(nint.Zero);
        using var native3 = new MaaResource(Common.ResourcePath, Common.ResourcePath);
        using var native4 = new MaaResource(CheckStatusOption.None, Common.ResourcePath);
        using var native5 = new MaaResource(nint.Zero, CheckStatusOption.None, Common.ResourcePath);

        using var grpc1 = new MaaResourceGrpc(Common.GrpcChannel);
        using var grpc2 = new MaaResourceGrpc(Common.GrpcChannel, Common.ResourcePath, Common.ResourcePath);
        using var grpc3 = new MaaResourceGrpc(Common.GrpcChannel, CheckStatusOption.None, Common.ResourcePath);
    }
#pragma warning restore S2699 // Tests should include assertions

    [TestMethod]
    [MaaData(MaaTypes.All, nameof(Data))]
    public void Interface_AppendPath_Loaded(MaaTypes type, IMaaResource maaResource)
    {
        Assert.IsNotNull(maaResource);

        Assert.IsFalse(
            maaResource.Loaded);
        var job =
            maaResource.AppendPath(Common.ResourcePath);
        Interface_IMaaPost_Success(job);
        Assert.IsTrue(
            maaResource.Loaded);
    }

    public static void Interface_IMaaPost_Success(IMaaJob job)
    {
        Assert.IsNotNull(job);

        Assert.IsFalse(
            job.SetParam("{}"));
        Assert.AreEqual(
            MaaJobStatus.Success, job.Wait());
        Assert.AreEqual(
            MaaJobStatus.Success, job.Status);
    }

    [TestMethod]
    [MaaData(MaaTypes.All, nameof(Data), ResourceOption.Invalid, "Anything")]
    [MaaData(MaaTypes.All, nameof(Data), ResourceOption.Invalid, false)]
    [MaaData(MaaTypes.All, nameof(Data), ResourceOption.Invalid, 0)]
    public void Interface_SetOption(MaaTypes type, IMaaResource maaResource, ResourceOption opt, object arg)
    {
        Assert.IsNotNull(maaResource);

        var ret = Common.SetOption(maaResource, opt, arg);
        if (opt is ResourceOption.Invalid)
            Assert.IsFalse(ret);
        else
            Assert.IsTrue(ret);
    }

    [TestMethod]
    [MaaData(MaaTypes.All, nameof(Data))]
    public void Interface_Hash(MaaTypes type, IMaaResource maaResource)
    {
        Assert.IsNotNull(maaResource);

        Assert.IsFalse(string.IsNullOrWhiteSpace(
            maaResource.Hash));
    }
}
