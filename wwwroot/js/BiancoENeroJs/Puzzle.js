/*fa partire il cronometro*/
var s=0;
interval=window.setInterval("aggiornaCronometro()",1000);

/*funzione per il cronometro*/
function aggiornaCronometro(){
    s++;
    if (s < 10) document.getElementById("tempo").innerHTML  = `000000` + s + ' sec'
    else if (s < 100) document.getElementById("tempo").innerHTML  = `00000` + s + ' sec'
    else if (s < 1000) document.getElementById("tempo").innerHTML  = `0000` + s + ' sec'
    else if (s < 10000) document.getElementById("tempo").innerHTML  = `000` + s + ' sec'
    else if (s < 100000) document.getElementById("tempo").innerHTML  = `00` + s + ' sec'
    else if (s < 1000000) document.getElementById("tempo").innerHTML  = `0` + s + ' sec'
}

/*funzione che ferma il cronometro alla fine del puzzle*/
function stop() {
    if (interval) {
        clearInterval(interval);
    }
}


/*crea l' array di pezzi*/
var pezzi = document.getElementsByClassName('mobili');

/*grandezza pezzi*/
var pezzoWidh = [100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100];
var pezzoHeight = [100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100];

/*rende mobili i pezzi*/
for(var i=0;i<pezzi.length;i++){
	pezzi[i].setAttribute("width", pezzoWidh[i]);
	pezzi[i].setAttribute("height",pezzoHeight[i]);
	pezzi[i].setAttribute("x", Math.floor((Math.random() * 500) + 1000));
	pezzi[i].setAttribute("y", Math.floor((Math.random() * 300) + 150));
	pezzi[i].setAttribute("onmousedown","selezionaElemento(evt)");
}

var elementSelect = 0;  
var currentX = 0;
var currentY = 0;
var currentPosX = 0;
var currentPosY = 0;

function selezionaElemento(evt) {
	elementSelect = riordina(evt);
	currentX = evt.clientX;        
	currentY = evt.clientY;
	currentPosx = parseFloat(elementSelect.getAttribute("x"));     
	currentPosy = parseFloat(elementSelect.getAttribute("y"));
	elementSelect.setAttribute("onmousemove","moverElemento(evt)");
}

function moverElemento(evt){
	var dx = evt.clientX - currentX;
	var dy = evt.clientY - currentY;
	currentPosx = currentPosx + dx;
	currentPosy = currentPosy + dy;
	elementSelect.setAttribute("x",currentPosx);
	elementSelect.setAttribute("y",currentPosy);
	currentX = evt.clientX;        
	currentY = evt.clientY;
	elementSelect.setAttribute("onmouseout","deselezionaElemento(evt)");
	elementSelect.setAttribute("onmouseup","deselezionaElemento(evt)");
	iman();
}

function deselezionaElemento(evt){
	testing();
	if(elementSelect != 0){			
		elementSelect.removeAttribute("onmousemove");
		elementSelect.removeAttribute("onmouseout");
		elementSelect.removeAttribute("onmouseup");
		elementSelect = 0;
	}
}

var intorno = document.getElementById('intorno');

function riordina(evt){
	var padre = evt.target.parentNode;
	var clone = padre.cloneNode(true);
	var id = padre.getAttribute("id");
	intorno.removeChild(document.getElementById(id));
	intorno.appendChild(clone);
	return intorno.lastChild.firstChild;
}

/*setta le posizioni giuste dei pezzi*/
var origX = [200,300,400,500,600,700,200,300,400,500,600,700,200,300,400,500,600,700,200,300,400,500,600,700,200,300,400,500,600,700,200,300,400,500,600,700];   
var origY = [150,150,150,150,150,150,250,250,250,250,250,250,350,350,350,350,350,350,450,450,450,450,450,450,550,550,550,550,550,550,650,650,650,650,650,650];

function iman(){
	for(var i=0;i<pezzi.length;i++){
		if (Math.abs(currentPosx-origX[i])<15 && Math.abs(currentPosy-origY[i])<15) {
			elementSelect.setAttribute("x",origX[i]);
			elementSelect.setAttribute("y",origY[i]);
		}
	}
}

function testing() {
	var ben_posizionata= 0;
	var padres = document.getElementsByClassName('padre');
	for(var i=0;i<pezzi.length;i++){
		var posx = parseFloat(padres[i].firstChild.getAttribute("x"));    
		var posy = parseFloat(padres[i].firstChild.getAttribute("y"));
		ide = padres[i].getAttribute("id");
		if(origX[ide] == posx && origY[ide] == posy){
			ben_posizionata = ben_posizionata + 1;
		}
	}
	if(ben_posizionata == 36){
		stop();
	}
}