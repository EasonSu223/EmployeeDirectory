# Employee Directory

ASP.NET Core (.NET 10) Web API + jQuery 前端 + SQLite 的全端小專案。
前端透過 API 讀取並更新員工資料（Name / eMail / Role）。

## 技術
- 後端：ASP.NET Core Web API、Entity Framework Core、SQLite
- 前端：HTML + jQuery（呼叫 REST API）
- API 文件：Swagger

## 如何執行
1. 安裝 .NET 10 SDK
2. git clone https://github.com/EasonSu223/EmployeeDirectory.git
3. cd EmployeeDirectory
4. dotnet run
5. 打開瀏覽器 https://localhost:<port>/html/index.html

## API
| 方法 | 路徑 | 說明 |
|------|------|------|
| GET  | /api/employees      | 取得全部員工 |
| GET  | /api/employees/{id} | 取得單一員工 |
| PUT  | /api/employees/{id} | 更新員工 |