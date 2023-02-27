---
title: "Create legalHold"
description: "Create a new legalHold object."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: resourcePageType
---

# Create legalHold

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [legalHold](../resources/ediscovery-legalhold.md) object.

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
POST /compliance/ediscovery/cases/{caseId}/legalHolds
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [legalHold](../resources/ediscovery-legalhold.md) object.

The following table shows the properties that are required when you create the [legalHold](../resources/ediscovery-legalhold.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String| The display name of the legal hold. |

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.ediscovery.legalHold](../resources/ediscovery-legalhold.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_legalhold_from_"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/{caseId}/legalHolds
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.ediscovery.legalHold",
  "description": "String",
  "createdBy": {
    "@odata.type": "microsoft.graph.identitySet"
  },
  "isEnabled": "Boolean",
  "status": "String",
  "contentQuery": "String",
  "errors": [
    "String"
  ],
  "displayName": "String"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var legalHold = new Microsoft.Graph.Ediscovery.LegalHold
{
	Description = "String",
	CreatedBy = new IdentitySet
	{
	},
	IsEnabled = false,
	Status = Microsoft.Graph.Ediscovery.LegalHoldStatus.Pending,
	ContentQuery = "String",
	Errors = new List<String>()
	{
		"String"
	},
	DisplayName = "String"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].LegalHolds
	.Request()
	.AddAsync(legalHold);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.legalHold"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.ediscovery.legalHold",
  "id": "700cd868-d868-700c-68d8-0c7068d80c70",
  "description": "String",
  "createdBy": {
    "@odata.type": "microsoft.graph.identitySet"
  },
  "lastModifiedBy": {
    "@odata.type": "microsoft.graph.identitySet"
  },
  "lastModifiedDateTime": "String (timestamp)",
  "isEnabled": "Boolean",
  "status": "String",
  "contentQuery": "String",
  "errors": [
    "String"
  ],
  "displayName": "String",
  "createdDateTime": "String (timestamp)"
}
```
