FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatternAppDecorator
COPY PatternAppDecorator . 

RUN dotnet restore
RUN dotnet publish "PatternAppDecorator.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatternAppDecorator.dll" ]