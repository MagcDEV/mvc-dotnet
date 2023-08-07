# Game Store Api

## Starting Sql Server 
```powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -p 1433:1433 -v sqlvolumemvc:/var/opt/mssql -d --rm --name mssqlmvc mcr.microsoft.com/mssql/server:2022-latest
```

 ### Setting the conections string to secret manager
```powershell
$sa_password = "[SA PASSWORD HERE]"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localhost; Database=GameStore; User Id=sa; Password=$sa_password; TrustServerCertificate=True"
```
