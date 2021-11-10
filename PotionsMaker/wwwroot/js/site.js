// element du svg avec le id "potion" directement dans le fichier svg
const changeColor = () => {
    let svpObject = document.querySelector("#potionSvg");
    var newHexa = document.getElementById("newHexa").textContent; // valeur hexa récupérée dans un element du HTML
    svpObject.contentDocument.querySelector("#potion").style.fill = newHexa;
}

document.getElementById("potionSvg").onload = changeColor;

