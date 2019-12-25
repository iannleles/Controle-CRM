function redirecionarAbout() {
    window.location.href = "/Home/About";
}

function redirecionarIndex() {

    if ($("#email").val() == 'iann@teste.com' && $("#password").val() == '1234') {
        window.location.href = "/Home/Index";
    }
    else {

        alert("Dados incorretos!");
    }
}
function redirecionarCadastro() {

    window.location.href = "/Home/Cadastro";
}

function validarCadastro() {

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