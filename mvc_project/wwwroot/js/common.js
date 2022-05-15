/*********************************************************************************    
Copyright (C) 2013 NEPS - Soluciones Informáticas

Este programa es software libre: usted puede redistribuirlo y/o modificarlo 
bajo los términos de la Licencia Pública General GNU publicada 
por la Fundación para el Software Libre, ya sea la versión 3 
de la Licencia, o (a su elección) cualquier versión posterior.

Este programa se distribuye con la esperanza de que sea útil, pero 
SIN GARANTÍA ALGUNA; ni siquiera la garantía implícita 
MERCANTIL o de APTITUD PARA UN PROPÓSITO DETERMINADO. 
Consulte los detalles de la Licencia Pública General GNU para obtener 
una información más detallada. 

Debería haber recibido una copia de la Licencia Pública General GNU 
junto a este programa. 
En caso contrario, consulte http://www.gnu.org/licenses/gpl-3.0.html
*********************************************************************************/

const OK_RESPONSE = 0;
const ERROR_RESPONSE = 1;
const REDIRECT = 2;

function isNumeric(val) {
    if (val == null || val == "") return false;

    var validChars = '0123456789.';

    for (var i = 0; i < val.length; i++) {
        if (validChars.indexOf(val.charAt(i)) == -1)
            return false;
    }

    return true;
}

function isInteger(val) {
    if (val == null || val == "") return false;

    var validChars = '0123456789';

    for (var i = 0; i < val.length; i++) {
        if (validChars.indexOf(val.charAt(i)) == -1)
            return false;
    }

    return true;
}

function checkNum(event) {
    var keycode = event.keyCode;
    if ((keycode > 95 && keycode < 106) || (keycode > 47 && keycode < 58) || (keycode > 7 && keycode < 10)) { return true }
    return false;
}

function irA(idElemento) {
    if ($(`#${idElemento}`).length > 0) {
        $("body,html").animate(
            {
                scrollTop: $(`#${idElemento}`).offset().top
            },
            800) //speed
    } else {
        window.location = urlContent + `Web?Seccion=${idElemento}`;
    }

}