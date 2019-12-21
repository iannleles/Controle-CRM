function RedirecionarAbout() {
    window.location.href = "/Home/About";
}
<<<<<<< HEAD

function RedirecionarIndex() {

    if ($("#email").val() == 'iann@teste.com' && $("#password").val() == '1234') {
        window.location.href = "/Home/Index";
    }
    else {

        alert("Dados incorretos!");
    }
=======
function RedirecionarIndex() {
    if ($("#email").val() == 'iann@teste.com' && $("#password").val() == '1234') {
        window.location.href = "/Home/Index";
    }
    else {
        alert("dados incorretos!");
    }
function RedirecionarIndex(){
    window.location.href = "/Home/Index";


>>>>>>> c9c9c0d41f0b4406a0127179856130d2ee7aa3c8
}
function RedirecionarCadastro() {

    window.location.href = "/Home/Cadastro";
}

<<<<<<< HEAD
function ValidarCadastro() {

    if ($("#nome").val() != null && $("#sobrenome").val() != null &&
        $("#cpf").val() != null && $("#email").val() != null &&
        $("#genero").val() != null && $("#dataNascimento").val() != null &&
        $("#endereco").val() != null && $("#uf").val() != null &&
        $("#nacionalidade").val() != null) {

        alert("Dados cadastrados!");
    }

    else {

        alert("todos os campos precisam ser preenchidos!");
    }
}
=======
}

>>>>>>> c9c9c0d41f0b4406a0127179856130d2ee7aa3c8
