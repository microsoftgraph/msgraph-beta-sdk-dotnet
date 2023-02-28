---
title: "Get accessReviewHistoryDefinition"
description: "Retrieve an accessReviewHistoryDefinition object."
author: "jyothig123"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Get accessReviewHistoryDefinition

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve an [accessReviewHistoryDefinition](../resources/accessreviewhistorydefinition.md) object by its identifier. All of the properties of the access review history definition object are returned. If the definition is 30 days or older, a `404 Not Found` error is returned.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|AccessReview.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|AccessReview.ReadWrite.All|

The signed-in user must also be the creator of the associated review history definition, a Global Admin directory role member, or a Global Reader directory role member to retrieve the definition.

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /identityGovernance/accessReviews/historyDefinitions/{definition-id}
```
## Optional query parameters

This method supports the `$select` and `$expand` OData query parameters to help customize the response. Including `?$expand=instances` will include in the response object the instances associated with the [accessReviewHistoryDefinition](../resources/accessreviewhistorydefinition.md) object. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and an [accessReviewHistoryDefinition](../resources/accessreviewhistorydefinition.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "get_accessreviewhistorydefinition"
}
-->

``` http
GET https://graph.microsoft.com/beta/identityGovernance/accessReviews/historyDefinitions/b2cb022f-b7e1-40f3-9854-c65a40861c38
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var accessReviewHistoryDefinition = await graphClient.IdentityGovernance.AccessReviews.HistoryDefinitions["{accessReviewHistoryDefinition-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.accessReviewHistoryDefinition"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.accessReviewHistoryDefinition",
  "id": "b2cb022f-b7e1-40f3-9854-c65a40861c38",
  "displayName": "Last quarter's group reviews April 2021",
  "reviewHistoryPeriodStartDateTime": "2021-01-01T00:00:00Z",
  "reviewHistoryPeriodEndDateTime": "2021-04-05T00:00:00Z",
  "decisions": [
    "approve",
    "deny",
    "dontKnow",
    "notReviewed",
    "notNotified"
  ],
  "status": "done",
  "createdDateTime": "2021-04-14T00:22:48.9392594Z",
  "createdBy": {
    "id": "957f1027-c0ee-460d-9269-b8444459e0fe",
    "displayName": "MOD Administrator",
    "userPrincipalName": "admin@contoso.com"
  },
  "scopes": [
    {
      "@odata.type": "#microsoft.graph.accessReviewQueryScope",
      "queryType": "MicrosoftGraph",     
      "query": "/identityGovernance/accessReviews/definitions?$filter=contains(scope/query, 'accessPackageAssignments')",
      "queryRoot": null
    },  
    {
      "@odata.type": "#microsoft.graph.accessReviewQueryScope",
      "queryType": "MicrosoftGraph",     
      "query": "/identityGovernance/accessReviews/definitions?$filter=contains(scope/query, '/groups')",
      "queryRoot": null
    }
  ]
}
```
