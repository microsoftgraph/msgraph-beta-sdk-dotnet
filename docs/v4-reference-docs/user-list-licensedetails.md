---
title: "List licenseDetails"
description: "Retrieve a list of licenseDetails objects."
author: "jconley76"
ms.localizationpriority: medium
ms.prod: "users"
doc_type: apiPageType
---

# List licenseDetails

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a list of [licenseDetails](../resources/licensedetails.md) objects for enterprise users. This API returns details for licenses that are directly assigned and those transitively assigned through memberships in licensed groups.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.Read, User.Read.All, User.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | User.Read    |
|Application | User.Read.All, User.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/licenseDetails
GET /users/{id}/licenseDetails
```
## Optional query parameters
This method supports the `$select` query parameter. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
| Name      |Description|
|:----------|:----------|
| Authorization  | Bearer &lt;code&gt;|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [licenseDetails](../resources/licensedetails.md) objects in the response body.
## Example
### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_licensedetails"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/licenseDetails
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var licenseDetails = await graphClient.Me.LicenseDetails
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
Note: The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.licenseDetails",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('48d31887-5fad-4d73-a9f5-3c356e68a038')/licenseDetails",
    "value": [
        {
            "id": "3RnS3Gi8m0u_C0ozp5a-NWAn38eBLPdOtXhbU5K1cd8",
            "skuId": "c7df2760-2c81-4ef7-b578-5b5392b571df",
            "skuPartNumber": "ENTERPRISEPREMIUM",
            "servicePlans": [
                {
                    "servicePlanId": "cd31b152-6326-4d1b-ae1b-997b625182e6",
                    "servicePlanName": "MIP_S_Exchange",
                    "provisioningStatus": "PendingProvisioning",
                    "appliesTo": "User"
                },
                {
                    "servicePlanId": "8e0c0a52-6a6c-4d40-8370-dd62790dcd70",
                    "servicePlanName": "THREAT_INTELLIGENCE",
                    "provisioningStatus": "Success",
                    "appliesTo": "User"
                },
                {
                    "servicePlanId": "9c0dab89-a30c-4117-86e7-97bda240acd2",
                    "servicePlanName": "POWERAPPS_O365_P3",
                    "provisioningStatus": "Success",
                    "appliesTo": "User"
                },
                {
                    "servicePlanId": "8c098270-9dd4-4350-9b30-ba4703f3b36b",
                    "servicePlanName": "ADALLOM_S_O365",
                    "provisioningStatus": "Success",
                    "appliesTo": "User"
                },
                {
                    "servicePlanId": "5dbe027f-2339-4123-9542-606e4d348a72",
                    "servicePlanName": "SHAREPOINTENTERPRISE",
                    "provisioningStatus": "Success",
                    "appliesTo": "User"
                }
            ]
        },
        {
            "id": "3RnS3Gi8m0u_C0ozp5a-Ne0iVHIF4g5Aqwo4mdijmMo",
            "skuId": "725422ed-e205-400e-ab0a-3899d8a398ca",
            "skuPartNumber": "SCHOOL_DATA_SYNC_P2",
            "servicePlans": [
                {
                    "servicePlanId": "113feb6c-3fe4-4440-bddc-54d774bf0318",
                    "servicePlanName": "EXCHANGE_S_FOUNDATION",
                    "provisioningStatus": "Success",
                    "appliesTo": "Company"
                },
                {
                    "servicePlanId": "500b6a2a-7a50-4f40-b5f9-160e5b8c2f48",
                    "servicePlanName": "SCHOOL_DATA_SYNC_P2",
                    "provisioningStatus": "Success",
                    "appliesTo": "User"
                }
            ]
        }
    ]
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List licenseDetails",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


