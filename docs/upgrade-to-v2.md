# Microsoft Graph Beta .NET SDK v2 changelog and upgrade guide

The purpose of this document is to outline any breaking change and migration work SDK users might run into while upgrading to the v4 of the SDK.

## Breaking changes

To improve the development experience provided by the SDK, it was necessary to make the following breaking changes in addition to the changes listed in the migration guide below:

 * .NET Standard minimum version bumped from `netstandard1.3` to `netstandard2.0`
 * .NET Framework minimum version bumped from `net45` to `net461`
 * Replacing Newtonsoft.Json dependency with System.Text.Json for serialization/de-serialization
 * Upgrading Microsoft.Graph.Core dependency to version 2.0.0

## Upgrade guide for breaking changes

The following section lists out the breaking changes requiring code changes from SDK users.

### System.Text.Json replaces Newtonsoft.Json

Updating to the latest version of the library involves the migration from [Newtonsoft.Json](https://www.newtonsoft.com/json) to System.Text.Json. You can always read more about the differences between the two libraries [here](https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-migrate-from-newtonsoft-how-to?pivots=dotnet-5-0#table-of-differences-between-newtonsoftjson-and-systemtextjson).

From the SDK developer experience, these are the main changes to look out for when upgrading.

1. Object types and function parameters using Newtonsoft's JToken are now replaced by System.Text.Json's JsonDocument.

  For example, the code sample :-

```cs
GraphServiceClient graphClient = new GraphServiceClient( authProvider );

int index = 5;

JToken values = JToken.Parse("[[1,2,3],[4,5,6]]");

await graphClient.Me.Drive.Items["{id}"].Workbook.Tables["{id|name}"].Rows
	.Add(index,values)
	.Request()
	.PostAsync();
```

  would change to :-

```cs
GraphServiceClient graphClient = new GraphServiceClient( authProvider );

int index = 5;

JsonDocument values = JsonDocument.Parse("[[1,2,3],[4,5,6]]");

await graphClient.Me.Drive.Items["{id}"].Workbook.Tables["{id|name}"].Rows
	.Add(index,values)
	.Request()
	.PostAsync();
```

2. Objects present in the AdditionalData bag are now of type JsonElement from System.Text.Json rather than Newtonsoft's derivatives of JToken(i.e JArray, String or JObject)

You can always infer if the JsonElement is an array/string/boolean/object from the [ValueKind](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonvaluekind?view=net-5.0) property and then call a relevant method to get the value (e.g [GetString()](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement.getstring?view=net-5.0#System_Text_Json_JsonElement_GetString) or [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement.tostring?view=net-5.0#System_Text_Json_JsonElement_ToString) if you have inferred the element is a string.)

You can find other relevant JsonElement methods [here](https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement?view=net-5.0#methods).

3. System.Text.Json enforces stricter json standards than Newtonsoft (e.g. trailing commas and comments are not allowed). 

In the event a user would like to use this, you can check out the guide [here](https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-invalid-json?pivots=dotnet-5-0) and use it to override the current default serializer options.

For example:-
```cs
// Add extra options
var options = new JsonSerializerOptions
{
    ReadCommentHandling = JsonCommentHandling.Skip,
    AllowTrailingCommas = true,
};

Serializer serializer = new Serializer(options);
IResponseHandler responseHandler = new ResponseHandler(serializer); // Our Response Handler with custom Serializer

User me = await graphClient.Me.Request()
                .WithResponseHandler(responseHandler)
                .GetAsync();
```

### Azure Identity

The Microsoft Graph library now supports the use of TokenCredential classes in the Azure.Identity library through the new `TokenCredentialAuthProvider`.

You can read more about available Credential classes [here](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/identity-readme#key-concepts) and this is encouraged to be used in place of the `Microsoft.Graph.Auth` package. 

For example, rather than using the [Interactive provider](https://docs.microsoft.com/en-us/graph/sdks/choose-authentication-providers?tabs=CS#InteractiveProvider) from the `Microsoft.Graph.Auth` package, one could use the [InteractiveBrowserCredential](https://docs.microsoft.com/en-us/dotnet/api/azure.identity.interactivebrowsercredential?view=azure-dotnet) class from `Azure.Identity` as follows.

#### Example using Microsoft.Graph.Auth

```cs
IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
            .Create(clientId)
            .Build();

InteractiveAuthenticationProvider authProvider = new InteractiveAuthenticationProvider(publicClientApplication, scopes);

GraphServiceClient graphClient = new GraphServiceClient(authProvider);

User me = await graphClient.Me.Request()
                .GetAsync();
```

#### Example using TokenCredential class

```cs
InteractiveBrowserCredential myBrowserCredential = new InteractiveBrowserCredential(clientId);

TokenCredentialAuthProvider tokenCredentialAuthProvider = new TokenCredentialAuthProvider(myBrowserCredential, scopes);

GraphServiceClient graphClient = new GraphServiceClient(tokenCredentialAuthProvider);

User me = await graphClient.Me.Request()
                .GetAsync();
```
### IBaseRequest now takes IResponseHandler as a member

The `IBaseRequest` interface now has a new member of type `IResponseHandler`. Any existing code that derives from it will now have to take this into consideration.

### Graph Response

To enable SDK users to have easier access to response information like response headers and status codes, we have introduced the GraphResponse object which also involves the following new methods being added which correspond to the existing API methods.

* `GetResponseAsync(): : GraphResponse<T>`
* `CreateResponseAsync(NewObject: Entity) : GraphResponse<T>`
* `PostResponseAsync(NewObject: Entity) : GraphResponse<T>`
* `UpdateResponseAsync(UpdatedObject: Entity) : GraphResponse<T>`
* `DeleteResponseAsync() : GraphResponse`  (no generic here) 

Essentially, using the fluent APIs of the service libraries should remain the same as follows
```cs
User me = await graphClient.Me.Request()
                .GetAsync();
```

However, should you choose to want access to response headers and status codes a user can now do this.

```cs
GraphResponse<User> userResponse = await graphClient.Me.Request()
                                        .GetResponseAsync();

// Get the status code
HttpStatusCode status = userResponse.StatusCode;
// Get the headers
HttpResponseHeaders headers = userResponse.HttpHeaders;
// Get the user object using inbuilt serializer
User me = await response.GetResponseObjectAsync();
``` 

If you choose you can even deserialize the response in your own custom way as follows.

1. Use a custom IResponseHandler
```cs
ISerializer serializer = new CustomSerializer(); // Custom Serializer
IResponseHandler responseHandler = new ResponseHandler(serializer); // Our Response Handler with custom Serializer
    
GraphResponse<User> graphResponse = await graphServiceClient.Me.Request()
                                                    .WithResponseHandler(responseHandler) // customized response handler
                                                    .UpdateWithGraphResponseAsync<User>(patchUser, cancellationToken); // response with no serialization

User user = graphResponse.GetResponseObjectAsync(); // calls the Response Handler with custom serializer
```

2. Read the response and deserialize it.(Example using Newtonsoft)

```cs
GraphResponse<User> userResponse = await graphClient.Me.Request()
                .GetResponseAsync();

JsonSerializer serializer = new JsonSerializer(); // Custom serializer

using (StreamReader sr = new StreamReader(userResponse.Content.ReadAsStreamAsync()))
using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
{
    User deserializedProduct = serializer.Deserialize(jsonTextReader);
}

```

## Remarks about this guide

This guide is written to be as exhaustive as possible, it is possible that we forgot to mention some breaking changes. If you experience breaking changes in your upgrade process that are not already listed in this guide, please open an issue or a pull request to add any information that might be missing.
