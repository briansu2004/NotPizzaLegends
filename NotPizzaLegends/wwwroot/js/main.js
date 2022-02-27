function drawImage(canvas, src, x, y) {

    ctx = canvas.getContext("2d");

    const image = new Image();
    image.onload = () => {
        ctx.drawImage(image, x, y)
    };

    image.src = src;
}