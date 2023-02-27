---
title: "appConsentRequest: filterByCurrentUser"
description: "Retrieve appConsentRequest objects for which the current user is the reviewer."
author: "psignoret"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# appConsentRequest: filterByCurrentUser
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a collection of [appConsentRequest](../resources/appconsentrequest.md) objects for which the current user is the reviewer and the status of the userConsentRequest for accessing the specified app is `InProgress`.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ConsentRequest.Read.All, ConsentRequest.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|ConsentRequest.Read.All, ConsentRequest.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identityGovernance/appConsent/appConsentRequests/filterByCurrentUser(on='parameterValue')
```

## Function parameters
In the request URL, provide the following query parameters with values.
The following table shows the parameters that can be used with this function.

|Property|Type|Description|
|:---|:---|:---|
|on|consentRequestFilterByCurrentUserOptions|Filter to query appConsentRequest objects for which the current user is a reviewer. Allowed value is `reviewer`. Required.|

## Query parameters
This function *requires* the `$filter` (`eq`) OData query parameter to return a collection of [userConsentRequest](../resources/userconsentrequest.md) objects for which the status is `InProgress`. The function also supports the `$select` query parameter. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [appConsentRequest](../resources/appconsentrequest.md) objects in the response body.

## Example 1: List all appConsentRequests

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "appconsentrequest_filterbycurrentuser"
}
-->
``` http
GET https://graph.microsoft.com/beta/identityGovernance/appConsent/appConsentRequests/filterByCurrentUser(on='reviewer')?$filter=userConsentRequests/any(u:u/status eq 'InProgress')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var filterByCurrentUser = await graphClient.IdentityGovernance.AppConsent.AppConsentRequests
	.FilterByCurrentUser(ConsentRequestFilterByCurrentUserOptions.Reviewer)
	.Request()
	.Filter("userConsentRequests/any(u:u/status eq 'InProgress')")
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
  "@odata.type": "Collection(microsoft.graph.appConsentRequest)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(appConsentRequest)",
    "@odata.count": 1,
    "value": [
        {
            "@odata.type": "#microsoft.graph.appConsentRequest",
            "id": "7322e5f3-0f15-4eb8-9e82-2029e8622f5d",
            "appId": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
            "appDisplayName": "Graph Explorer",
            "consentType": "Dynamic",
            "pendingScopes": [
                {
                    "displayName": "AccessReview.Read.All"
                },
                {
                    "displayName": "openid"
                },
                {
                    "displayName": "profile"
                },
                {
                    "displayName": "offline_access"
                }
            ],
            "userConsentRequests": []
        }
    ]
}
```

