var inputs = readline().split(' ');
var lightX = parseInt(inputs[0]); // the X position of the light of power
var lightY = parseInt(inputs[1]); // the Y position of the light of power
var initialTX = parseInt(inputs[2]); // Thor's starting X position
var initialTY = parseInt(inputs[3]); // Thor's starting Y position

// game loop
while (true) {
    var remainingTurns = parseInt(readline()); // The remaining amount of turns Thor can move. Do not remove this line.
    var direction = "";
    if (lightY > initialTY) {
        initialTY += 1;
        direction += 'S';
    }
    if (lightY < initialTY) {
        initialTY -= 1;
        direction += 'N'
    }
    if (lightX > initialTX) {
        initialTX += 1;
        direction += 'E';
    }
    if (lightX < initialTX) {
        initialTX -= 1;
        direction += 'W';
    }
    print(direction);
}