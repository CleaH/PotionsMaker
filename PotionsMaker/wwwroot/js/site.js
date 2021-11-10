// element du svg avec le id "potion" directement dans le fichier svg
const changeColor = () => {
    svgPotion.style.fill = newHexa;
}

const newHexa = document.getElementById("newHexa").textContent; // valeur hexa récupérée dans un element du HTML
const svgPotion = document.getElementById("potion"); // element path svg -- renvoi null

svgPotion.addEventListener("load", changeColor);

