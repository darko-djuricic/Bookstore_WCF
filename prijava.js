$(document).ready(function () {
    $("#btnLogin").click(() => {
        let k = {
            username: $("#username").val(),
            password: $("#password").val()
        };
        $.ajax({
            url: "http://localhost:8000/knjizara/web/prijava",
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify(k),
            success: (data) => {
                $("#provera").text("Pogresan username ili lozinka")
                if(data!="")
                    window.location.href = `file:///C:/Users/djuri/source/repos/Knjizara/korisnik.html?id=${data.Id_korisnika}`;
            },
            error: (data) => {
            }
        })
    })
})