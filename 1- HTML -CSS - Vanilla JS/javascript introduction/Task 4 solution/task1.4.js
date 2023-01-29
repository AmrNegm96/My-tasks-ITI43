function fun1()
{
    var regexName = /^[a-zA-Z]{3,}$/i;
    var regexPhone = /^(02)[0-9]{8}$/;
    var regexMob = /^(01)[0-2][0-9]{8}/ ;
    var regexEmail = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;  //^[a-zA-Z](@)(gmail-hotmail-yahoo)(.)(com)$



            do
            {
                //alert("the name is not valid , please enter your name again without symbols or numbers");
                var name = prompt("please enter your name");
            }while(regexName.test(name)!=true)

            do
            {
                //alert("the phone is not valid , please enter phone number of 10 digits starts with 02");
                var phoneNum = prompt("please enter your phone number");
            }while(regexPhone.test(phoneNum)!=true)

            do
            {
                //alert("the mobile number is not valid , please enter number of 11 digits");
                var mobileNum = prompt("please enter your mobile number");
            }while(regexMob.test(mobileNum)!=true)

            do
            {
                //alert("the email address is not valid , please enter email like abc@abc.com");
                var emailAdd = prompt("please enter your email address");
            }while(regexEmail.test(emailAdd)!=true)

    var color = prompt("please choose color either red , green or blue ");

    document.write("<h1> User Info </h1> <hr>");
    if(regexName.test(name) && regexPhone.test(phoneNum) && regexMob.test(mobileNum) && regexEmail.test(emailAdd))
    {
        document.write((" name: ".fontcolor(color) + name 
        +"<br> phone: ".fontcolor(color) + phoneNum 
        +"<br> mobile: ".fontcolor(color) + mobileNum 
        +"<br> email: ".fontcolor(color) + emailAdd) );
    }
}

fun1();
