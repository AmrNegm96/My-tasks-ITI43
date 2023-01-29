var Book = function (title, numOfChapters, author, numOfPages, publisher, numOfCopies) {
    
    Object.defineProperties(this, {
        numOfCopies: 
        {
            value: numOfCopies,
            writable: true,
        }
    });

    Object.defineProperties(this, {
        title: 
        {
            value: title,
        }
    });


    Object.defineProperties(this, {
        numOfChapters: 
        {
            value: numOfChapters,
        }
    });

    Object.defineProperties(this, {
        author: 
        {
            value: author,
        }
    });

    Object.defineProperties(this, {
        numOfPages: 
        {
            value: numOfPages,
        }
    });

    Object.defineProperties(this, {
        publisher: {
            value: publisher,
        }
    })
};

var Box = function (height, width, length, material, content) {

    Object.defineProperties(this, {
        height: {
            value: height,
        }
    });

    Object.defineProperties(this, {
        width: {
            value: width,
        }
    });

    Object.defineProperties(this, {
        length: {
            value: length,
        }
    });

    Object.defineProperties(this, {
        material: {
            value: material,
        }
    });
        
    Object.defineProperties(this, {
        content: {
            value: content,
            writable: true,
            enumerable: true,
            configurable: true
        }
    });

    Object.defineProperties(this, {
        numOfBooks: {
            value: function () {
            var counter = 0 ;
            for(var i in content)
            {
                counter+= content[i].numOfCopies;
            }
            return counter ;
        }
        }
    });

    Object.defineProperties(this, {
        deleteBook: {
            value: function (bookTitle) {
                var found = false ;
                for (var i in this.content)
                {
                    if(this.content[i].title === bookTitle)
                    {
                        (content[i].numOfCopies > 1) ? content[i].numOfCopies-- : content.splice(i,1);
                        found = true ;
                    }
                }
                if(!found)
                {
                    console.log("There is no book named " + bookTitle + " in this box!")
                }
            }
        }
    });

    this.valueOf = function () {
        return this.numOfBooks();
    };

    this.toString = function () {
        console.log("Box Dimensions are L x W x H : " + this.length + " x " + this.width + " x " + this.height);
        console.log(this.numOfBooks() + " Books");
        for (var i in this.content) {
            console.log("Book: '" + this.content[i].title + "' has " + this.content[i].numOfCopies + " copies");
        }   
    };

};



var book1 = new Book('javascript', 5, 'john', 120, 'abx publish', 5);
var book2 = new Book('C++', 15, 'jack', 350, 'abx publish', 10);
var book3 = new Book('algorithms', 7, 'zak', 500, 'xyz publish', 3);
var book4 = new Book('Clean Code', 14, 'bob', 470, 'xyz publish', 13);
var book5 = new Book('Clean Architecture', 11, 'Uncle Bob', 600, 'das publish', 12);

var box1 = new Box(100, 120, 100, 'wood', [book1, book2, book3]);
var box2 = new Box(90, 120, 150, 'cardboard', [book4, book5]);


