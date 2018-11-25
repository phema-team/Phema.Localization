# Phema.Localization

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
