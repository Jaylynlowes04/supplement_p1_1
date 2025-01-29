dotnet new sln
dotnet new gitignore
dotnet new classlib -o ${1}
dotnet sln add "./${1}/${1}.csproj"
dotnet new xunit -o ${1}.Tests
dotnet sln add "./${1}.Tests/${1}.Tests.csproj"
dotnet add "./${1}.Tests/{1}.Tests.csproj" reference "./${1}/${1}.csproj"
