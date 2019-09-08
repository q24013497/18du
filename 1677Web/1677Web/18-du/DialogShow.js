//微信弹出框
DailoagConfirm = function (msginfo,okurl) {
    var idtemp = "confirm_" + Math.random();
    this.showHTml = function () {
        var html = '<div class="weui_dialog_confirm" id="wxconfirmdialog">';
        html += '<div class="weui_mask"></div>'
        html += '<div class="weui_dialog">'
        html += '<div class="weui_dialog_hd"><strong class="weui_dialog_title">提示</strong></div>';

        html += '<div class="weui_dialog_bd">' + msginfo + '</div>';
        html += '<div class="weui_dialog_ft">';
        html += '<a href=\'javascript:$("#wxconfirmdialog").fadeOut(100);\' class="weui_btn_dialog default">取消</a>';
        var ok = ((okurl == "" || typeof (okurl)=="undefined")? "javascript:$('#wxconfirmdialog').fadeOut(100);" : okurl);
        html += '<a href="' + ok + '" class="weui_btn_dialog primary">确定</a>';
        html += '</div></div></div>';
        return html;
    }

    this.DailoagConfirmOpen = function () {
        var html = this.showHTml();
        $("#wxconfirmdialog").remove();
        $("body").append(html);
        $("#wxconfirmdialog").fadeIn(100);
    }
}


function ShowWxMsg(msginfo,okurl) {
    var win_ = new DailoagConfirm(msginfo,okurl);
    win_.DailoagConfirmOpen();
}

//微信弹出框end




//PC弹出框
DailoagPCConfirm = function (msginfo, okurl) {
    var idtemp = "pcconfirm_" + Math.floor(Math.random() * 100);
    this.showHTml = function () {
        var html = '<div class="popup_total" style="display:none" id="pcconfirm">'
        html += '<div class="popup_center">';
        html += '<div class="popup_center_top">提示</div>';
        html += '<div class="popup_center_center"><center>' + msginfo + '</center></div>';
        html += '<div class="popup_center_buttom">';
        var ok = ((okurl == "" || typeof (okurl) == "undefined") ? "javascript:$('#pcconfirm').fadeOut(100);" : "javascript:location.href='" + okurl + "'");
        html += '<input class="popup_ok" type="button" value="确定" onclick="' + ok + '">';
        html += '<input class="popup_cancal" type="button" value="取消" onclick=\'javascript:$("#pcconfirm").fadeOut(100);\' />';
        html += '</div></div></div>';
        return html;
    }

    this.DailoagPCConfirmOpen = function () {
        var html = this.showHTml();
        $("#pcconfirm").remove();
        $("body").append(html);
        $("#pcconfirm").fadeIn(100);
    }
}

function ShowPCMsg(msginfo, okurl) {
    var win_ = new DailoagPCConfirm(msginfo, okurl);
    win_.DailoagPCConfirmOpen();
}

//注册协议弹出框、免责声明pc端
DailoagAgreementConfirm = function (msginfo, okurl) {
    var idtemp = "pcconfirm_" + Math.floor(Math.random() * 100);
    this.showHTml = function () {
        var html = '<div class="popup_total" style="display:none" id="pcconfirm">'
        html += '<div class="popup_center">';
        html += '<div class="popup_center_top">提示</div>';
        html += '<div class="popup_center_center" style="height: 300px;overflow-y: scroll;"><center>' + msginfo + '</center></div>';
        html += '<div class="popup_center_buttom">';
        var ok = ((okurl == "" || typeof (okurl) == "undefined") ? "javascript:$('#pcconfirm').fadeOut(100);" : "javascript:location.href='" + okurl + "'");
        html += '<input class="popup_ok" type="button" value="确定" onclick="' + ok + '">';
        html += '<input class="popup_cancal" type="button" value="取消" onclick=\'javascript:$("#pcconfirm").fadeOut(100);\' />';
        html += '</div></div></div>';
        return html;
    }

    this.DailoagPCConfirmOpen = function () {
        var html = this.showHTml();
        $("#pcconfirm").remove();
        $("body").append(html);
        $("#pcconfirm").fadeIn(100);
    }
}
function ShowAgreementMsg(msginfo, okurl) {
    var win_ = new DailoagAgreementConfirm(msginfo, okurl);
    win_.DailoagPCConfirmOpen();
}


