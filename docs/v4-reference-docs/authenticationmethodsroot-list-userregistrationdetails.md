---
title: "List userRegistrationDetails"
description: "Get a list of the authentication methods registered for the user as defined in the userRegistrationDetails object."
author: "besiler"
ms.localizationpriority: medium
ms.prod: "identity-and-access-reports"
doc_type: apiPageType
---

# List userRegistrationDetails
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the authentication methods registered for the user as defined in the [userRegistrationDetails](../resources/userregistrationdetails.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|UserAuthenticationMethod.Read.All and AuditLog.Read.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|UserAuthenticationMethod.Read.All and AuditLog.Read.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /reports/authenticationMethods/userRegistrationDetails
```

## Optional query parameters
This method supports only the `$filter` and `$orderBy` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [userRegistrationDetails](../resources/userregistrationdetails.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_userregistrationdetails"
}
-->
``` http
GET https://graph.microsoft.com/beta/reports/authenticationMethods/userRegistrationDetails
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userRegistrationDetails = await graphClient.Reports.AuthenticationMethods.UserRegistrationDetails
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
  "@odata.type": "Collection(microsoft.graph.userRegistrationDetails)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#reports/authenticationMethods/userRegistrationDetails",
    "value": [
        {
            "id": "86462606-fde0-4fc4-9e0c-a20eb73e54c6",
            "userPrincipalName": "AlexW@Contoso.com",
            "userDisplayName": "Alex Wilber",
            "isAdmin": false,
            "isSsprRegistered": false,
            "isSsprEnabled": false,
            "isSsprCapable": false,
            "isMfaRegistered": true,
            "isMfaCapable": true,
            "isPasswordlessCapable": false,
            "methodsRegistered": [
                "microsoftAuthenticatorPush",
                "softwareOneTimePasscode"
            ],
            "defaultMethod": "microsoftAuthenticatorPush",
            "userType": "member"
        },
        {
            "id": "c6ad1942-4afa-47f8-8d48-afb5d8d69d2f",
            "userPrincipalName": "AllanD@Contoso.com",
            "userDisplayName": "Allan Deyoung",
            "isAdmin": false,
            "isSsprRegistered": false,
            "isSsprEnabled": false,
            "isSsprCapable": false,
            "isMfaRegistered": false,
            "isMfaCapable": false,
            "isPasswordlessCapable": false,
            "methodsRegistered": [],
            "defaultMethod": "", 
            "userType": "guest"  
        },
        {
            "id": "c8096958-797c-44fa-8fde-a6fb62567cf0",
            "userPrincipalName": "BiancaP@Contoso.com",
            "userDisplayName": "Bianca Pisani",
            "isAdmin": false,
            "isSsprRegistered": true,
            "isSsprEnabled": false,
            "isSsprCapable": false,
            "isMfaRegistered": true,
            "isMfaCapable": true,
            "isPasswordlessCapable": false,
            "methodsRegistered": [
                "mobilePhone",
                "microsoftAuthenticatorPush",
                "softwareOneTimePasscode"
            ],
            "defaultMethod": "mobilePhone",
            "userType": "member"
        }
    ]
}
```

