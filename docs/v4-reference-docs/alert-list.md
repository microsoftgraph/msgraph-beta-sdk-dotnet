---
title: "List alerts"
description: "Retrieve a list of alert objects."
ms.localizationpriority: medium
author: "preetikr"
ms.prod: "security"
doc_type: apiPageType
---

# List alerts

Namespace: microsoft.graph

 [!INCLUDE [beta-disclaimer](../../includes/beta-disclaimer.md)]

Retrieve a list of [alert](../resources/alert.md) objects.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) |  SecurityEvents.Read.All, SecurityEvents.ReadWrite.All  |
|Delegated (personal Microsoft account) |  Not supported.  |
|Application | SecurityEvents.Read.All, SecurityEvents.ReadWrite.All |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
GET /security/alerts
GET /security/alerts?$top=1
GET /security/alerts?$filter={property} eq '{property-value}'
GET /security/alerts?$filter={property} eq '{property-value}'&$top=5
GET /security/alerts?$filter={property} eq '{property-value}'&{property} eq '{property-value}'
```

## Optional query parameters

This method supports the following [OData query parameters](/graph/query-parameters) to help customize the response:

- `$count`
- `$orderby`
- `$select`
- `$skip`
- `$top` - Returns the aggregated top results from each security API provider.
- `$filter`

The following table lists the `$filter` keywords by each vendor name. Even though some of these products have been rebranded, the API is yet to be updated. Filter keywords will continue to use the legacy names until further notice. See the [changelog](https://developer.microsoft.com/graph/changelog) for updates.

| Vendor name      |$filter keyword|
|:----------|:----------|
| Microsoft Defender for Identity | Azure Advanced Threat Protection | 
| Azure Security Center | ASC |
| Microsoft Defender for Cloud Apps | MCAS |
| Azure Active Directory Identity Protection | IPC |
| Azure Sentinel | Azure Sentinel |
| Microsoft Defender for Endpoint | Microsoft Defender ATP |
| Office 365 |  Not currently supported. |

To return an alternative property set, use the OData `$select` query parameter to specify the set of **alert** properties that you want.  For example, to return the **assignedTo**, **category**, and **severity** properties, add the following to your query: `$select=assignedTo,category,severity`.

> **Note:** The `$top` OData query parameter has a limit of 1000 alerts. We recommend that you include only `$top` and not `$skip` in your first GET query. You can use `@odata.nextLink` for pagination. If you need to use `$skip`, it has a limit of 500 alerts. For example, `/security/alerts?$top=10&$skip=500` will return a `200 OK` response code, but `/security/alerts?$top=10&$skip=501` will return a `400 Bad Request` response code. For more information, see [Microsoft Graph Security API error responses](../resources/security-error-codes.md).

## Request headers

| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer {code}. Required.|

## Request body

Do not supply a request body for this method. The request body will be ignored.

## Response

If successful, this method returns a `200 OK` response code and collection of **alert** objects in the response body. If a status code other than 2xx or 404 is returned from a provider or if a provider times out, the response will be a `206 Partial Content` status code with the provider's response in a warning header. For more information, see [Microsoft Graph Security API error responses](../resources/security-error-codes.md).

## Example

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_alerts"
}-->

```msgraph-interactive
GET https://graph.microsoft.com/beta/security/alerts
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var alerts = await graphClient.Security.Alerts
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.alert",
  "isCollection": true
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "activityGroupName": "activityGroupName-value",
      "assignedTo": "assignedTo-value",
      "azureSubscriptionId": "azureSubscriptionId-value",
      "azureTenantId": "azureTenantId-value",
      "category": "category-value",
      "closedDateTime": "datetime-value"
    }
  ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List alerts",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


