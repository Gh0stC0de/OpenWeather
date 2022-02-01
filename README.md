# OpenWeather
A .NET SDK for the OpenWeather API.

## Usage
```csharp
var settings = new WeatherSettings("My_API_Key", Measurement.Metric, "en");

var service = new OpenWeatherService(settings);

OneCallResponse response = await service.GetOneCallResponse(47.37174, 8.54226);
```

## Limitations
The functionality is currently limited to the OneCall API only. If other features are requested do not mind opening an issue.