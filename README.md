# Phema.Localization
 
 - [x] Core library
 - [x] AspNetCore integration
 - [x] Tests

# Using core
```csharp
var map = new Dictionary<CultureInfo, IDictionary<Type, Func<ILocalizationComponent>>>
{
 [CultureInfo.InvariantCulture] = new Dictionary<Type, Func<ILocalizationComponent>>
 {
  [typeof(ITestComponent)] = () => new InvariantCultureTestComponent()
 }
};
			
var localizer = new Localizer(CultureInfo.InvariantCulture, new LocalizationProvider(map));

var message = localizer.Localize<ITestComponent>(c => c.SomeMessage);

Assert.Equal("template", message);
```

# Using asp net core integration
```csharp

//Startup
services.AddLocalization(localizaztion =>
{
  localization.AddCulture(CultureInfo.InvariantCulture, culture =>
    culture.AddComponent<IMessageLocalizationComponent, InvariantMessageLocalizationComponent>());
    
  localization.AddCulture(CultureInfo.GetCultureInfo("en"), culture =>
    culture.AddComponent<IMessageLocalizationComponent, EnglishMessageLocalizationComponent>());
});
    
// When just inject ILocalizer and specify culture using `Accept-Language` http header or by `LocalizationOptions`
localizer.Localize<IMessageLocalizationComponent>(c => c.SomeLocalizationMessage);
```
