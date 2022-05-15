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
function ajax(
    type, 
    url, 
    jsonData, 
    msgAjax, 
    msgProgress, 
    functionSuccess, 
    functionError) {
    
    ajaxShowBack(msgAjax, msgProgress);
    
    $.ajax({
        type: type,
        url: urlContent + url,
        data: jsonData,
        success: function (objectResponse) {
            ajaxHideBack();
            processResponse(objectResponse, functionSuccess, functionError);
        },
        error: function (objeto, error, objeto2) {
            ajaxHideBack();
            msjError("Error", objeto.responseText);
        }
    });
}

function ajaxShowBack(msgAjax, msgProgress) {
    jQuery.blockUI({
        baseZ: 5000,
        blockMsgClass: 'alertBox',
        message: `<div class="spinner-border text-primary" role="status">
                    <span class= "sr-only" > ${msgProgress}</span>
                    </div>
    <h5>${msgAjax}</h5>` });
}

function ajaxHideBack() {
    jQuery.unblockUI();
}

function processResponse(objectResponse, functionSuccess, functionError) {
    if (objectResponse.returnType == REDIRECT) {
        window.location = urlContent + objectResponse.errorMessage;
    } else {
        if (objectResponse.success) {
            functionSuccess(objectResponse);
        } else {
            /* Error */
            var msj = "";
            var title = "";
            if (objectResponse.innerObject != null && objectResponse.innerObject != 'undefined') {
                var item = 0;

                for (item in objectResponse.innerObject) {
                    msj += objectResponse.innerObject[item] + "<br />";
                }

                title = objectResponse.errorMessage;
            } else {
                msj = objectResponse.errorMessage;
                title = "Error";
            }

            if (functionError == null || functionError == 'undefined') {
                msjError(title, msj);
            } else {
                functionError(msj, title);
            }
        }
    }
}