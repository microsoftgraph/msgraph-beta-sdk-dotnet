---
title: "authenticationMethodsRoot: usersRegisteredByMethod"
description: "Get the number of users registered for each authentication method."
author: "besiler"
ms.localizationpriority: medium
ms.prod: "identity-and-access-reports"
doc_type: apiPageType
---

# authenticationMethodsRoot: usersRegisteredByMethod
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the number of users registered for each authentication method.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|AuditLog.Read.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

In order to access the API, [one of the following roles](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#available-roles) is required:

* Reports reader
* Security reader
* Security admin
* Global reader
* Global admin

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /reports/authenticationMethods/usersRegisteredByMethod
```

## Function parameters
The following table shows the parameters that can be used with this function.

|Parameter|Type|Description|
|:---|:---|:---|
|includedUserTypes|includedUserTypes|User type. Possible values are: `all`, `member`, `guest`.|
|includedUserRoles|includedUserRoles|User role type. Possible values are: `all`, `privilegedAdmin`, `admin`, `user`.|

The value `privilegedAdmin` consists of the following privileged admin roles:

* Global admin
* Security admin
* Conditional Access admin
* Exchange admin
* SharePoint admin
* Helpdesk admin
* Billing admin
* User admin
* Authentication admin

The value `admin` includes all Azure AD admin roles. 

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this function returns a `200 OK` response code and a [userRegistrationMethodSummary](../resources/userregistrationmethodsummary.md) in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "authenticationmethodsroot_usersregisteredbymethod"
}
-->
``` http
GET https://graph.microsoft.com/beta/reports/authenticationMethods/usersRegisteredByMethod(includedUserTypes='all',includedUserRoles='all')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var userRegistrationMethodSummary = await graphClient.Reports.AuthenticationMethods
	.UsersRegisteredByMethod(IncludedUserTypes.All,IncludedUserRoles.All)
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
  "@odata.type": "microsoft.graph.userRegistrationFeatureSummary"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
	"@odata.type": "#microsoft.graph.userRegistrationMethodSummary",
	"userTypes": "all",
	"userRoles": "all",
	"userRegistrationMethodCounts": [{
			"authenticationMethod": "password",
			"userCount": 12209
		},
		{
			"authenticationMethod": "windowsHelloForBusiness",
			"userCount": 223
		},
		{
			"authenticationMethod": "mobilePhone",
			"userCount": 4234
		}
	]
}
```
