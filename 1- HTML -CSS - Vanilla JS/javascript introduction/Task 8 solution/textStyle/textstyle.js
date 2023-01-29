var para = document.getElementById("txt1");

function ChangeFont(fontType){

    var fontRD = document.getElementsByName("Font") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.fontFamily = fontType ;
        }
    }
}

function ChangeAlign(alignType){

    var fontRD = document.getElementsByName("Align") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.textAlign = alignType ;
        }
    }

}

function ChangeHeight(heightType){

    var fontRD = document.getElementsByName("Height") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.fontSize = heightType ;
        }
    }

}

function ChangeLSpace(spaceType){

    var fontRD = document.getElementsByName("Lspace") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.letterSpacing = spaceType ;
        }
    }

}

function ChangeIndent(indentType){

    var fontRD = document.getElementsByName("Indent") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.textIndent = indentType ;
        }
    }

}

function ChangeTransform(caseType){
    var fontRD = document.getElementsByName("Transform") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.textTransform = caseType ;
        }
    }

}

function ChangeDecorate(decorType){
    var fontRD = document.getElementsByName("Decorate") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.textDecorationLine = decorType ;
        }
    }


}

function ChangeBorder(borderType){
    var fontRD = document.getElementsByName("Border") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.border = borderType ;
        }
    }


}

function ChangeBorderColor(borderColor){
    var fontRD = document.getElementsByName("Transform") ; 

    for(var i=0 ; i<fontRD.length ; i++)
    {
        if(fontRD[i].checked)
        {
            para.style.borderColor = borderColor ;
        }
    }


}
