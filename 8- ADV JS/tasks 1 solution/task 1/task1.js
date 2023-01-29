var linkedListObject = {

    data : [{val: null}] , 

    x : {val: null}, 

    enqueueVal : function (input){
        
        if(this.data[0].val === null)
        {
            this.data[0].val = input ;
            console.log("Element added");
        }
        else
        {
            if(input>this.data[(this.data.length-1)].val )
            {
                this.data.push({val : input});
                console.log("Element added");
            }
            else
            {
                throw new RangeError("You should choose number bigger than "+ this.data[this.data.length-1].val );
            }
        }
    },

    insertVal : function (input){

        for(var i=0 ; i<this.data.length ; i++)
        {
            this.x.val = input;
            if (this.data[i].val === this.x.val)
            {
                throw new Error ("The number is already in the list");
            }
        }

        if(this.data[0].val === null)
        {
            this.data[0].val = input ;
            console.log("Element added");
        }
        else if (input<this.data[0].val)
        {
            this.data.unshift({val:input});
            console.log("Element added");

        }
        else if (input>this.data[(this.data.length-1)].val)
        {
            this.data.push({val : input});
            console.log("Element added");
        }
        else
        {
            for(var i=0 ; i<this.data.length ; i++)
            {
                if(this.data[i].val < input && this.data[i+1].val > input )
                {
                    this.data.splice( i+1 , 0 , {val:input} );
                    console.log("Element added");
                }
            }
        }
    },

    popVal : function (){
        this.data.pop();
        console.log("Element removed");
    },

    dequeueVal : function (){
        this.data.shift();
        console.log("Element removed");
    },
    
    

    
    removeVal : function (input){
        for(var i=0 ; i<this.data.length ; i++)
        {
            if(this.data[i].val == input)
            {
                this.data.splice(i , 1) ;
                console.log("Element removed");
            }
        }
    },

    displayVals : function (){

        for(var i=0 ; i<this.data.length ; i++)
        {   
            console.log("The elements are: "); 
            console.log(this.data[i]);   
        }
    },

    

}


/// enqueue 
//linkedListObject.enqueueVal(5);
//linkedListObject.enqueueVal(6);
//linkedListObject.enqueueVal(4);
//console.log(linkedListObject.data);

/// insert 
linkedListObject.insertVal(2);
linkedListObject.insertVal(8);
linkedListObject.insertVal(5);
/////// linkedListObject.insertVal(8); how to handle ==???

///pop
//linkedListObject.popVal();

///dequeue
//linkedListObject.dequeueVal();

console.log(linkedListObject.data);