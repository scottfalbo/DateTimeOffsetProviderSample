// ------------------------------------
// DateTimeOffsetProvider Sample
// ------------------------------------

using DateTimeOffsetProviderSample;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<IDateTimeOffsetProvider, DateTimeOffsetProvider>();
services.AddSingleton<IDateTimeComparer, DateTimeComparer>();