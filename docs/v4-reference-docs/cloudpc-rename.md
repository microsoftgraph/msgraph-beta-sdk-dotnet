---
title: "cloudPC: rename"
description: "Rename a specific Cloud PC. Use this API to update the displayName for the Cloud PC entity."
author: "RuiHou105"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPC: rename

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Rename a specific Cloud PC. Use this API to update the **displayName** for the Cloud PC entity.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|CloudPC.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

To rename the [cloudPC](../resources/cloudpc.md) of the specified user (who is the signed-in user) in the organization using delegated permission:

``` http
POST /me/cloudPCs/{cloudPCId}/rename
POST /users/{userId}/cloudPCs/{cloudPCId}/rename
```

To rename the specified [cloudPC](../resources/cloudpc.md) in the organization, using either delegated permission (the signed-in user should be the administrator) or application permission:

``` http
POST /deviceManagement/virtualEndpoint/cloudPCs/{cloudPCId}/rename
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The new display name for the Cloud PC.|

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Example 1: Rename the cloudPC for the administrator

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "rename_cloudpc"
}
-->

``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/cloudPCs/c2bbb5dd-2574-451b-a508-bbaa6ac48ace/rename
Content-Type: application/json

{
  displayName: "Cloud PC-HR"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var displayName = "Cloud PC-HR";

await graphClient.DeviceManagement.VirtualEndpoint.CloudPCs["{cloudPC-id}"]
	.Rename(displayName)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
```

### Example 2: Rename the cloudPC for the signed-in user

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_rename_cloudpc"
}
-->

``` http
POST https://graph.microsoft.com/beta/me/cloudPCs/36bd4942-0ca8-11ed-861d-0242ac120002/rename
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.CloudPCs["{cloudPC-id}"]
	.Rename(null)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
```
