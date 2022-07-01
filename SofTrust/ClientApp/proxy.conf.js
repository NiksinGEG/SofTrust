const { env } = require('process');

//const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
 // env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:42281';
const target = 'http://SofTrust.somee.com/publish';
const PROXY_CONFIG = [
  {
    context: [
      "/api/user",
   ],
    target: target,
    secure: false,
    changeOrigin: true
  }
]

module.exports = PROXY_CONFIG;
