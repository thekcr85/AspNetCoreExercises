\# 📡 RequestResponseDemo (.NET 9)



This is a simple ASP.NET Core project built with .NET 9.  

It helps me practice how to handle HTTP requests and return responses using minimal APIs.



---



\## 🔍 What It Does



\- Defines basic endpoints like `/hello`, `/time`, and `/request`

\- Returns plain text or HTML responses

\- Shows how to inspect request data (method, headers, path)

\- Uses minimal API style with `WebApplication`



---



\## 📁 Endpoints



| Path        | Description                                  |

|-------------|----------------------------------------------|

| `/`         | Home page with links to other endpoints      |

| `/hello`    | Returns a greeting message                   |

| `/time`     | Returns current server time                  |

| `/request`  | Displays HTTP method, path, and headers      |



---



\## 🚀 How to Run



Make sure you have \[.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) installed.



Then run:



```bash

cd AspNetCoreExercises/RequestResponseDemo

dotnet run

```



The app runs on:



```

http://localhost:5256/

```



Try visiting the endpoints listed above in your browser.



---



\## ✍️ Author



Created by Michał while learning ASP.NET Core step by step.

