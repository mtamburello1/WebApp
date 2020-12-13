if (document.cookie == "flag=flag0a" || document.cookie == "flag=flag1a" || document.cookie == "flag=flag0d" || document.cookie == "flag=flag2d") {
    if (document.cookie == "flag=flag0a" || document.cookie == "flag=flag0d") {
        var flag = 0;
    }
    else if (document.cookie == "flag=flag1a") {
        var flag = 1;
        AumentaSize();         
    }
    else if (document.cookie == "flag=flag2d"){
        var flag = 2;
        DiminuisciSize();
    }
}
else {
    var flag = 0;
}
function AumentaSize() {
    /*è normale*/
    if (flag == 0) {
        if (document.getElementById("h1Index30") != null) {
            document.getElementById("h1Index30").style.fontSize = '45px';
        }
        if (document.getElementById("elemento1Menu") != null) {
            document.getElementById("elemento1Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento2Menu") != null) {
            document.getElementById("elemento2Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento3Menu") != null) {
            document.getElementById("elemento3Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento3_1Menu") != null) {
            document.getElementById("elemento3_1Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento4Menu") != null) {
            document.getElementById("elemento4Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento5Menu") != null) {
            document.getElementById("elemento5Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento6Menu") != null) {
            document.getElementById("elemento6Menu").style.fontSize = '35px';
        }
        if (document.getElementById("sorsidiversi40") != null) {
            document.getElementById("sorsidiversi40").style.fontSize = '55px';
        }
        if (document.getElementById("li1PD30") != null) {
            document.getElementById("li1PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li2PD30") != null) {
            document.getElementById("li2PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li3PD30") != null) {
            document.getElementById("li3PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li4PD30") != null) {
            document.getElementById("li4PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li5PD30") != null) {
            document.getElementById("li5PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li6PD30") != null) {
            document.getElementById("li6PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li7PD30") != null) {
            document.getElementById("li7PD30").style.fontSize = '45px';
        }
        if (document.getElementById("h4AR24") != null) {
            document.getElementById("h4AR24").style.fontSize = '38px';
        }
        if (document.getElementById("votoAR16") != null) {
            document.getElementById("votoAR16").style.fontSize = '30px';
        }
        if (document.getElementById("span0AR30") != null) {
            document.getElementById("span0AR30").style.fontSize = '45px';
        }
        if (document.getElementById("small5AR24") != null) {
            document.getElementById("small5AR24").style.fontSize = '38px';
        }
        if (document.getElementById("testoAR16") != null) {
            document.getElementById("testoAR16").style.fontSize = '30px';
        }
        if (document.getElementById("descrizioneAR16") != null) {
            document.getElementById("descrizioneAR16").style.fontSize = '30px';
        }
        if (document.getElementById("operaAR16") != null) {
            document.getElementById("operaAR16").style.fontSize = '30px';
        }
        if (document.getElementById("butAR16") != null) {
            document.getElementById("butAR16").style.fontSize = '30px';
        }
        if (document.getElementById("h1T40") != null) {
            document.getElementById("h1T40").style.fontSize = '55px';
        }
        if (document.getElementById("h5T20") != null) {
            document.getElementById("h5T20").style.fontSize = '35px';
        }
        if (document.getElementById("p1T20") != null) {
            document.getElementById("p1T20").style.fontSize = '35px';
        }
        if (document.getElementById("h52T20") != null) {
            document.getElementById("h52T20").style.fontSize = '35px';
        }
        if (document.getElementById("p2T20") != null) {
            document.getElementById("p2T20").style.fontSize = '35px';
        }
        if (document.getElementById("p1LP20") != null) {
            document.getElementById("p1LP20").style.fontSize = '35px';
        }
        if (document.getElementById("p2LP20") != null) {
            document.getElementById("p2LP20").style.fontSize = '35px';
        }
        if (document.getElementById("h1LP40") != null) {
            document.getElementById("h1LP40").style.fontSize = '55px';
        }
        if (document.getElementById("h1A40") != null) {
            document.getElementById("h1A40").style.fontSize = '55px';
        }
        if (document.getElementById("h5A20") != null) {
            document.getElementById("h5A20").style.fontSize = '35px';
        }
        if (document.getElementById("pA20") != null) {
            document.getElementById("pA20").style.fontSize = '35px';
        }
        if (document.getElementById("h1R60") != null) {
            document.getElementById("h1R60").style.fontSize = '75px';
        }
        if (document.getElementById("span1R24") != null) {
            document.getElementById("span1R24").style.fontSize = '38px';
        }
        if (document.getElementById("div1R16") != null) {
            document.getElementById("div1R16").style.fontSize = '30px';
        }
        if (document.getElementById("div2R20") != null) {
            document.getElementById("div2R20").style.fontSize = '35px';
        }
        if (document.getElementById("div3R18") != null) {
            document.getElementById("div3R18").style.fontSize = '33px';
        }



        flag = 1;
        document.cookie = "flag=flag1a; path=/";
    }

    /*è al massimo*/
    if (flag == 1) {
        if (document.getElementById("h1Index30") != null) {
            document.getElementById("h1Index30").style.fontSize = '45px';
        }
        if (document.getElementById("elemento1Menu") != null) {
            document.getElementById("elemento1Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento2Menu") != null) {
            document.getElementById("elemento2Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento3Menu") != null) {
            document.getElementById("elemento3Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento3_1Menu") != null) {
            document.getElementById("elemento3_1Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento4Menu") != null) {
            document.getElementById("elemento4Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento5Menu") != null) {
            document.getElementById("elemento5Menu").style.fontSize = '35px';
        }
        if (document.getElementById("elemento6Menu") != null) {
            document.getElementById("elemento6Menu").style.fontSize = '35px';
        }
        if (document.getElementById("sorsidiversi40") != null) {
            document.getElementById("sorsidiversi40").style.fontSize = '55px';
        }
        if (document.getElementById("li1PD30") != null) {
            document.getElementById("li1PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li2PD30") != null) {
            document.getElementById("li2PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li3PD30") != null) {
            document.getElementById("li3PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li4PD30") != null) {
            document.getElementById("li4PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li5PD30") != null) {
            document.getElementById("li5PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li6PD30") != null) {
            document.getElementById("li6PD30").style.fontSize = '45px';
        }
        if (document.getElementById("li7PD30") != null) {
            document.getElementById("li7PD30").style.fontSize = '45px';
        }
        if (document.getElementById("h4AR24") != null) {
            document.getElementById("h4AR24").style.fontSize = '38px';
        }
        if (document.getElementById("votoAR16") != null) {
            document.getElementById("votoAR16").style.fontSize = '30px';
        }
        if (document.getElementById("span0AR30") != null) {
            document.getElementById("span0AR30").style.fontSize = '45px';
        }
        if (document.getElementById("small5AR24") != null) {
            document.getElementById("small5AR24").style.fontSize = '38px';
        }
        if (document.getElementById("testoAR16") != null) {
            document.getElementById("testoAR16").style.fontSize = '30px';
        }
        if (document.getElementById("descrizioneAR16") != null) {
            document.getElementById("descrizioneAR16").style.fontSize = '30px';
        }
        if (document.getElementById("operaAR16") != null) {
            document.getElementById("operaAR16").style.fontSize = '30px';
        }
        if (document.getElementById("butAR16") != null) {
            document.getElementById("butAR16").style.fontSize = '30px';
        }
        if (document.getElementById("h1T40") != null) {
            document.getElementById("h1T40").style.fontSize = '55px';
        }
        if (document.getElementById("h5T20") != null) {
            document.getElementById("h5T20").style.fontSize = '35px';
        }
        if (document.getElementById("p1T20") != null) {
            document.getElementById("p1T20").style.fontSize = '35px';
        }
        if (document.getElementById("h52T20") != null) {
            document.getElementById("h52T20").style.fontSize = '35px';
        }
        if (document.getElementById("p2T20") != null) {
            document.getElementById("p2T20").style.fontSize = '35px';
        }
        if (document.getElementById("p1LP20") != null) {
            document.getElementById("p1LP20").style.fontSize = '35px';
        }
        if (document.getElementById("p2LP20") != null) {
            document.getElementById("p2LP20").style.fontSize = '35px';
        }
        if (document.getElementById("h1LP40") != null) {
            document.getElementById("h1LP40").style.fontSize = '55px';
        }
        if (document.getElementById("h1A40") != null) {
            document.getElementById("h1A40").style.fontSize = '55px';
        }
        if (document.getElementById("h5A20") != null) {
            document.getElementById("h5A20").style.fontSize = '35px';
        }
        if (document.getElementById("pA20") != null) {
            document.getElementById("pA20").style.fontSize = '35px';
        }
        if (document.getElementById("h1R60") != null) {
            document.getElementById("h1R60").style.fontSize = '75px';
        }
        if (document.getElementById("span1R24") != null) {
            document.getElementById("span1R24").style.fontSize = '38px';
        }
        if (document.getElementById("div1R16") != null) {
            document.getElementById("div1R16").style.fontSize = '30px';
        }
        if (document.getElementById("div2R20") != null) {
            document.getElementById("div2R20").style.fontSize = '35px';
        }
        if (document.getElementById("div3R18") != null) {
            document.getElementById("div3R18").style.fontSize = '33px';
        }
        flag = 1;
        document.cookie = "flag=flag1a; path=/";
    }

    /*è al minimo*/
    if (flag == 2) {
        if (document.getElementById("h1Index30") != null) {
            document.getElementById("h1Index30").style.fontSize = '30px';
        }
        if (document.getElementById("elemento1Menu") != null) {
            document.getElementById("elemento1Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento2Menu") != null) {
            document.getElementById("elemento2Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento3Menu") != null) {
            document.getElementById("elemento3Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento3_1Menu") != null) {
            document.getElementById("elemento3_1Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento4Menu") != null) {
            document.getElementById("elemento4Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento5Menu") != null) {
            document.getElementById("elemento5Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento6Menu") != null) {
            document.getElementById("elemento6Menu").style.fontSize = '20px';
        }
        if (document.getElementById("sorsidiversi40") != null) {
            document.getElementById("sorsidiversi40").style.fontSize = '40px';
        }
        if (document.getElementById("li1PD30") != null) {
            document.getElementById("li1PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li2PD30") != null) {
            document.getElementById("li2PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li3PD30") != null) {
            document.getElementById("li3PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li4PD30") != null) {
            document.getElementById("li4PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li5PD30") != null) {
            document.getElementById("li5PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li6PD30") != null) {
            document.getElementById("li6PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li7PD30") != null) {
            document.getElementById("li7PD30").style.fontSize = '30px';
        }
        if (document.getElementById("h4AR24") != null) {
            document.getElementById("h4AR24").style.fontSize = '24px';
        }
        if (document.getElementById("votoAR16") != null) {
            document.getElementById("votoAR16").style.fontSize = '16px';
        }
        if (document.getElementById("span0AR30") != null) {
            document.getElementById("span0AR30").style.fontSize = '30px';
        }
        if (document.getElementById("small5AR24") != null) {
            document.getElementById("small5AR24").style.fontSize = '24px';
        }
        if (document.getElementById("testoAR16") != null) {
            document.getElementById("testoAR16").style.fontSize = '16px';
        }
        if (document.getElementById("descrizioneAR16") != null) {
            document.getElementById("descrizioneAR16").style.fontSize = '16px';
        }
        if (document.getElementById("operaAR16") != null) {
            document.getElementById("operaAR16").style.fontSize = '16px';
        }
        if (document.getElementById("butAR16") != null) {
            document.getElementById("butAR16").style.fontSize = '16px';
        }
        if (document.getElementById("h1T40") != null) {
            document.getElementById("h1T40").style.fontSize = '40px';
        }
        if (document.getElementById("h5T20") != null) {
            document.getElementById("h5T20").style.fontSize = '20px';
        }
        if (document.getElementById("p1T20") != null) {
            document.getElementById("p1T20").style.fontSize = '20px';
        }
        if (document.getElementById("h52T20") != null) {
            document.getElementById("h52T20").style.fontSize = '20px';
        }
        if (document.getElementById("p2T20") != null) {
            document.getElementById("p2T20").style.fontSize = '20px';
        }
        if (document.getElementById("p1LP20") != null) {
            document.getElementById("p1LP20").style.fontSize = '20px';
        }
        if (document.getElementById("p2LP20") != null) {
            document.getElementById("p2LP20").style.fontSize = '20px';
        }
        if (document.getElementById("h1LP40") != null) {
            document.getElementById("h1LP40").style.fontSize = '40px';
        }
        if (document.getElementById("h1A40") != null) {
            document.getElementById("h1A40").style.fontSize = '40px';
        }
        if (document.getElementById("h5A20") != null) {
            document.getElementById("h5A20").style.fontSize = '20px';
        }
        if (document.getElementById("pA20") != null) {
            document.getElementById("pA20").style.fontSize = '20px';
        }
        if (document.getElementById("h1R60") != null) {
            document.getElementById("h1R60").style.fontSize = '60px';
        }
        if (document.getElementById("span1R24") != null) {
            document.getElementById("span1R24").style.fontSize = '24px';
        }
        if (document.getElementById("div1R16") != null) {
            document.getElementById("div1R16").style.fontSize = '16px';
        }
        if (document.getElementById("div2R20") != null) {
            document.getElementById("div2R20").style.fontSize = '20px';
        }
        if (document.getElementById("div3R18") != null) {
            document.getElementById("div3R18").style.fontSize = '18px';
        }

        flag = 0;
        document.cookie = "flag=flag0a; path=/";
    }

}

