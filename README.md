# Make models

Create model from database with the tables instanced
```
Scaffold-DbContext "Server=[NameServer]; Database=[NameDataBase]; Trusted_Connecton=True; " Microsoft.EntityFramework.SqlServer -OutputDir Models
```

Example:
```
Scaffold-DbContext "Server=AMITTLP0764; Database=bd1; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

For overwrite the models execute `-force`
```
Scaffold-DbContext "Server=[NameServer]; Database=[NameDataBase]; Trusted_Connecton=True; " Microsoft.EntityFramework.SqlServer -OutputDir Models -force
```

## Include in json 
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
  "ConnectionStrings": {
    "PubContext": "Server=AMITTLP0764; Database=bd1; Trusted_Connection=True;"
  }
}
```

## Create controller in VS

For created controller selection the directory Controller (Click-right) and select Add -> Controller, after select MVC -> clean controller. In the next windows writed the name of controller. The name is [NameController]Controller.

Example: BrandController, BearController, BeerController, etc.

## Change Layout
For add new layout: 
``` 
@{
  Layout=""
}
```
For remove default layout:
```
@{
  Layout=null
}
```




