let link = "http://localhost:8000/knjizara/web/";
var url = new URL(window.location.href);
var id_korisnika = parseInt(url.searchParams.get("id"));
let porudzbina;
let knjige;
let porudzbineKorisnika;

function poruci(id_knjige) {
    $("#kolicina").val(1)
    let k = knjige.find(el => el.Id_knjige == id_knjige);
    $("#modalTelo").html(`"${k.Naziv}" od ${k.Autor} (ukupna cena: ${k.Cena - (k.Cena * k.Popust)})`);
    porudzbina = {
        Id_porudzbine: 0,
        Id_knjige: id_knjige,
        Id_korisnika: id_korisnika
    }
}

function otkazi(id) {
    
        $.ajax({
            url: link + `porudzbina/otkazi/${id}`,
            type: "DELETE",
            contentType: "application/json",
            success: (data) => {
                alert("Uspesno ste otkazali porudzbinu")
                location.reload();
            },
            error: (data) => {
                alert("Doslo je do greske prilikom narucivanja")
            }
        })
}


$(document).ready(function () {
    $("#btnPoruci").click(() => {
        porudzbina.Kolicina = parseInt($("#kolicina").val());
        $.ajax({
        url: link +"knjige/poruci",
        type: "POST",
            contentType: "application/json",
            data: JSON.stringify(porudzbina),
            success: (data) => {
                alert("Uspesno ste porucili knjigu")
                location.reload();
        },
            error: (data) => {
                alert("Doslo je do greske prilikom narucivanja")
        }
        })
        $("#modal1").modal("hide");
    });

    $.get(link + "knjige", (data) => {
        knjige = data;
        let prikaz = "";
        data.forEach(el => {
            let cena = el.Popust == 0 ? `${el.Cena}` : `${el.Cena - (el.Cena * el.Popust)} (sa popustom od ${el.Popust*100}%)`;
            prikaz += `<div class="col-12 mt-5">
                <div class="row border border-primary bg-primary text-light">
                    <div class="col-3">Naziv knjige</div>
                    <div class="col-3">Autor</div>
                    <div class="col-3">Cena</div>
                </div>
            </div>
            <div class="col-12">
                <div class="row border border-primary">
                    <div class="col-3 font-weight-bold mt-3 mb-3">${el.Naziv}</div>
                    <div class="col-3 font-weight-bold mt-3 mb-3">${el.Autor}</div>
                    <div class="col-3 font-weight-bold mt-3 mb-2">${cena} RSD</div>
                    <div class="col-3 font-weight-bold mt-2 "><button class="btn btn-outline-primary btn-block" onclick="poruci(${el.Id_knjige})" data-toggle="modal" data-target="#modal1"><strong>Poruci</strong></button></div>
                </div>
            </div>`
        });
        $("#knjige").html(prikaz)
    })

    $.get(link + `porudzbina/${id_korisnika}`, (data) => {
        porudzbineKorisnika = data;
        if (data.length==0) {
            $("#porudzbine").html("<h1 class='text-center'>Nemate ni jednu porudzbinu</h1>")
            return 0;
        }

        let prikaz = "";
        data.forEach(el => {
            let knjiga = knjige.find(o => o.Id_knjige == el.Id_knjige)
            prikaz += `<div class="col-12 mt-5">
                <div class="row border border-primary bg-primary text-light">
                    <div class="col-3">Broj porudzbine</div>
                    <div class="col-3">Knjiga</div>
                    <div class="col-3">Kolicina</div>
                </div>
            </div>
            <div class="col-12">
                <div class="row border border-primary">
                    <div class="col-3 font-weight-bold mt-3 mb-3">${el.Id_porudzbine}</div>
                    <div class="col-3 font-weight-bold mt-3 mb-3">"${knjiga.Naziv}" od ${knjiga.Autor}</div>
                    <div class="col-3 font-weight-bold mt-3 mb-2">${el.Kolicina}X</div>
                    <div class="col-3 font-weight-bold mt-2 "><button class="btn btn-outline-primary btn-block" onclick="otkazi(${el.Id_porudzbine})"><strong>Otkazi</strong></button></div>
                </div>
            </div>`
        });
        $("#porudzbine").html(prikaz)
    })

    
});
