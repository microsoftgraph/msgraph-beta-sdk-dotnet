---
title: "cloudPC: troubleshoot"
description: "Troubleshoot a specific Cloud PC. Use this API to check the health status of the Cloud PC and the session host."
author: "RuiHou105"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPC: troubleshoot

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Troubleshoot a specific Cloud PC. Use this API to check the health status of the Cloud PC and the session host.

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

To troubleshoot the [cloudPC](../resources/cloudpc.md) of the specified user (who is the signed-in user) in the organization using delegated permission:

``` http
POST /me/cloudPCs/{cloudPCId}/troubleshoot
POST /users/{userId}/cloudPCs/{cloudPCId}/troubleshoot
```

To troubleshoot the specified [cloudPC](../resources/cloudpc.md) in the organization, using either delegated permission (the signed-in user should be the administrator) or application permission:

``` http
POST /deviceManagement/virtualEndpoint/cloudPCs/{cloudPCId}/troubleshoot
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `204 No Content` response code.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "troubleshoot_cloudpc"
}
-->

``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/cloudPCs/ff4eb6ab-d56a-4edf-90c1-baaec8dd6032/troubleshoot
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.DeviceManagement.VirtualEndpoint.CloudPCs["{cloudPC-id}"]
	.Troubleshoot()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
```

### Example 2: Troubleshoot the cloudPC for the signed-in user

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "user_troubleshoot_cloudpc"
}
-->

``` http
POST https://graph.microsoft.com/beta/me/cloudPCs/36bd4942-0ca8-11ed-861d-0242ac120002/troubleshoot
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Me.CloudPCs["{cloudPC-id}"]
	.Troubleshoot()
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
