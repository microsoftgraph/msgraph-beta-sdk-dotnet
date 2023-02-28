---
title: Get printUsageByUser
description: Retrieve a user's usage summary for a particular time period.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Get printUsageByUser

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a user's usage summary for a particular time period. 

See the [printUsageByUser](../resources/printUsageByUser.md) documentation for descriptions of each of the endpoints.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

To use the Universal Print service, the user or app's tenant must have an active Universal Print subscription, in addition to the permissions listed in the following table.

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| Reports.Read.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /reports/dailyPrintUsageByUser/{id}
GET /reports/monthlyPrintUsageByUser/{id}
GET /print/reports/dailyPrintUsageByUser/{id}
GET /print/reports/monthlyPrintUsageByUser/{id}
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization | Bearer {token}. Required. |

## Request body
Do not supply a request body for this method.
## Response
If successful, this method returns a `200 OK` response code and a [printUsageByUser](../resources/printUsageByUser.md) object in the response body.
## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_printUsageByUser",
  "sampleKeys": ["016b5565-3bbf-4067-b9ff-4d68167eb1a6"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/print/reports/dailyPrintUsageByUser/016b5565-3bbf-4067-b9ff-4d68167eb1a6
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var printUsageByUser = await graphClient.Print.Reports.DailyPrintUsageByUser["{printUsageByUser-id}"]
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
  "@odata.type": "microsoft.graph.printUsageByUser"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "016b5565-3bbf-4067-b9ff-4d68167eb1a6",
  "userPrincipalName": "username@contoso.com",
  "usageDate": "2020-02-04T00:00:00.0000000Z",
  "completedBlackAndWhiteJobCount": 42,
  "completedColorJobCount": 0,
  "incompleteJobCount": 6
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get printUsageByUser",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->

