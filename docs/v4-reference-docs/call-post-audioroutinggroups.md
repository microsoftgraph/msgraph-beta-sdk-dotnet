---
title: "Create audio routing group"
description: "Create a new **audioRoutingGroup**."
author: "mkhribech"
ms.localizationpriority: medium
ms.prod: "cloud-communications"
doc_type: apiPageType
---

# Create audio routing group

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new **audioRoutingGroup**.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Not supported.                               |
| Delegated (personal Microsoft account) | Not supported.                               |
| Application                            | Calls.JoinGroupCalls.All, Calls.InitiateGroupCalls.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
POST /app/calls/{id}/audioRoutingGroups
POST /communications/calls/{id}/audioRoutingGroups
```
> **Note:** The `/app` path is deprecated. Going forward, use the `/communications` path.

## Request headers
| Name          | Description               |
|:--------------|:--------------------------|
| Authorization | Bearer {token}. Required. |

## Request body
In the request body, supply a JSON representation of [audioRoutingGroup](../resources/audioroutinggroup.md) object.

## Response
If successful, this method returns `200 OK` response code and [audioRoutingGroup](../resources/audioroutinggroup.md) object in the response body.

## Examples

### Example 1: One-to-one audio routing group

##### Request
The following example shows the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create-audioRoutingGroup-from-call"
}-->
```http
POST https://graph.microsoft.com/beta/communications/calls/{id}/audioRoutingGroups
Content-Type: application/json
Content-Length: 233

{
  "id": "oneToOne",
  "routingMode": "oneToOne",
  "sources": [
    "632899f8-2ea1-4604-8413-27bd2892079f"
  ],
  "receivers": [
    "550fae72-d251-43ec-868c-373732c2704f"
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
		"550fae72-d251-43ec-868c-373732c2704f"
	}
};

await graphClient.Communications.Calls["{call-id}"].AudioRoutingGroups
	.Request()
	.AddAsync(audioRoutingGroup);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

