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

function createCombo(id, url) {
    $("#" + id).select2({
        placeholder: "Buscar..",
        ajax: {
            processResults: function (data) {
                var result = getData(data);
                return {
                    results: result ? result : []
                };
            },
            transport: function (params, success, failure) {
                var query = params.data.term;
                if (query === null)
                    query = '';
                
                var data = {
                    query: query
                };

                var request = $.ajax({
                    type: 'POST',
                    url: urlContent + url,
                    data: data
                });
                
                request.then(success);
                request.fail(failure);
                
                return request;
            }
        }
    });
}

function createAutocomplete(id, url, jsonData) {
    $("#" + id).select2({
        placeholder: "Buscar..",
        ajax: {
            processResults: function (data) {
                var result = getData(data);
                return {
                    results: result ? result.results : [],
                    pagination: {
                        more: result ? result.pagination : false
                    }
                };
            },
            transport: function (params, success, failure) {
                var query = params.data.term;
                var page = params.data.page;
                
                if (query === null) {
                    query = '';
                }
                
                if (page == null){
                    page = 0;
                }

                var request = {
                    query: query,
                    page: page,
                    pageSize: 10
                };

                jsonData['request'] = request;
                
                var request = $.ajax({
                    type: 'POST',
                    url: urlContent + url,
                    data: jsonData
                });

                request.then(success);
                request.fail(failure);

                return request;
            }
        }
    });
}

function getData(data) {
    if (data.tipoError == REDIRECT) {
        window.location = urlContent + data.mensajeError;
        return null;
    }

    if (data.success) {
        return data.innerObject;
    }
    
    var msj = "";
    var title = "";

    if (data.innerObject != null && data.innerObject != 'undefined') {
        var item = 0;

        for (item in data.innerObject) {
            msj += data.innerObject[item] + "<br />";
        }

        title = data.mensajeError;
    } else {
        msj = data.mensajeError;
        title = "Error";
    }

    msjError(title, msj);
    
    return null;
}

function setComboValue(combo, idValue, text) {
    combo.select2("trigger", "select", {
        data: { id: idValue, text: text }
    });
}