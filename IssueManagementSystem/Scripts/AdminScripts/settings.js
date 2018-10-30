﻿function matchStart(params, data) {
    // If there are no search terms, return all of the data
    if ($.trim(params.term) === '') {
        return data;
    }

    // Skip if there is no 'children' property
    if (typeof data.children === 'undefined') {
        return null;
    }

    // `data.children` contains the actual options that we are matching against
    var filteredChildren = [];
    $.each(data.children, function (idx, child) {
        if (child.text.toUpperCase().indexOf(params.term.toUpperCase()) === 0) {
            filteredChildren.push(child);
        }
    });

    // If we matched any of the timezone group's children, then set the matched children on the group
    // and return the group object
    if (filteredChildren.length) {
        var modifiedData = $.extend({}, data, true);
        modifiedData.children = filteredChildren;

        // You can return modified objects from here
        // This includes matching the `children` how you want in nested data sets
        return modifiedData;
    }

    // Return `null` if the term should not be displayed
    return null;
}
$('#selectdepartment').select2({
    placeholder: "Select Department.....",
    allowClear: false
});
$('#selectline').select2({
    placeholder: "Select Line.....",
    allowClear: false
});
$('#machineSelectBox').select2({
    placeholder: "Select Machine.....",
    allowClear: false
});
$('#selectlineIssues').select2({
    maximumSelectionLength: 5,
    placeholder: "Select Issues.....",
    allowClear: false
});




//Draw a map js
// By Simon Sarris
// www.simonsarris.com
// sarris@acm.org
//
// Last update December 2011
//
// Free to use and distribute at will
// So long as you are nice to people, etc

// Constructor for Shape objects to hold data for all drawn objects.
// For now they will just be defined as rectangles.
function Shape(x, y, w, h, fill,machine) {
    // This is a very simple and unsafe constructor. All we're doing is checking if the values exist.
    // "x || 0" just means "if there is a value for x, use that. Otherwise use 0."
    // But we aren't checking anything else! We could put "Lalala" for the value of x 
    this.x = x || 0;
    this.y = y || 0;
    this.w = w || 10;
    this.h = h || 10;
    this.fill = fill || '#AAAAAA';
    this.machine = machine || 'NULL*';
}

// Draws this shape to a given context
Shape.prototype.draw = function (ctx1) {
    ctx1.fillStyle = this.fill;
    ctx1.fillRect(this.x, this.y, this.w, this.h);
    /*  ctx1.fillStyle = "Red";
      ctx1.font="15px Arial";
      var midx=this.x+(this.w/4);
      var midy=this.y+(this.h/3);
      ctx1.fillText("M21",midx,midy);*/
}

// Determine if a point is inside the shape's bounds
Shape.prototype.contains = function (mx, my) {
    // All we have to do is make sure the Mouse X,Y fall in the area between
    // the shape's X and (X + Width) and its Y and (Y + Height)
    return (this.x <= mx) && (this.x + this.w >= mx) &&
        (this.y <= my) && (this.y + this.h >= my);
}

