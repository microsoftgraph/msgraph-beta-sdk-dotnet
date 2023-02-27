---
title: "notebook: getRecentNotebooks"
description: "Get a list of recentNotebook instances that have been accessed by the signed-in user."
author: "jewan-microsoft"
ms.localizationpriority: medium
ms.prod: "onenote"
doc_type: apiPageType
---

# notebook: getRecentNotebooks

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of [recentNotebook](../resources/recentnotebook.md) instances that have been accessed by the signed-in user.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Notes.Create, Notes.Read, Notes.ReadWrite, Notes.Read.All, Notes.ReadWrite.All,|
|Delegated (personal Microsoft account) | Notes.Create, Notes.Read, Notes.ReadWrite |
|Application | Notes.Read.All, Notes.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
GET /me/onenote/notebooks/getRecentNotebooks(includePersonalNotebooks=includePersonalNotebooks-value)
GET /users/{id | userPrincipalName}/onenote/notebooks/getRecentNotebooks(includePersonalNotebooks=includePersonalNotebooks-value)
```

The `{id | userPrincipalName}` for the user must match the user encoded in the authorization token used to make the request.

## Function parameters

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|includePersonalNotebooks|Boolean|Include notebooks owned by the user. Set to `true` to include notebooks owned by the user; otherwise, set to `false`. If you don't include the `includePersonalNotebooks` parameter, your request will return a `400` error response.|

## Request headers
| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {code}|

## Request body
Do not supply a request body for this method.

## Response
A successful response returns a `200 OK` that contains a JSON collection of **recentNotebooks**.

## Example
The following example shows how to call this API.

##### Request
The following example shows the request.

# [HTTP](#tab/http)
<!-- { "blockType": "request", "name": "recent_notebooks", "scopes": "notes.read" } -->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/onenote/notebooks/getRecentNotebooks(includePersonalNotebooks=true)
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getRecentNotebooks = await graphClient.Me.Onenote.Notebooks
	.GetRecentNotebooks(true)
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

