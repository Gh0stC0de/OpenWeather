# OpenWeather
A .NET SDK for the OpenWeather API.

## Usage
```csharp
var settings = new WeatherSettings("My_API_Key", Measurement.Metric, "en");

var service = new OpenWeatherService(settings);

OneCallResponse response = await service.GetOneCallResponse(47.37174, 8.54226);
```

## Limitations
The function is currently limited to the OneCall API only. If any other features are requesteddo not mind opening an issue.