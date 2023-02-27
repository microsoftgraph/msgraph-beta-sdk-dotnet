---
title: "reportRoot: getAzureADApplicationSignInSummary"
description: "Retrieve the properties and relationships of an applicationSigninSummary object."
ms.localizationpriority: medium
author: "besiler"
ms.prod: "identity-and-access-reports"
doc_type: apiPageType
---

# reportRoot: getAzureADApplicationSignInSummary

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve [applicationSigninSummary](../resources/applicationsigninsummary.md) objects within either the last seven or 30 days.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Reports.Read.All |
|Delegated (personal Microsoft account) | Not supported   |
|Application | Reports.Read.All | 

## HTTP request
<!-- { "blockType": "ignored" } -->
``` http
GET reports/getAzureADApplicationSignInSummary(period='{period}')
```

## Function parameters

| Parameter | Description |
|:----------|:----------|
| period | Either `D7` (last seven days) or `D30` (last 30 days); other values generate errors. |

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response
If successful, this method returns a `200 OK` response code and a collection of [applicationSignInSummary](../resources/applicationsigninsummary.md) objects in the response body.

## Example

##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_applicationsigninsummary"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/reports/getAzureADApplicationSignInSummary(period='D7')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var getAzureADApplicationSignInSummary = await graphClient.Reports
	.GetAzureADApplicationSignInSummary("D7")
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
  "@odata.type": "microsoft.graph.applicationSignInSummary"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json


{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(applicationSignInSummary)",
    "value": [
        {
            "@odata.type": "#microsoft.graph.applicationSignInSummary",
            "id": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
            "successfulSignInCount": 9,
            "failedSignInCount": 0,
            "appDisplayName": "Graph Explorer",
            "successPercentage": 100
        },
        {
            "@odata.type": "#microsoft.graph.applicationSignInSummary",
            "id": "c44b4083-3bb0-49c1-b47d-974e53cbdf3c",
            "successfulSignInCount": 2,
            "failedSignInCount": 0,
            "appDisplayName": "Azure Portal",
            "successPercentage": 100
        },
        {
            "@odata.type": "#microsoft.graph.applicationSignInSummary",
            "id": "8c59ead7-d703-4a27-9e55-c96a0054c8d2",
            "successfulSignInCount": 1,
            "failedSignInCount": 0,
            "appDisplayName": "My Profile",
            "successPercentage": 100
        },
        {
            "@odata.type": "#microsoft.graph.applicationSignInSummary",
            "id": "89bee1f7-5e6e-4d8a-9f3d-ecd601259da7",
            "successfulSignInCount": 3,
            "failedSignInCount": 0,
            "appDisplayName": "Office365 Shell WCSS-Client",
            "successPercentage": 100
        }
    ]
}
```



<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Get applicationSignInSummary",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}-->


