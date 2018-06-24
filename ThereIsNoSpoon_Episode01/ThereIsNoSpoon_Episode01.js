var width = parseInt(readline());
var height = parseInt(readline());
var lineArray = [];
var x2,y2,x3,y3;

// Build 2D array
for (var i = 0; i < height; i++) {
    var line = readline(); // width characters, each either 0 or .
    lineArray[i] = line;
}

// Iterate through rows
for (var y = 0; y < lineArray.length; y++) {
    // Iterate through columns
    for (var x = 0; x < lineArray[y].length; x++) {
        // If node is found
        if (lineArray[y][x] == "0") {
            // Find right neighbor
            var scanDistance = lineArray[y].length - x;
            for (var xPos = x + 1; xPos < (x + scanDistance); xPos++) {
                if (lineArray[y][xPos] == "0") {
                    x2 = xPos;
                    y2 = y;
                    break;
                }
            }
            // If no right neighbor found
            if ((x2 === undefined) || (x2 === null)) {

                x2 = -1;
                y2 = -1;
            }
            
            // Find bottom neighbor
            var scanDistance = lineArray.length - y;
            for (var yPos = y + 1; yPos < (y + scanDistance); yPos++) {
                if (lineArray[yPos][x] == "0") {
                    x3 = x;
                    y3 = yPos;
                    break;
                }
            }
            // If no bottom neighbor found
            if ((y3 === undefined) || (y3 === null)) {
                x3 = -1;
                y3 = -1;
            }
        
            // Print response string
            print(x+" "+y+" "+x2+" "+y2+" "+x3+" "+y3);
            // Reset coordinates
            x2 = null;
            y2 = null;
            x3 = null;
            y3 = null;
        }
    }
}