function CanvasState(canvas) {
    // **** First some setup! ****

    this.canvas = canvas;
    this.width = canvas.width;
    this.height = canvas.height;
    this.ctx = canvas.getContext('2d');
    // This complicates things a little but but fixes mouse co-ordinate problems
    // when there's a border or padding. See getMouse for more detail
    var stylePaddingLeft, stylePaddingTop, styleBorderLeft, styleBorderTop;
    if (document.defaultView && document.defaultView.getComputedStyle) {
        this.stylePaddingLeft = parseInt(document.defaultView.getComputedStyle(canvas, null)['paddingLeft'], 10) || 0;
        this.stylePaddingTop = parseInt(document.defaultView.getComputedStyle(canvas, null)['paddingTop'], 10) || 0;
        this.styleBorderLeft = parseInt(document.defaultView.getComputedStyle(canvas, null)['borderLeftWidth'], 10) || 0;
        this.styleBorderTop = parseInt(document.defaultView.getComputedStyle(canvas, null)['borderTopWidth'], 10) || 0;
    }
    // Some pages have fixed-position bars (like the stumbleupon bar) at the top or left of the page
    // They will mess up mouse coordinates and this fixes that
    var html = document.body.parentNode;
    this.htmlTop = html.offsetTop;
    this.htmlLeft = html.offsetLeft;

    // **** Keep track of state! ****

    this.valid = false; // when set to false, the canvas will redraw everything
    this.shapes = [];  // the collection of things to be drawn
    this.dragging = false; // Keep track of when we are dragging
    // the current selected object. In the future we could turn this into an array for multiple selection
    this.selection = null;
    this.dragoffx = 0; // See mousedown and mousemove events for explanation
    this.dragoffy = 0;

    // **** Then events! ****

    // This is an example of a closure!
    // Right here "this" means the CanvasState. But we are making events on the Canvas itself,
    // and when the events are fired on the canvas the variable "this" is going to mean the canvas!
    // Since we still want to use this particular CanvasState in the events we have to save a reference to it.
    // This is our reference!
    var myState = this;

    //fixes a problem where double clicking causes text to get selected on the canvas
    canvas.addEventListener('selectstart', function (e) { e.preventDefault(); return false; }, false);
    // Up, down, and move are for dragging
    canvas.addEventListener('mousedown', function (e) {
        var mouse = myState.getMouse(e);
        var mx = mouse.x;
        var my = mouse.y;
        var shapes = myState.shapes;
        var l = shapes.length;
        for (var i = l - 1; i >= 0; i--) {
            if (shapes[i].contains(mx, my)) {
                // Keep track of where in the object we clicked
                // so we can move it smoothly (see mousemove)
                var mySel = shapes[i];
                myState.dragoffx = mx - mySel.x;
                myState.dragoffy = my - mySel.y;
                myState.dragging = true;
                myState.selection = mySel;
                myState.valid = false;
                document.getElementById("elementID").innerHTML = shapes[i].machine;
                return;
            }
        }
        // havent returned means we have failed to select anything.
        // If there was an object selected, we deselect it
        if (myState.selection) {
            myState.selection = null;
            myState.valid = false; // Need to clear the old selection border
        }
    }, true);

    canvas.addEventListener('mousemove', function (e) {
        if (myState.dragging) {
            var mouse = myState.getMouse(e);
            // We don't want to drag the object by its top-left corner, we want to drag it
            // from where we clicked. Thats why we saved the offset and use it here
            myState.selection.x = mouse.x - myState.dragoffx;
            myState.selection.y = mouse.y - myState.dragoffy;
            myState.valid = false; // Something's dragging so we must redraw

        }
    }, true);

    canvas.addEventListener('mouseup', function (e) {
        myState.dragging = false;
    }, true);

    // double click for making new shapes
    canvas.addEventListener('dblclick', function (e) {
        var mouse = myState.getMouse(e);
        var w = Number(document.getElementById("w").value);
        var h = Number(document.getElementById("h").value);
        var color = document.getElementById("color").value;
        var machine_id = document.getElementById("machineSelectBox").value;

        myState.addShape(new Shape(mouse.x - 10, mouse.y - 10, w, h, "#" + color,machine_id));
    }, true);

    document.getElementById("addNewShapeButton").addEventListener("click", function () {
        var w = Number(document.getElementById("w").value);
        var h = Number(document.getElementById("h").value);
        var color = document.getElementById("color").value;
        var machine_id = document.getElementById("machineSelectBox").value;
        myState.addShape(new Shape(0, 0, w, h, "#" + color, machine_id));

    });

    document.getElementById("saveMap").addEventListener("click", function () {



        if (myState.shapes.length!= 0) {
            var map = JSON.stringify(myState.shapes);
            var department = (document.getElementById("selectdepartment").value).toString();
            var line = (document.getElementById("selectline").value).toString();
            var ipAddress = document.getElementById("raspberrypi_ip").value;

            var issues = $("#selectlineIssues").val();
            var issues_str = issues.toString();
            var issues_array = issues_str.split(",");
            var issues_JSON = JSON.stringify(issues_array);


            //console.log(JSON.parse(JSON.stringify(myState.shapes)));

            $.ajax({
                type: "POST",
                dataType: 'text',
                url: "/admin/addMap",
                data: { mapJSON: map, department: department, line: line, ipAddress: ipAddress, issues:issues_JSON },
                success: function (itemNameArray) {
                    alert("Done");
                },
                error: function () {
                    alert("Error");
                }

            });
        }
        else {
            alert("Please create the map !");

        }

    });

    //myState.selection.x
    document.getElementById("deleteBox").addEventListener("click", function () {
        var getX = myState.selection.x;
        var getY = myState.selection.y;
        var shapes = myState.shapes;
        var l = shapes.length;
        console.log(getX + "   " + getY);
        for (var i = l - 1; i >= 0; i--) {
            if (shapes[i].contains(getX, getY)) {
                var mySel = shapes[i];
                shapes.splice(i, 1);
                myState.selection = null;
                myState.valid = false;
                return;
            }
        }

    });


    /*   document.getElementById("colorButton").addEventListener("click", function(){
         console.log( myState.shapes[1]);
          myState.shapes[1].x =0; 
          myState.shapes[1].y =0;
          myState.shapes[1].fill = "rgba(12,12,34,1)";
          myState.shapes[1].draw(this.ctx);
          this.valid = false;
         }, true);
                         */
    // **** Options! ****

    this.selectionColor = '#f4dc42';
    this.selectionWidth = 5;
    this.interval = 30;
    setInterval(function () { myState.draw(); }, myState.interval);
}

