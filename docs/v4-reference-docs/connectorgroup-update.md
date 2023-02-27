---
title: "Update connectorGroups"
description: "Update the properties of connectorgroup object."
ms.localizationpriority: medium
author: "japere"
ms.prod: "applications"
doc_type: "apiPageType"
---

# Update connectorGroups

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [connectorGroup](../resources/connectorgroup.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Directory.ReadWrite.All   |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Not supported.  |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}
```
## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer. Required|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance you shouldn't include existing values that haven't changed.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|connectorGroupType|string| Indicates the type of hybrid agent. This pre-set by the system. |
|id|string| Unique identifier for this connectorGroup. Read-only. |
|isDefault|boolean| Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. |
|name|string| The name associated with the connectorGroup. |
|region|string| The region the connectorGroup is assigned to and will optimize traffic for. This region can only be set if **no** connectors or applications are assigned to the connectorGroup. The regions available include: North America, Europe, Australia, Asia, and India. Possible values are: `nam`, `eur`, `aus`, `asia`, `ind`.|

## Response

If successful, this method returns a `200 OK` response code and updated [connectorGroup](../resources/connectorgroup.md) object in the response body.
## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_connectorgroup_2"
}-->
```http
PATCH https://graph.microsoft.com/beta/onPremisesPublishingProfiles/applicationProxy/connectorGroups/{id}
Content-type: application/json

{
  "name": "name-value",
  "region": "region-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var connectorGroup = new ConnectorGroup
{
	Name = "name-value",
	Region = ConnectorGroupRegion.Nam
};

await graphClient.OnPremisesPublishingProfiles["{onPremisesPublishingProfile-id}"].ConnectorGroups["{connectorGroup-id}"]
	.Request()
	.UpdateAsync(connectorGroup);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

