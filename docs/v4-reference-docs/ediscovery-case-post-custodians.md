---
title: "Create custodian"
description: "Create a new custodian object."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Create custodian

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [custodian](../resources/ediscovery-custodian.md) object. After the custodian object is created, you will need to create the custodian's [userSource](../resources/ediscovery-usersource.md) to reference their mailbox and OneDrive for Business site.

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
POST /compliance/ediscovery/cases/{caseId}/custodians
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [custodian](../resources/ediscovery-custodian.md) object.

The following table shows the properties that are required when you create the [custodian](../resources/ediscovery-custodian.md).

|Property|Type|Description|
|:---|:---|:---|
|email|String|Custodian's primary SMTP address. Required.|
|applyHoldToSources|Boolean|Indicates whether a hold is applied to the custodian's sources (such as mailboxes, sites, or Teams).|

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.ediscovery.custodian](../resources/ediscovery-custodian.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_custodian_from_"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/2192ca408ea2410eba3bec8ae873be6b/custodians
Content-Type: application/json

{
    "email":"AdeleV@contoso.com",
    "applyHoldToSources":"true"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var custodian = new Microsoft.Graph.Ediscovery.Custodian
{
	Email = "AdeleV@contoso.com",
	ApplyHoldToSources = true
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].Custodians
	.Request()
	.AddAsync(custodian);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.custodian"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#compliance/ediscovery/cases('4c8f8f70-7785-4bd4-b296-c98376a2c5e1')/custodians/$entity",
    "email": "AdeleV@contoso.com",
    "applyHoldToSources": false,
    "status": "active",
    "createdDateTime": "2020-10-30T20:47:01.7724531Z",
    "lastModifiedDateTime": "2020-10-30T20:47:02.2512381Z",
    "releasedDateTime": null,
    "acknowledgedDateTime": null,
    "id": "45353243323138344430413038363846",
    "displayName": "Adele Vance"
}
```
