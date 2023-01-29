var List = function ( start , end , step ){

    this.start = start ;
    this.end = end ;
    this.step = step ;

    var Arr = [] ;

    this.getArr = function (){
        return Arr ;
    };

    this.setArray = function(){
        var value = this.start ;
        for (var i=0 ; i<Math.ceil(this.end/this.step) ; i++){

                if(Arr.length==0)
                {
                    Arr.push(value);
                    value += this.step;
                }
                else
                {
                    if(value <= this.end)
                    {
                        Arr.push(value)
                        value+=this.step;
                    }
                }
        }
    };

    Object.defineProperty(this, "popNum", {
        value: function () {
            if(this.getArr().length)
                this.getArr().pop()
        }
    });

    Object.defineProperty(this, "dequeueNum", {
        value: function () {
            if(this.getArr().length)
                this.getArr().shift()
        }
    });

    Object.defineProperty(this, "appendNum", {
        value: function (value) {
            if(this.getArr().length < Math.ceil(this.end/this.step))
            {
                if(value<=this.end)
                {
                    if(value == this.getArr()[this.getArr().length-1]+this.step)
                    this.getArr().push(value)
                }
                else
                {
                throw new RangeError("The number is not in the defined sequence")
                }
                
            }
            
            
        }
    });

    Object.defineProperty(this, "prependNum", {
        value: function (value) {
            if(this.getArr().length < Math.ceil(this.end/this.step))
            {
                if(value>=this.start)
                {
                if(value == this.getArr()[0]-this.step)
                    this.getArr().unshift(value)
                }
                else
                {
                throw new RangeError("The number is not in the defined sequence")
                }
            }
            
            
        }
    });

    List.prototype.toString = function (){
       for(var i=0 ; i<Math.ceil(this.end/this.step) ; i++)
       {
        var L = console.log(this.getArr()[i]);
       }
    };
    
    
}





var L1 = new List(1,10,1);

L1.setArray() ;

console.log("The list is "+L1.getArr());

