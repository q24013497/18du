function setCookie(name, value, sec) {
    var d = new Date();
    d.setTime(d.getTime() + sec * 1000);
    document.cookie = name + '=' + value + '; expires=' + d.toGMTString() + ";path=/";
}
function getCookie(name) {
    var arr = document.cookie.split('; ');
    for (var i = 0; i < arr.length; i++) {
        var temp = arr[i].split('=');
        if (temp[0] == name) {
            return temp[1];
        }
    }
    return '';
}
function removeCookie(name) {
    var d = new Date();
    d.setTime(d.getTime() - 10000);
    document.cookie = name + '=1; expires=' + d.toGMTString();
}


//获取验证码倒计时;
var countdown =selall= 10;
function settime(obj) {
    if (countdown == 0) {
        obj.removeAttribute("disabled");
        obj.value = "获取验证码";
        countdown = selall;
        return;
    } else {
        obj.setAttribute("disabled", true);
        obj.value = "重新发送(" + countdown + ")";
        countdown--;
    }
    setTimeout(function () {
        settime(obj)
    }
    , 1000)
}