# ArrowSphereApiDotNet
ArrowSphere API for .Net

.Net implementation of ArrowSphere API: https://xsp.arrow.com/apidoc/


## Basic usage

Set up dependency injection.

```c#
using ArrowSphereApiDotNet;


var apiKey = config.GetValue<string>("Arrow:ApiKey");
builder.Services.AddArrow(apiKey);

```

```
// inject ArrowClient
private ArrowClient _client;

// get client object for calling API methods
var client = _client.GetPartnersClient();

var rs = await client.WhoAmI();

```
