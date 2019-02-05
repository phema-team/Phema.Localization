## Phema.Localization
- `ILocalizationComponent<TModel>` : `IModelLocalizationComponent` : `*ModelLocalizationComponent`
```csproj
// Add
services.AddPhemaLocalization(configuration =>
	configuration.AddCulture(CultureInfo.GetCultureInfo("en", culture =>
		culture.AddComponent<Model, IModelLocalizationComponent, EnglishModelLocalizationComponent>()),
	configuration.AddCulture(CultureInfo.GetCultureInfo("ru"), culture =>
		culture.AddComponent<Model, IModelLocalizationComponent, RussianModelLocalizationComponent>())));

// Get
var localizer = serviceProvider.GetRequiredService<ILocalizer>();

// Use
var message = localizer.Localize<IModelLocalizationComponent>(c => c.SomeMessage);
```

## Phema.Localization.Cultures
- Set of extension methods for culture configuration
```csharp
services.AddPhemaLocalization(configuration =>
	configuration.AddEnglishCulture(culture => {}));
```