function DiminuisciSize() {
    /*è normale*/
    if (flag == 0) {
        if (document.getElementById("h1Index30") != null) {
            document.getElementById("h1Index30").style.fontSize = '15px';
        }
        if (document.getElementById("elemento1Menu") != null) {
            document.getElementById("elemento1Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento2Menu") != null) {
            document.getElementById("elemento2Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento3Menu") != null) {
            document.getElementById("elemento3Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento3_1Menu") != null) {
            document.getElementById("elemento3_1Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento4Menu") != null) {
            document.getElementById("elemento4Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento5Menu") != null) {
            document.getElementById("elemento5Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento6Menu") != null) {
            document.getElementById("elemento6Menu").style.fontSize = '10px';
        }
        if (document.getElementById("sorsidiversi40") != null) {
            document.getElementById("sorsidiversi40").style.fontSize = '20px';
        }
        if (document.getElementById("li1PD30") != null) {
            document.getElementById("li1PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li2PD30") != null) {
            document.getElementById("li2PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li3PD30") != null) {
            document.getElementById("li3PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li4PD30") != null) {
            document.getElementById("li4PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li5PD30") != null) {
            document.getElementById("li5PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li6PD30") != null) {
            document.getElementById("li6PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li7PD30") != null) {
            document.getElementById("li7PD30").style.fontSize = '15px';
        }
        if (document.getElementById("h4AR24") != null) {
            document.getElementById("h4AR24").style.fontSize = '12px';
        }
        if (document.getElementById("votoAR16") != null) {
            document.getElementById("votoAR16").style.fontSize = '8px';
        }
        if (document.getElementById("span0AR30") != null) {
            document.getElementById("span0AR30").style.fontSize = '15px';
        }
        if (document.getElementById("small5AR24") != null) {
            document.getElementById("small5AR24").style.fontSize = '12px';
        }
        if (document.getElementById("testoAR16") != null) {
            document.getElementById("testoAR16").style.fontSize = '8px';
        }
        if (document.getElementById("descrizioneAR16") != null) {
            document.getElementById("descrizioneAR16").style.fontSize = '8px';
        }
        if (document.getElementById("operaAR16") != null) {
            document.getElementById("operaAR16").style.fontSize = '8px';
        }
        if (document.getElementById("butAR16") != null) {
            document.getElementById("butAR16").style.fontSize = '8px';
        }
        if (document.getElementById("h1T40") != null) {
            document.getElementById("h1T40").style.fontSize = '20px';
        }
        if (document.getElementById("h5T20") != null) {
            document.getElementById("h5T20").style.fontSize = '10px';
        }
        if (document.getElementById("p1T20") != null) {
            document.getElementById("p1T20").style.fontSize = '10px';
        }
        if (document.getElementById("h52T20") != null) {
            document.getElementById("h52T20").style.fontSize = '10px';
        }
        if (document.getElementById("p2T20") != null) {
            document.getElementById("p2T20").style.fontSize = '10px';
        }
        if (document.getElementById("p1LP20") != null) {
            document.getElementById("p1LP20").style.fontSize = '10px';
        }
        if (document.getElementById("p2LP20") != null) {
            document.getElementById("p2LP20").style.fontSize = '10px';
        }
        if (document.getElementById("h1LP40") != null) {
            document.getElementById("h1LP40").style.fontSize = '20px';
        }
        if (document.getElementById("h1A40") != null) {
            document.getElementById("h1A40").style.fontSize = '20px';
        }
        if (document.getElementById("h5A20") != null) {
            document.getElementById("h5A20").style.fontSize = '10px';
        }
        if (document.getElementById("pA20") != null) {
            document.getElementById("pA20").style.fontSize = '10px';
        }
        if (document.getElementById("h1R60") != null) {
            document.getElementById("h1R60").style.fontSize = '30px';
        }
        if (document.getElementById("span1R24") != null) {
            document.getElementById("span1R24").style.fontSize = '12px';
        }
        if (document.getElementById("div1R16") != null) {
            document.getElementById("div1R16").style.fontSize = '8px';
        }
        if (document.getElementById("div2R20") != null) {
            document.getElementById("div2R20").style.fontSize = '10px';
        }
        if (document.getElementById("div3R18") != null) {
            document.getElementById("div3R18").style.fontSize = '9px';
        }
        flag = 2;
        document.cookie = "flag=flag2d; path=/";
    }

    /*è al minimo*/
    if (flag == 2) {
        if (document.getElementById("h1Index30") != null) {
            document.getElementById("h1Index30").style.fontSize = '15px';
        }
        if (document.getElementById("elemento1Menu") != null) {
            document.getElementById("elemento1Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento2Menu") != null) {
            document.getElementById("elemento2Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento3Menu") != null) {
            document.getElementById("elemento3Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento3_1Menu") != null) {
            document.getElementById("elemento3_1Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento4Menu") != null) {
            document.getElementById("elemento4Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento5Menu") != null) {
            document.getElementById("elemento5Menu").style.fontSize = '10px';
        }
        if (document.getElementById("elemento6Menu") != null) {
            document.getElementById("elemento6Menu").style.fontSize = '10px';
        }
        if (document.getElementById("sorsidiversi40") != null) {
            document.getElementById("sorsidiversi40").style.fontSize = '20px';
        }
        if (document.getElementById("li1PD30") != null) {
            document.getElementById("li1PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li2PD30") != null) {
            document.getElementById("li2PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li3PD30") != null) {
            document.getElementById("li3PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li4PD30") != null) {
            document.getElementById("li4PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li5PD30") != null) {
            document.getElementById("li5PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li6PD30") != null) {
            document.getElementById("li6PD30").style.fontSize = '15px';
        }
        if (document.getElementById("li7PD30") != null) {
            document.getElementById("li7PD30").style.fontSize = '15px';
        }
        if (document.getElementById("h4AR24") != null) {
            document.getElementById("h4AR24").style.fontSize = '12px';
        }
        if (document.getElementById("votoAR16") != null) {
            document.getElementById("votoAR16").style.fontSize = '8px';
        }
        if (document.getElementById("span0AR30") != null) {
            document.getElementById("span0AR30").style.fontSize = '15px';
        }
        if (document.getElementById("small5AR24") != null) {
            document.getElementById("small5AR24").style.fontSize = '12px';
        }
        if (document.getElementById("testoAR16") != null) {
            document.getElementById("testoAR16").style.fontSize = '8px';
        }
        if (document.getElementById("descrizioneAR16") != null) {
            document.getElementById("descrizioneAR16").style.fontSize = '8px';
        }
        if (document.getElementById("operaAR16") != null) {
            document.getElementById("operaAR16").style.fontSize = '8px';
        }
        if (document.getElementById("butAR16") != null) {
            document.getElementById("butAR16").style.fontSize = '8px';
        }
        if (document.getElementById("h1T40") != null) {
            document.getElementById("h1T40").style.fontSize = '20px';
        }
        if (document.getElementById("h5T20") != null) {
            document.getElementById("h5T20").style.fontSize = '10px';
        }
        if (document.getElementById("p1T20") != null) {
            document.getElementById("p1T20").style.fontSize = '10px';
        }
        if (document.getElementById("h52T20") != null) {
            document.getElementById("h52T20").style.fontSize = '10px';
        }
        if (document.getElementById("p2T20") != null) {
            document.getElementById("p2T20").style.fontSize = '10px';
        }
        if (document.getElementById("p1LP20") != null) {
            document.getElementById("p1LP20").style.fontSize = '10px';
        }
        if (document.getElementById("p2LP20") != null) {
            document.getElementById("p2LP20").style.fontSize = '10px';
        }
        if (document.getElementById("h1LP40") != null) {
            document.getElementById("h1LP40").style.fontSize = '20px';
        }
        if (document.getElementById("h1A40") != null) {
            document.getElementById("h1A40").style.fontSize = '20px';
        }
        if (document.getElementById("h5A20") != null) {
            document.getElementById("h5A20").style.fontSize = '10px';
        }
        if (document.getElementById("pA20") != null) {
            document.getElementById("pA20").style.fontSize = '10px';
        }
        if (document.getElementById("h1R60") != null) {
            document.getElementById("h1R60").style.fontSize = '30px';
        }
        if (document.getElementById("span1R24") != null) {
            document.getElementById("span1R24").style.fontSize = '12px';
        }
        if (document.getElementById("div1R16") != null) {
            document.getElementById("div1R16").style.fontSize = '8px';
        }
        if (document.getElementById("div2R20") != null) {
            document.getElementById("div2R20").style.fontSize = '10px';
        }
        if (document.getElementById("div3R18") != null) {
            document.getElementById("div3R18").style.fontSize = '9px';
        }

        flag = 2;
        document.cookie = "flag=flag2d; path=/";
    }

    /*è al massimo*/
    if (flag == 1) {
        if (document.getElementById("h1Index30") != null) {
            document.getElementById("h1Index30").style.fontSize = '30px';
        }
        if (document.getElementById("elemento1Menu") != null) {
            document.getElementById("elemento1Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento2Menu") != null) {
            document.getElementById("elemento2Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento3Menu") != null) {
            document.getElementById("elemento3Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento3_1Menu") != null) {
            document.getElementById("elemento3_1Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento4Menu") != null) {
            document.getElementById("elemento4Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento5Menu") != null) {
            document.getElementById("elemento5Menu").style.fontSize = '20px';
        }
        if (document.getElementById("elemento6Menu") != null) {
            document.getElementById("elemento6Menu").style.fontSize = '20px';
        }
        if (document.getElementById("sorsidiversi40") != null) {
            document.getElementById("sorsidiversi40").style.fontSize = '40px';
        }
        if (document.getElementById("li1PD30") != null) {
            document.getElementById("li1PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li2PD30") != null) {
            document.getElementById("li2PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li3PD30") != null) {
            document.getElementById("li3PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li4PD30") != null) {
            document.getElementById("li4PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li5PD30") != null) {
            document.getElementById("li5PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li6PD30") != null) {
            document.getElementById("li6PD30").style.fontSize = '30px';
        }
        if (document.getElementById("li7PD30") != null) {
            document.getElementById("li7PD30").style.fontSize = '30px';
        }
        if (document.getElementById("h4AR24") != null) {
            document.getElementById("h4AR24").style.fontSize = '24px';
        }
        if (document.getElementById("votoAR16") != null) {
            document.getElementById("votoAR16").style.fontSize = '16px';
        }
        if (document.getElementById("span0AR30") != null) {
            document.getElementById("span0AR30").style.fontSize = '30px';
        }
        if (document.getElementById("small5AR24") != null) {
            document.getElementById("small5AR24").style.fontSize = '24px';
        }
        if (document.getElementById("testoAR16") != null) {
            document.getElementById("testoAR16").style.fontSize = '16px';
        }
        if (document.getElementById("descrizioneAR16") != null) {
            document.getElementById("descrizioneAR16").style.fontSize = '16px';
        }
        if (document.getElementById("operaAR16") != null) {
            document.getElementById("operaAR16").style.fontSize = '16px';
        }
        if (document.getElementById("butAR16") != null) {
            document.getElementById("butAR16").style.fontSize = '16px';
        }
        if (document.getElementById("h1T40") != null) {
            document.getElementById("h1T40").style.fontSize = '40px';
        }
        if (document.getElementById("h5T20") != null) {
            document.getElementById("h5T20").style.fontSize = '20px';
        }
        if (document.getElementById("p1T20") != null) {
            document.getElementById("p1T20").style.fontSize = '20px';
        }
        if (document.getElementById("h52T20") != null) {
            document.getElementById("h52T20").style.fontSize = '20px';
        }
        if (document.getElementById("p2T20") != null) {
            document.getElementById("p2T20").style.fontSize = '20px';
        }
        if (document.getElementById("p1LP20") != null) {
            document.getElementById("p1LP20").style.fontSize = '20px';
        }
        if (document.getElementById("p2LP20") != null) {
            document.getElementById("p2LP20").style.fontSize = '20px';
        }
        if (document.getElementById("h1LP40") != null) {
            document.getElementById("h1LP40").style.fontSize = '40px';
        }
        if (document.getElementById("h1A40") != null) {
            document.getElementById("h1A40").style.fontSize = '40px';
        }
        if (document.getElementById("h5A20") != null) {
            document.getElementById("h5A20").style.fontSize = '20px';
        }
        if (document.getElementById("pA20") != null) {
            document.getElementById("pA20").style.fontSize = '20px';
        }
        if (document.getElementById("h1R60") != null) {
            document.getElementById("h1R60").style.fontSize = '60px';
        }
        if (document.getElementById("span1R24") != null) {
            document.getElementById("span1R24").style.fontSize = '24px';
        }
        if (document.getElementById("div1R16") != null) {
            document.getElementById("div1R16").style.fontSize = '16px';
        }
        if (document.getElementById("div2R20") != null) {
            document.getElementById("div2R20").style.fontSize = '20px';
        }
        if (document.getElementById("div3R18") != null) {
            document.getElementById("div3R18").style.fontSize = '18px';
        }

        flag = 0;
        document.cookie = "flag=flag0d; path=/";
    }
}