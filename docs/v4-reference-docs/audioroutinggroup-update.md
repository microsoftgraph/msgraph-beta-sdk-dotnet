---
title: "Update audio routing group"
description: "Modify sources and receivers of an audioRoutingGroup."
author: "ananmishr"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Update audio routing group

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Modify sources and receivers of an [audioRoutingGroup](../resources/audioroutinggroup.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged)                |
| :-------------- | :--------------------------------------------------------- |
| Delegated (work or school account)     | Not Supported                       |
| Delegated (personal Microsoft account) | Not Supported                       |
| Application     | Calls.JoinGroupCalls.All, Calls.InitiateGroupCalls.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /app/calls/{id}/audioRoutingGroups/{id}
PATCH /communications/calls/{id}/audioRoutingGroups/{id}
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property       | Type    |Description|
|:---------------|:--------|:----------|
| receivers | String collection | The target participants in the audioRoutingGroup. |
| routingMode | String | Possible values are: `oneToOne`, `multicast`. |
| sources | String collection | The source participant in the audioRoutingGroup. |

## Response
If successful, this method returns a `200 OK` response code and an updated [audioRoutingGroup](../resources/audioroutinggroup.md) object in the response body.

## Example

##### Request
The following example shows the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update-audioRoutingGroup"
}-->
```http
PATCH https://graph.microsoft.com/beta/communications/calls/{id}/audioRoutingGroups/{id}
Content-Type: application/json

{
  "id": "oneToOne",
  "routingMode": "oneToOne",
  "sources": [
    "632899f8-2ea1-4604-8413-27bd2892079f"
  ],
  "receivers": [
    "550fae72-d251-43ec-868c-373732c2704f",
    "72f988bf-86f1-41af-91ab-2d7cd011db47"
  ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var audioRoutingGroup = new AudioRoutingGroup
{
	Id = "oneToOne",
	RoutingMode = RoutingMode.OneToOne,
	Sources = new List<String>()
	{
		"632899f8-2ea1-4604-8413-27bd2892079f"
	},
	Receivers = new List<String>()
	{
		"550fae72-d251-43ec-868c-373732c2704f",
		"72f988bf-86f1-41af-91ab-2d7cd011db47"
	}
};

await graphClient.Communications.Calls["{call-id}"].AudioRoutingGroups["{audioRoutingGroup-id}"]
	.Request()
	.UpdateAsync(audioRoutingGroup);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

