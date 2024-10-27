﻿using System.Text.Json.Serialization;

namespace MaaFramework.Binding.Extensions.Notification;

/// <inheritdoc cref="Messages.MaaMsg.Resource.Loading.Prefix"/>
public record ResourceLoadingDetail(
    [property: JsonPropertyName("res_id")] int ResourceId,
    [property: JsonPropertyName("hash")] string Hash,
    [property: JsonPropertyName("path")] string Path
);

/// <inheritdoc cref="Messages.MaaMsg.Controller.Action.Prefix"/>
public record ControllerActionDetail(
    [property: JsonPropertyName("ctrl_id")] int ControllerId,
    [property: JsonPropertyName("uuid")] string Uuid,
    [property: JsonPropertyName("action")] string Action
);

/// <inheritdoc cref="Messages.MaaMsg.Tasker.Task.Prefix"/>
public record TaskerTaskDetail(
    [property: JsonPropertyName("task_id")] int TaskId,
    [property: JsonPropertyName("entry")] string Entry,
    [property: JsonPropertyName("uuid")] string Uuid,
    [property: JsonPropertyName("hash")] string Hash
);

/// <inheritdoc cref="Messages.MaaMsg.Task.NextList.Prefix"/>
public record TaskNextListDetail(
    [property: JsonPropertyName("task_id")] int TaskId,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("list")] IReadOnlyList<string> NextList
);

/// <inheritdoc cref="Messages.MaaMsg.Task.Recognition.Prefix"/>
public record TaskRecognitionDetail(
    [property: JsonPropertyName("task_id")] int TaskId,
    [property: JsonPropertyName("reco_id")] int RecognitionId,
    [property: JsonPropertyName("name")] string Name
);

/// <inheritdoc cref="Messages.MaaMsg.Task.Action.Prefix"/>
public record TaskActionDetail(
    [property: JsonPropertyName("task_id")] int TaskId,
    [property: JsonPropertyName("node_id")] int NodeId,
    [property: JsonPropertyName("name")] string Name
);