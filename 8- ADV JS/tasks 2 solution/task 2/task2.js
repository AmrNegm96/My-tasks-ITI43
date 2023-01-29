///Create object -> object literal 
///              -> objects factory
///              -> object  construction (new key word) 

var Rectangle = function (w = h, h=w ) {
    this.width = w;
    this.height = h;
/// used reference (function shared pattern to decrease code lines inside class)
    this.area = Calarea ;
    this.perimeter = Calperimeter;
    this.displayInfo = displayInfo ;
}

function Calarea () {
    console.log("Area is : " + this.width * this.height);
}

function Calperimeter () {
    console.log("Perimeter is : " + ((this.width + this.height)*2));
} 
function displayInfo  () {
    console.log("Width is : " + this.width);
    console.log("Height is : " + this.height);
    // console.log("Area is : " + this.width * this.height);
    // console.log("Perimeter is : " + ((this.width + this.height)*2));

     console.log("Area is : " +(this.area()));
     console.log("Perimeter is : " +(this.perimeter()));
}

var rect1 = new Rectangle(5,10 );
var rect2 = new Rectangle(10, 15);
var rect3 = new Rectangle(10);



rect1.displayInfo();

console.log("///////////////////////////////////////////////////////////////")

rect2.displayInfo();

console.log("///////////////////////////////////////////////////////////////")

rect3.displayInfo();

