var video = document.getElementsByTagName("video")[0];

var progress = document.getElementById("progress");

progress.addEventListener("change",function(){
    video.currentTime = progress.value ;
})



var currentT = document.getElementById("current");


var playbtn = document.getElementById("play");

        playbtn.addEventListener("click",function(){
            video.play();
            
            var t = setInterval(function(){

                progress.value = video.currentTime;

                if(video.currentTime<60)
                {
                    currentT.innerHTML= "00:"+Math.floor(video.currentTime);
                }
                else if(video.currentTime>60)
                {
                    currentT.innerHTML= "01:"+Math.floor(video.currentTime-60);
                }
                
            },1000)

        });

var stopbtn = document.getElementById("stop");

        stopbtn.addEventListener("click",function(){
            video.pause();
            clearInterval(t);
        });  
        
var go2startbtn = document.getElementById("gotostart");

        go2startbtn.addEventListener("click",function(){
            video.currentTime = 0;
            clearInterval(t);
        });

var go2endtbtn = document.getElementById("gotoend");

        go2endtbtn.addEventListener("click",function(){
            video.currentTime = 96;
            clearInterval(t);
        });

var goback5btn = document.getElementById("goback-5sec");

        goback5btn.addEventListener("click",function(){
            video.currentTime = video.currentTime - 5 ;
        });

var gofront5btn = document.getElementById("gofront-5sec");

        gofront5btn.addEventListener("click",function(){
            video.currentTime = video.currentTime + 5;
        });

var mutebtn = document.getElementById("mute");

        mutebtn.addEventListener("click",function(){
            if(video.muted==false)
            {
                mutebtn.innerHTML="unmute"
                video.muted=true;
            }
            else if(video.muted==true)
            {
                mutebtn.innerHTML="mute"
                video.muted=false;
            }
        });        

var speed = document.getElementById("speed");

        speed.addEventListener("change",function(){
            video.playbackRate = speed.value;
        });

var vol = document.getElementById("volume");

        vol.addEventListener("change",function(){
            video.volume = vol.value;
        });
