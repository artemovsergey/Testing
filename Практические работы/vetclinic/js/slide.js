(function ($) {
    var hwSlideSpeed = 700;
    var hwTimeOut = 3000;
    var hwNeedLinks = true;
    var slilinkss = true;
    
    $(document).ready(function(e) {
        $('.slide').css(
            {"position" : "absolute",
             "top":'0', "left": '0'}).hide().eq(0).show();
        var slideNum = 0;
        var slideTime;
        slideCount = $("#slider .slide").size();
        var animSlide = function(arrow){
            clearTimeout(slideTime);
            $('.slide').eq(slideNum).fadeOut(hwSlideSpeed);
            if(arrow == "next"){
                if(slideNum == (slideCount-1)){slideNum=0;}
                else{slideNum++}
                }
            else if(arrow == "prew")
            {
                if(slideNum == 0){slideNum=slideCount-1;}
                else{slideNum-=1}
            }
            else{
                slideNum = arrow;
                }
            $('.slide').eq(slideNum).fadeIn(hwSlideSpeed, rotator);
            $(".control-slide.active").removeClass("active");
            $('.control-slide').eq(slideNum).addClass('active');
            }
    if(hwNeedLinks){
    var $linkArrow = $('<a id="prewbutton" href="#">&lt;</a><a id="nextbutton" href="#">&gt;</a>')
        .prependTo('#slider');
        $('#nextbutton').click(function(){
            animSlide("next");
            return false;
            })
        $('#prewbutton').click(function(){
            animSlide("prew");
            return false;
            })
    }
        var $adderSpan = '';
        $('.slide').each(function(index) {
                $adderSpan += '<span class = "control-slide">' + index + '</span>';
            });
        $('<div class ="sli-links">' + $adderSpan +'</div>').appendTo('#slider-wrap');
        $(".control-slide:first").addClass("active");
        $('.control-slide').click(function(){
        var goToNum = parseFloat($(this).text());
        animSlide(goToNum);
        });
        var pause = false;
        var rotator = function(){
                if(!pause){slideTime = setTimeout(function(){animSlide('next')}, hwTimeOut);}
                }
        $('#slider-wrap').hover(
            function(){clearTimeout(slideTime); pause = true;},
            function(){pause = false; rotator();
            });
        rotator();
    
    
    if (!slilinkss)  $('.sli-links').css({"display" : "none"});
    });
    })(jQuery);
	
	
	$(document).ready(function($) {
	$('.popup-open').click(function() {
		$('.popup-fade').fadeIn();
		return false;
	});	
	
	$('.popup-close').click(function() {
		$(this).parents('.popup-fade').fadeOut();
		return false;
	});		
 
	$(document).keydown(function(e) {
		if (e.keyCode === 27) {
			e.stopPropagation();
			$('.popup-fade').fadeOut();
		}
	});
	
	$('.popup-fade').click(function(e) {
		if ($(e.target).closest('.popup').length == 0) {
			$(this).fadeOut();					
		}
	});
});