# TestDotNetCoreMVC
## 起動
docker-composeにて起動できるようにしています。   
``` docker-compose up -d ```

## 構成
- DB:Postgresql
- HTTPサーバ(リバースプロキシ):nginx
- Appサーバ:kestrel
- Webアプリフレームワーク:ASP.NET Core
