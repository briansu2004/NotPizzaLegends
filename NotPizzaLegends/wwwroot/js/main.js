function clearCanvas(canvas) {

    ctx = canvas.getContext("2d");
    ctx.clearRect(0, 0, canvas.width, canvas.height);
}

function drawImage(canvas, img, x, y) {

    ctx = canvas.getContext("2d");
    ctx.drawImage(img, x, y);
}

function drawAndCropImage(canvas, img, sx, sy, sw, sh, dx, dy, dw, dh) {

    ctx = canvas.getContext("2d");
    ctx.drawImage(img, sx, sy, sw, sh, dx, dy, dw, dh);
}