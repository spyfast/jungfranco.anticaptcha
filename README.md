# Jung Franco AntiCaptcha

[Telegram](https://t.me/jungfranco)
[VK](https://vk.com/spyfast)

Библиотека для работы с антикапчей (API rucaptcha.com и anti-captcha.com (ex anti-gate)

## Как использовать?

``` C#
using JungFranco.AntiCaptcha;
using JungFranco.AntiCaptcha.CapLib;
using System.Threading;
using System.Net;
//...

var reqestId = new Random().Next().ToString();
var filename = $"{reqestId}.png";
new WebClient().DownloadFile(url, filename);

var host = "https://rucaptcha.com";
var key = "Ключ антикапчи";

CaptchaClient cc = new CaptchaClient(host, key);
var capId = cc.UploadCaptchaFile(filename);
File.Delete(filename);

var answer = null;

while (string.IsNullOrEmpty(answer))
{
    Thread.Sleep(1000);
    try
    {
         answer = cc.GetCaptcha(capId);
    }
    catch (Exception ex)
    {

    }
}

return answer;
```

## Получить баланс ключа антикапчи?
``` C#
var cc = new CaptchaClient("https://rucaptcha.com", "КЛЮЧ");
Console.WriteLine(cc.GetBalance());
```
