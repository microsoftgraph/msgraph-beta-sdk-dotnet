---
title: "cloudPC: getSupportedCloudPcRemoteActions"
description: "Get a list of supported Cloud PC remote actions for a specific Cloud PC device, including the action names and capabilities."
author: "hanky0301"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# cloudPC: getSupportedCloudPcRemoteActions

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of supported Cloud PC remote actions for a specific Cloud PC device, including the action names and capabilities.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | CloudPC.Read.All                            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | CloudPC.ReadWrite.All                       |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /deviceManagement/virtualEndpoint/cloudPCs/{id}/getSupportedCloudPcRemoteActions
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [cloudPcRemoteActionCapability](../resources/cloudpcremoteactioncapability.md) objects in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "cloudpc_getsupportedcloudpcremoteactions"
}
-->

``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/cloudPCs/831dd62e-cfa1-4d49-a3b4-58d4e9920f8e/getSupportedCloudPcRemoteActions
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getSupportedCloudPcRemoteActions = await graphClient.DeviceManagement.VirtualEndpoint.CloudPCs["{cloudPC-id}"]
	.GetSupportedCloudPcRemoteActions()
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "@odata.type": "Collection(microsoft.graph.cloudPcRemoteActionCapability)",
  "truncated": true
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.cloudPcRemoteActionCapability)",
    "value": [
        {
            "actionName": "Restart",
            "actionCapability": "disabled"
        },
        {
            "actionName": "Restore",
            "actionCapability": "disabled"
        },
        {
            "actionName": "Reprovision",
            "actionCapability": "enabled"
        },
        {
            "actionName": "Resize",
            "actionCapability": "disabled"
        },
        {
            "actionName": "PlaceUnderReview",
            "actionCapability": "disabled"
        }
    ]
}
```
