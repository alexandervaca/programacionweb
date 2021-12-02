var er_email = /^(.+\@.+\..+)$/; //--mail tipo algo@algo.com
var er_numeros = /^([0-9])+$/; //--del 1 al 9
var er_letras = /^[A-Z- ]+$/i; //de la a a la z y espacios

function validarFormulario()
{
    nombre = document.getElementById("txtNombre");
    apellido = document.getElementById("txtApellido");
    dni = document.getElementById("txtDni");
    turno = document.getElementById("txtTurno");
    email = document.getElementById("txtEmail");

	if (apellido.value == "") {
		apellido.focus();
		alert("Ingrese su apellido por favor.");
		return false;
	}
	else if (!er_letras.test(apellido.value)) {
		apellido.focus();
		alert("Solo se admiten letras para el apellido");
		return false;
	}
	else if (nombre.value == "") {
		nombre.focus();
		alert("Ingrese su nombre por favor.");
		return false;
	}
	else if (!er_letras.test(nombre.value)) {
		nombre.focus();
		alert("Solo se admiten letras para el nombre");
		return false;
	}
	else if (dni.value == "") {
		dni.focus();
		alert("Ingrese su dni por favor.");
		return false;
	}
	else if (!er_numeros.test(dni.value)) {
		dni.focus();
		alert("Solo se admiten números para el DNI");
		return false;
	}
	else if (email.value == "") {
		email.focus();
		alert("Ingrese su email por favor.");
		return false;
	}
	else if (!er_email.test(email.value)) {
		email.focus();
		alert("La dirección de email ingresada es inválida, la misma debe ser del tipo 'mail@dominio.com");
		return false;
	}
	else if (turno.value == "-") {
		turno.focus();
		alert("Debe seleccionar un turno.");
		return false;
	}
	



	/*
    if (nombre.value == "" || apellido.value == "" || dni.value == "" || turno.value == "" || email.value == "") {
        alert("Ningun campo puede estar vacio")
        return false
    }*/
}

function validarComentario()
{
	comentario = document.getElementById("txtComentarios");

	if (comentario.value == "") {
		comentario.focus();
		alert("Ingrese su comentario!");
		return false;
	}
}


