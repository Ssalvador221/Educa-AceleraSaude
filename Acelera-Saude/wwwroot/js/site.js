



//---Codigo do Bloco TREINAMENTOS----\\
const recebeValorDivTreinamentos = document.getElementById('column-treinamentos');
const recebeValorHrefTreinamentos = recebeValorDivTreinamentos.querySelector('a');
const recebeValorImgTreinamentos = recebeValorHrefTreinamentos.querySelector('img')

if (recebeValorHrefTreinamentos.getAttribute('href') == '#') {
    recebeValorImgTreinamentos.style.opacity = 0.5;
    recebeValorImgTreinamentos.style.cursor = 'not-allowed';
}
else {
    recebeValorHref.style.backgroundColor = '#f1f1f1';
}
//----------------------------------\\


//---Codigo do Bloco Comunicados----\\
const recebeValorDivComunicados = document.getElementById('column-comunicados');
const recebeValorHrefComunicados = recebeValorDivComunicados.querySelector('a');
const recebeValorImgComunicados = recebeValorHrefComunicados.querySelector('img')

if (recebeValorHrefComunicados.getAttribute('href') == '#') {
    recebeValorImgComunicados.style.opacity = 0.5;
    recebeValorImgComunicados.style.cursor = 'not-allowed';
}
else {
    recebeValorHref.style.backgroundColor = '#f1f1f1';
}
//----------------------------------\\