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

function msjError(title, msj, funCerrar) {
    agregarTexto('modal-danger', title, msj, 'cil-x-circle');
    $('#btn_aceptar').hide();
    $('#btn_cerrar').show();

    $('#btn_cerrar').on('click', function () {
        $('#btn_cerrar').hide();
        cerrarModal(funCerrar);
    });

    $('#cruz_cerrar').on('click', function () {
        $('#cruz_cerrar').hide();
        cerrarModal(funCerrar);
    });
}

function msjSuccess(title, msj, funCerrar) {
    agregarTexto('modal-success', title, msj, 'cil-check-circle');
    $('#btn_aceptar').hide();
    $('#btn_cerrar').show();
    
    $('#btn_cerrar').on('click', function () {
        $('#btn_cerrar').hide();
        cerrarModal(funCerrar);
    });

    $('#cruz_cerrar').on('click', function () {
        $('#cruz_cerrar').hide();
        cerrarModal(funCerrar);
    });
}

function msjInfo(title, msj) {
    agregarTexto('modal-info', title, msj, 'cil-info');
    $('#btn_aceptar').hide();
    $('#btn_cerrar').show();
}

function msjPregunta(title, msj, funAceptar, funCerrar) {
    agregarTexto('modal-info', title, msj, 'cil-comment-bubble');
    $('#btn_aceptar').show();
    $('#btn_cerrar').show();

    $('#btn_aceptar').on('click', function () {
        $('#btn_aceptar').hide();
        aceptarModal(funAceptar);
    });

    $('#btn_cerrar').on('click', function () {
        $('#btn_cerrar').hide();
        cerrarModal(funCerrar);
    });

    $('#cruz_cerrar').on('click', function () {
        $('#cruz_cerrar').hide();
        cerrarModal(funCerrar);
    });
}

function msjWarning(title, msj, funCerrar) {
    agregarTexto('modal-warning', title, msj, 'cil-warning');
    $('#btn_aceptar').hide(); 
    $('#btn_cerrar').show();
    
    $('#btn_cerrar').on('click', function () {
        $('#btn_cerrar').hide();
        cerrarModal(funCerrar);
    });

    $('#cruz_cerrar').on('click', function () {
        $('#cruz_cerrar').hide();
        cerrarModal(funCerrar);
    });
}

function agregarTexto(modaltype, title, msj, icon) {
    jQuery.noConflict();
    $('#btn_aceptar').hide();
    $('#btn_cerrar').hide();
    $('#btn_aceptar').off();
    $('#btn_cerrar').off();
    $('#contenedor_modal').removeClass().addClass(modaltype);
    $('#titulo_modal').html(title);
    $('#texto_modal span').html(msj);
    $('#icono_modal').html('<use xlink:href="/img/icons/svg/free.svg#' + icon +'"></use>');
    $('#small_modal').modal('show');
}

function cerrarModal(funCerrar) {
    $('#small_modal').modal('hide');
    if (funCerrar != null) {
        funCerrar();
    }
}

function aceptarModal(funAceptar) {
    $('#small_modal').modal('hide');
    if (funAceptar != null) {
        funAceptar();
    }
}