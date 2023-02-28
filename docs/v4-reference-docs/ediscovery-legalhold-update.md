---
title: "Update legalHold"
description: "Update the properties of a legalHold object."
ms.localizationpriority: medium
author: "mahage-msft"
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Update legalHold

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [legalHold](../resources/ediscovery-legalhold.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
PATCH /compliance/ediscovery/cases/{caseId}/legalHolds/{legalholdId}
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

|Property|Type|Description|
|:---|:---|:---|
|description|String| The legal hold description. |
|displayName|String| The display name of the legal hold. |
|isEnabled|Boolean|Indicates whether the hold is enabled and actively holding content. |

## Response

If successful, this action returns a `204 No Content` response code.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_legalhold"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/compliance/ediscovery/cases/{caseId}/legalHolds/{legalholdId}
Content-Type: application/json

{
  "description": "This is a description for a legalHold"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var legalHold = new Microsoft.Graph.Ediscovery.LegalHold
{
	Description = "This is a description for a legalHold"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].LegalHolds["{ediscovery.legalHold-id}"]
	.Request()
	.UpdateAsync(legalHold);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response"
}
-->

``` http
HTTP/1.1 204 No Content
```
