$(function () {
    clearchartcheck();
    //    if ($(".cart-main").children().length == 0) {
    //        $("#divsubmit").hide();
    //        $(".cart-main").html("<div style='margin-left:50%;'>购物车为空,快去选购商品吧</div>")
    //    }


    //        //选择店铺下的产品
    //        $("http://www.18-du.com/Utility/tool/div.shop").find("input[shopitem_01]")


    //整个购物车全选
    $("#J_SelectAllCbx1,#J_SelectAllCbx2").bind("click", function () {
        $("input[shopitem]:checkbox").attr("checked", this.checked);
        $("input[shopitem]:checkbox").siblings(":checkbox").attr("checked", this.checked);
        if ($(this).is(":checked")) {
            $("#J_SelectAllCbx1").parent("div").addClass("cart-checkbox-checked");
            $("#J_SelectAllCbx2").parent("div").addClass("cart-checkbox-checked");
            $("[shopallitem]:checkbox").parent("div").addClass("cart-checkbox-checked");
            $("input[shopitem]:checkbox").parent("div").addClass("cart-checkbox-checked");
        }
        else {
            $("#J_SelectAllCbx1").parent("div").removeClass("cart-checkbox-checked");
            $("#J_SelectAllCbx2").parent("div").removeClass("cart-checkbox-checked");
            $("[shopallitem]:checkbox").parent("div").removeClass("cart-checkbox-checked");
            $("input[shopitem]:checkbox").parent("div").removeClass("cart-checkbox-checked");
        }
        calallskusbyselect();
    })


    //店铺全选
    $("[shopallitem]:checkbox").bind("click", function () {
        var shopitem = $(this).attr("shopallitem");
        var childcbbox = $("input[shopitem='" + shopitem + "']:checkbox");
        var childcbboxdiv = childcbbox.parent("div");
        childcbbox.attr("checked", this.checked);
        childcbbox.siblings(":checkbox").attr("checked", this.checked);

        if ($(this).is(":checked")) {
            $(this).parent("div").addClass("cart-checkbox-checked");
            childcbboxdiv.addClass("cart-checkbox-checked");
        }
        else {
            $(this).parent("div").removeClass("cart-checkbox-checked");
            childcbboxdiv.removeClass("cart-checkbox-checked");
        }

        calallskusbyselect();
    });




    //单个商品单击变化状态
    $("input[shopitem]:checkbox").bind("click", function () {
        //包括隐藏按钮
        $(this).siblings(":checkbox").attr("checked", this.checked); ;

        var objlist = $("input[shopitem='" + $(this).attr("shopitem") + "']:checkbox");
        var parckobj = $("[shopallitem='" + $(this).attr("shopitem") + "']");
        var flag = (objlist.filter(":checked").length == objlist.length);
        parckobj.attr("checked", flag);

        $(this).is(":checked") ? $(this).parent("div").addClass("cart-checkbox-checked") : $(this).parent("div").removeClass("cart-checkbox-checked");
        flag ? parckobj.parent("div").addClass("cart-checkbox-checked") : parckobj.parent("div").removeClass("cart-checkbox-checked");

        calallskusbyselect();
    });


    $("a.reduce").bind("click", function () {
        var txtskuobj = $(this).siblings(".gmsl").find(".txtskunum");
        var num = txtskuobj.val();
        var curnum = (num > 1 ? parseInt(num - 1) : 1);
        calskutotal(txtskuobj.attr("skuid"), curnum);
    })

    $("http://www.18-du.com/Utility/tool/a.add").bind("click", function () {
        var txtskuobj = $(this).siblings(".gmsl").find(".txtskunum");
        console.log(txtskuobj.attr("skuid"))
        calskutotal(txtskuobj.attr("skuid"), parseInt(txtskuobj.val()) + 1);
    })
});

function clearchartcheck() {

    if ($(".cart-main").children().length == 0 || $(".cart-main .orders-list").children().length == 0) {
        $("#divsubmit").hide();
        $(".cart-main").html("<div style='margin-left:50%;'>购物车为空,快去选购商品吧</div>")
    }
}


//计算单个规格商品
function calskutotal(skuid, num) {
    var unitprice = $("#hidskuprice_" + skuid).val();
    $.post("http://www.18-du.com/API/SheYingProcess.ashx", { "action": "UpdateShopCartSkuStock", "skuid": skuid, "buynum": num }, function (data) {
        if (!data.Flag) {
            $(".txtskunum[skuid='" + skuid + "']").val(data.SkuCount);
            ShowPCMsg("当前剩余库存：" + data.SkuCount + "件");
        }
        else {
            $(".txtskunum[skuid='" + skuid + "']").val(num);
            $("#sptotal_" + skuid).html(parseFloat(num * unitprice).toFixed(2));
            calallskusbyselect();
        }

    }, 'json');
}

//删除单个规格商品
function delsku(skuid) {
    $.post("http://www.18-du.com/API/SheYingProcess.ashx", { "action": "RemoveShopCartSku", "skuid": skuid }, function (data) {
        if (!data.Flag)
            ShowPCMsg("删除失败");
        else {
            //$("div.item-list[skuid='" + skuid + "']").remove();

            var shopitem = $("div.item-list[skuid='" + skuid + "']").attr("shopitem");
            var length = $(".item-list[shopitem='" + shopitem + "']").length;
            //如果该店铺下只剩一条则连店铺信息一起删除
            if (length > 1)
                $("div.item-list[skuid='" + skuid + "']").remove();
            else
                $("div.j-holderorder[shopitem='" + shopitem + "']").remove();
            calallskusbyselect();
            clearchartcheck();
        }
    });
}

//计算所选中的商品总价
function calallskusbyselect() {
    var selectobjlist = $("[name='ck_product_sku']:checkbox:checked");
    var allprice = 0;
    selectobjlist.each(function () {
        var skuid = $(this).val();
        var unitprice = $("#hidskuprice_" + skuid).val();
        var buynum = $(".txtskunum[skuid='" + skuid + "']").val();
        allprice += parseFloat(unitprice * buynum);
    });
    $("#spselectallskunum").html(selectobjlist.length);
    $("#spselectallskuprice").html(allprice.toFixed(2));
}

//手动输入数量限制
function buynumkeydown(e, obj) {
    var isOk = false;
    var key = window.event ? e.keyCode : e.which;
    if ((key > 95 && key < 106) ||                  //小键盘上的0到9  
            (key > 47 && key < 60) ||                   //大键盘上的0到9  
            key == 8 || key == 9 || key == 46 || key == 37 || key == 39)    //不影响正常编辑键的使用
    {
        isOk = true;
    }
    else if (key == 13) {
        //....
    }
    else {
        if (window.event) {
            window.event.returnValue = false;
        }
        else {
            e.preventDefault();
        }
    }
    return isOk;
}

//手动输入0.6s后执行数量更新
function buynumcheck(obj) {
    if ($(obj).val() == "")
        $(obj).val("1");
    var skuid = $(obj).attr("skuid");
    setTimeout(function(){calskutotal(skuid, $(obj).val())},600);
}


//批量删除
function delskubybatch() {
    var selectobjlist = $("[name='ck_product_sku']:checkbox:checked");
    if (selectobjlist.length == 0) {
        ShowPCMsg("请选择后再删除");
        return false;
    }
    selectobjlist.each(function () {
        delsku($(this).val());
    })
}