// JavaScript Document
//制作：凌陈亮，www.lingchenliang.com，QQ57404811
	//自动缩放图片尺寸，占满整个DIV，短的显示全，长的超出隐藏只显示部分，不够DIV宽高的则拉伸
	//参数：图片对象，最大宽度，最大高度
	function chgdivimgwh(obj,width,height){
		var image=new Image();
		image.src=obj.src; //获取图像路径
		var width1=image.width; //获取图像宽度
		var height1=image.height; //获取图像高度
		var a1=height1/width1; 
		var a2=height/width;  
		/*图片要显示的高度/宽度*/
		if(a1>a2){//高大于宽
			obj.width=width;
			obj.height=height1*width/width1;
			obj.style.marginTop='-' + Math.round((obj.height-height)/2)+ 'px';
		}else{//高小于宽
			obj.height=height;
			obj.width=width1*height/height1;
			obj.style.marginLeft='-' + Math.round((obj.width-width)/2)+ 'px';
		}
	}