//注册协议弹出框、免责声明微信端
DailoagWXAgreementConfirm = function (msginfo, okurl) {
    var idtemp = "confirm_" + Math.random();
    this.showHTml = function () {
        var html = '<div class="weui_dialog_confirm" id="wxconfirmdialog">';
        html += '<div class="weui_mask"></div>'
        html += '<div class="weui_dialog">'
        html += '<div class="weui_dialog_hd"><strong class="weui_dialog_title">提示</strong></div>';

        html += '<div class="weui_dialog_bd" style="height: 300px;overflow-y: scroll;">' + msginfo + '</div>';
        html += '<div class="weui_dialog_ft">';
        html += '<a href=\'javascript:$("#wxconfirmdialog").fadeOut(100);\' class="weui_btn_dialog default">取消</a>';
        var ok = ((okurl == "" || typeof (okurl) == "undefined") ? "javascript:$('#wxconfirmdialog').fadeOut(100);" : okurl);
        html += '<a href="' + ok + '" class="weui_btn_dialog primary">确定</a>';
        html += '</div></div></div>';
        return html;
    }

    this.DailoagConfirmOpen = function () {
        var html = this.showHTml();
        $("#wxconfirmdialog").remove();
        $("body").append(html);
        $("#wxconfirmdialog").fadeIn(100);
    }
}
function ShowWXAgreementMsg(msginfo, okurl) {
    var win_ = new DailoagWXAgreementConfirm(msginfo, okurl);
    win_.DailoagConfirmOpen();
}

//PC弹出框end

WXLoadding = function (msg, second) {
    this.showHTml = function () {
        var html = '<div id="loadingToast" class="weui_loading_toast" style="display:none;">';
        html += '<div class="weui_mask_transparent"></div>';
        html += '<div class="weui_toast">';
        html += '<div class="weui_loading">';
        html += '<div class="weui_loading_leaf weui_loading_leaf_0"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_1"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_2"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_3"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_4"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_5"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_6"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_7"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_8"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_9"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_10"></div>';
        html += '<div class="weui_loading_leaf weui_loading_leaf_11"></div>';
        html += '</div>';
        html += '<p class="weui_toast_content">' + msg + '</p>';
        html += '</div></div>';
        return html;
    }
    //显示几秒后关闭
    this.Preview = function () {
        var html = this.showHTml();
        $("#loadingToast").remove();
        $("body").append(html);
        $("#loadingToast").show();
        setTimeout(function () {
            $('#loadingToast').hide();
        }, second);
    }
    this.Show = function () {
        var html = this.showHTml();
        $("#loadingToast").remove();
        $("body").append(html);
        $("#loadingToast").show();
    };
    this.Hide = function () {
        if ($("#loadingToast").length>0)
          $("#loadingToast").remove();
    }
}

function PreviewLoading(msg,second) {
    var win_ = new WXLoadding(msg, second);
    win_.LoaddingOpen();
}

function ShowLoading(msg) {
    var win_ = new WXLoadding(msg, 0);
    win_.Show();
}

function HideLoading() {
    var win_ = new WXLoadding("", 0);
    win_.Hide();
}


//Toast
WxShowToast = function (msg, second) {
    this.showHTml = function () {
        var html = '<div id="wxtoast" style="display:none;">';
        html += '<div id="toast" style="display:;">';
        html += '<div class="weui_mask_transparent"></div>';
        html += '<div class="weui_toast" style="top:45%;left:45%;width:18em;min-height:5em;z-index:30">';
        html += '<i class=""></i>';
        html += '<p style="margin-top:25px" class="weui_toast_content">' + msg + '</p>'
        html += '</div>';
        html += '</div>';

        return html;
    }

    this.Preview = function () {
        var html = this.showHTml();
        $("#wxtoast").remove();
        $("body").append(html);
        $("#wxtoast").show();
        setTimeout(function () {
            $('#wxtoast').hide();
        }, second);
    }
}

function ShowToast(msg, second) {
    var win_ = new WxShowToast(msg, second);
    win_.Preview();
}

