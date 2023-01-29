$(".btn1").click(function () { 

    $("#Gallery").hide(0);
    $("#ComplainForm").hide(0);
    $("#ComplainText").hide(0);
    $("ul").hide(0);

    $("#About").show(0); 
})

$(".btn2").click(function () { 

    $("#ComplainForm").hide(0);
    $("#ComplainText").hide(0);
    $("ul").hide(0);
    $("#About").hide(0); 

    $("#Gallery").show(0);
    
})

$(".btn3").click(function () { 

    $("#ComplainForm").hide(0);
    $("#ComplainText").hide(0);
    $("#About").hide(0); 
    $("#Gallery").hide(0);

    $("ul").slideToggle(0);
})

$(".btn4").click(function () { 

    $("#ComplainText").hide(0);
    $("#About").hide(0); 
    $("#Gallery").hide(0);
    $("ul").hide(0);

    $("#ComplainForm").show(0);
})

$("#btnComplain").click(function () { 

    // $("#Name").change(function(){
    //     $("#Name").attr("value") =  
    // });
    // var name = $("#Name").val();
    var name = $("#Name").val();
    var email = $("#Email").val();
    var phone = $("#Phone").val();
    var complain = $("#Compl").val();
    

    $("#ComplainText").hide(0);
    $("#About").hide(0); 
    $("#Gallery").hide(0);
    $("ul").hide(0);
    $("#ComplainForm").hide(0);

    $("#ComplainText").show(0);

    $("#NameField").text(name);
    $("#ComplainField").text(complain);
    $("#EmailField").text(email);
    $("#PhoneField").text(phone);
})

$("#btnBacktoComplain").click(function () { 

    $("#About").hide(0); 
    $("#Gallery").hide(0);
    $("ul").hide(0);
    $("#ComplainText").hide(0);
    $("#ComplainForm").show(0);
})

var counter = 1;

$(".imgR").click(function(){

    counter++;

    if(counter==9)
    {
        counter=1;
    }

    $(".mainImage").attr("src","../images/"+ counter +".jpg");
    
})

$(".imgL").click(function(){

    counter--;

    if(counter==0)
    {
        counter=8; 
    }
    $(".mainImage").attr("src","../images/"+ counter +".jpg");
})

