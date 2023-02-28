---
title: "Create case"
description: "Use this API to create a new case."
ms.localizationpriority: medium
author: "mahage-msft"
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# Create case

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [case](../resources/ediscovery-case.md) object.

>[!NOTE]
>Starting in September 2021, this API will create a large case type. To learn more about large cases, see [Use the new case format in eDiscovery](/microsoft-365/compliance/advanced-ediscovery-new-case-format). For details, see the [Changes to the Microsoft 365 advanced eDiscovery create case API](https://devblogs.microsoft.com/microsoft365dev/changes-to-the-microsoft-365-advanced-ediscovery-create-case-api-beta/) blog post.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /compliance/ediscovery/cases
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |

## Request body

In the request body, supply a JSON representation of a [case](../resources/ediscovery-case.md) object. The following table lists properties that can be submitted with the call.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
| displayName  | string      | The name of the eDiscovery case. |

## Response

If successful, this method returns a `201 Created` response code and a new [microsoft.graph.ediscovery.case](../resources/ediscovery-case.md) object in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "post_case"
}-->

```http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases
Content-type: application/json

{
    "displayName": "My Case 1",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var @case = new Microsoft.Graph.Ediscovery.Case
{
	DisplayName = "My Case 1"
};

await graphClient.Compliance.Ediscovery.Cases
	.Request()
	.AddAsync(@case);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.case"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/compliance/ediscovery/$metadata#cases/$entity",
    "id": "061b9a92-8926-4bd9-b41d-abf35edc7583",
    "displayName": "My Case 1",
    "description": "",
    "createdBy": {
        "user": {
            "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
            "displayName": "eDiscovery admin"
        }
    },
    "createdDateTime": "2020-02-20T22:42:28.5505500Z",
    "lastModifiedBy": {
        "user": {
            "id": "efee1b77-fb3b-4f65-99d6-274c11914d12",
            "displayName": "eDiscovery admin"
        }
    },
    "lastModifiedDateTime": "2020-02-20T22:42:28.5505500Z",
    "status": "active",
    "closedBy": null,
    "closedDateTime": null,
    "externalId": ""
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create case",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->
