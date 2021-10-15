class MobileNavbar {
    constructor(mobileMenu, navList, navLinks) {
        this.mobileMenu = document.querySelector(mobileMenu);
        this.navList = document.querySelector(navList);
        this.navLinks = document.querySelectorAll(navLinks);
        this.activeClass = "active";

        this.handleClick = this.handleClick.bind(this);

    }

    animateLinks() {
        this.navLinks.forEach((link, index) => {
            link.style.animation
                ? (link.style.animation = "")
                : (link.style.animation = `navLinkFade 0.5s ease forwards 0.3s`);
        });
    }

    handleClick() {
        this.navList.classList.toggle(this.activeClass);
        this.mobileMenu.classList.toggle(this.activeClass);
        this.animateLinks();
    }

    addClickEvent() {
        this.mobileMenu.addEventListener("click", this.handleClick);
    }




    init() {
        if (this.mobileMenu) {
            this.addClickEvent();
        }

        return this;
    }

}

const mobileNavbar = new MobileNavbar(".mobile-menu", ".nav-list", ".nav-list li");
mobileNavbar.init();

function LeiaMais() {
    var pontos = document.getElementById("pontos");
    var maisTexto = document.getElementById("mais");
    var btnLeiaMais = document.getElementById("btnLeiaMais");

    if (pontos.style.display === "none") {

        pontos.style.display = "inline";
        maisTexto.style.display = "none";
        btnLeiaMais.innerHTML = "LeiaMais";

    } else {
        pontos.style.display = "none";
        maisTexto.style.display = "inline";
        btnLeiaMais.innerHTML = "Ocultar";


    }

}
function LeiaMaisVendas() {
    var pontosVendas = document.getElementById("pontosVendas");
    var maisTextoVendas = document.getElementById("maisVendas");
    var btnLeiaMaisVendas = document.getElementById("btnLeiaMaisVendas");
    if (pontosVendas.style.display === "none") {

        pontosVendas.style.display = "inline";
        maisTextoVendas.style.display = "none";
        btnLeiaMaisVendas.innerHTML = "LeiaMais";

    } else {
        pontosVendas.style.display = "none";
        maisTextoVendas.style.display = "inline";
        btnLeiaMaisVendas.innerHTML = "Ocultar";


    }

}

function LeiaMaisRelatorios() {
    var pontosRel = document.getElementById("pontosRel");
    var maisRelTexto = document.getElementById("maisRel");
    var btnLeiaMaisRelatorios = document.getElementById("btnLeiaMaisRelatorios");

    if (pontosRel.style.display === "none") {

        pontosRel.style.display = "inline";
        maisRelTexto.style.display = "none";
        btnLeiaMaisRelatorios.innerHTML = "LeiaMais";

    } else {
        pontosRel.style.display = "none";
        maisRelTexto.style.display = "inline";
        btnLeiaMaisRelatorios.innerHTML = "Ocultar";


    }

}

function LeiaMaisReq() {
    var pontosReq = document.getElementById("pontosReq");
    var maisReqTexto = document.getElementById("maisReq");
    var btnLeiaMaisReq = document.getElementById("btnLeiaMaisReq");

    if (pontosReq.style.display === "none") {

        pontosReq.style.display = "inline";
        maisReqTexto.style.display = "none";
        btnLeiaMaisReq.innerHTML = "LeiaMais";

    } else {
        pontosReq.style.display = "none";
        maisReqTexto.style.display = "inline";
        btnLeiaMaisReq.innerHTML = "Ocultar";


    }

}