CanvasState.prototype.addShape = function (shape) {
    this.shapes.push(shape);
    this.valid = false;
}

CanvasState.prototype.clear = function () {
    this.ctx.clearRect(0, 0, this.width, this.height);
}

// While draw is called as often as the INTERVAL variable demands,
// It only ever does something if the canvas gets invalidated by our code
CanvasState.prototype.draw = function () {
    // if our state is invalid, redraw and validate!
    if (!this.valid) {
        var ctx = this.ctx;
        var shapes = this.shapes;
        this.clear();

        // ** Add stuff you want drawn in the background all the time here **

        // draw all shapes
        var l = shapes.length;
        for (var i = 0; i < l; i++) {
            var shape = shapes[i];
            // We can skip the drawing of elements that have moved off the screen:
            if (shape.x > this.width || shape.y > this.height ||
                shape.x + shape.w < 0 || shape.y + shape.h < 0) continue;
            shapes[i].draw(ctx);
        }

        // draw selection
        // right now this is just a stroke along the edge of the selected Shape
        if (this.selection !== null) {
            ctx.strokeStyle = this.selectionColor;
            ctx.lineWidth = this.selectionWidth;
            var mySel = this.selection;
            ctx.strokeRect(mySel.x, mySel.y, mySel.w, mySel.h);
        }

        // ** Add stuff you want drawn on top all the time here **

        this.valid = true;
    }
}

// Creates an object with x and y defined, set to the mouse position relative to the state's canvas
// If you wanna be super-correct this can be tricky, we have to worry about padding and borders

CanvasState.prototype.getMouse = function (e) {
    var element = this.canvas, offsetX = 0, offsetY = 0, mx, my;
    // Compute the total offset
    if (element.offsetParent !== undefined) {
        do {
            offsetX += element.offsetLeft;
            offsetY += element.offsetTop;
        } while ((element = element.offsetParent));
    }

    // Add padding and border style widths to offset
    // Also add the <html> offsets in case there's a position:fixed bar

    offsetX += this.stylePaddingLeft + this.styleBorderLeft + this.htmlLeft;
    offsetY += this.stylePaddingTop + this.styleBorderTop + this.htmlTop;

    mx = e.pageX - offsetX;
    my = e.pageY - offsetY;

    // We return a simple javascript object (a hash) with x and y defined
    return { x: mx, y: my };
}

// If you dont want to use <body onLoad='init()'>
// You could uncomment this init() reference and place the script reference inside the body tag
//init();

function init() {
    var s = new CanvasState(document.getElementById('canvas1'));
    //  s.addShape(new Shape(60,140,40,60, 'lightskyblue'));
}

// Now go make something amazing!

window.onload = init;
// end of draw map js

