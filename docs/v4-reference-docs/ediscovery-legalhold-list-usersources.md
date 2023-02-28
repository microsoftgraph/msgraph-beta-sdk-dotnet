---
title: "List legalHold userSources"
description: "Get the userSource resources from the userSources navigation property."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# List legalHold userSources

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the list of [userSource](../resources/ediscovery-usersource.md) objects associated with a legal hold.

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
GET /compliance/ediscovery/cases/{caseId}/legalHolds/{legalholdId}/userSources
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.ediscovery.userSource](../resources/ediscovery-usersource.md) objects in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_usersource_for_caseID"
}
-->

``` http
GET https://graph.microsoft.com/beta/compliance/ediscovery/cases/c816dd6f-5af8-40c5-a760-331361e05c60/legalHolds/277107ff-fee3-41a0-a665-a9d7f6c4824f/userSources
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userSources = await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].LegalHolds["{ediscovery.legalHold-id}"].UserSources
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.ediscovery.userSource)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#compliance/ediscovery/cases('c816dd6f-5af8-40c5-a760-331361e05c60')/legalholds('277107ff-fee3-41a0-a665-a9d7f6c4824f')/userSources",
    "value": [
        {
            "displayName": "Adele Vance",
            "createdDateTime": "2020-10-30T21:02:41.887Z",
            "id": "2f279b24-2142-435d-97c5-0d42220ba453",
            "email": "AdeleV@contoso.com",
            "includedSources": "mailbox",
            "createdBy": {
                "user": {
                    "id": null,
                    "displayName": "eDiscovery admin"
                }
            }
        }
    ]
}
```
