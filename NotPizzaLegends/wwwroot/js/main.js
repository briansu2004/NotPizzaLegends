function drawImage(canvas, src, x, y) {

    ctx = canvas.getContext("2d");

    const image = new Image();
    image.onload = () => {
        ctx.drawImage(image, x, y)
    };

    image.src = src;
}

function drawAndCropImage(canvas, src, sx, sy, sw, sh, dx, dy, dw, dh) {

    ctx = canvas.getContext("2d");

    const image = new Image();
    image.onload = () => {
        ctx.drawImage(image, sx, sy, sw, sh, dx, dy, dw, dh)
    };

    image.src = src;
}