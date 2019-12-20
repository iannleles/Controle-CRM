function RedirecionarAbout() {
    window.location.href = "/Home/About";
}
function RedirecionarIndex() {
    if ($("#email").val() == 'iann@teste.com' && $("#password").val() == '1234') {
        window.location.href = "/Home/Index";
    }
    else {
        alert("dados incorretos!");
    }
function RedirecionarIndex(){
    window.location.href = "/Home/Index";


}
function RedirecionarCadastro() {
    window.location.href = "/Home/Cadastro";
}

}

