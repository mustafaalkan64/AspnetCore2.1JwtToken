# AspnetCore2.1JwtToken
This project provides a simple example of JWT using with AspnetCore 2.1
<br/>
This project referenced from :
<br/>
http://jasonwatmore.com/post/2018/08/14/aspnet-core-21-jwt-authentication-tutorial-with-example-api
<br/>
<br/>
Sample username and password exists in UserService.cs. You can edit and use yourselves to authanticate.
<br/>
<br/>
An important point you shouldn't miss out that, while you are creating a JWT, you need a secret key. And this secret key exists in AppSetting in appsettings.json
in your project. You can set any string or alphanumeric characters to Secret key.
<br/>
```
"AppSettings": {
    "Secret": "Amfewlv24356340dsdlw3423kdadak435321kjiswqjx125439ad23kdfjsfsf4"
  }
```
<br/>
<br/>

Firstly you should post your authenticate method with user parameters in body.
<br/>
**İmportant**
<br/>
You must select **raw** and **JSON** options while sending post method in body if you use Postman.
<br/>
Your Json should be like below:
<br/>
```
{ 
 "Username":"mustafa.alkan",
 "Password":"alkan123"
}
```
After you get token from result, you will add to your method's header like below:
<br/>

**Headers**
<br/>

| Key           | Value              |
| ------------- |:------------------:|
| Content-Type  | application/json   |
| Authorization | Bearer {YourToken} |

