/* A. Sólo con información de aquellos alumnos que han reprobado los cursos (nota Inferior a 4) */
SELECT	
		C.TITLE_NAME	AS 'Título Curso',
		CP.DNI			AS 'DNI Docente',
		CP.LAST_NAME	AS 'Apellido Docente',
		C.FINISH_DATE	AS 'Fecha de Fin',
		C.START_DATE	AS 'Fecha de Inicio',
		P.DNI			AS 'DNI Alumno',
		P.LAST_NAME		AS 'Apellido Alumno',
		P.FIRST_NAME	AS 'Nombre Alumno',
		Q.SCORE			AS 'Nota Alumno'

FROM	 TP3.PERSON			AS P
	JOIN TP3.QUALIFICATION	AS Q	ON Q.ID_PERSON = P.ID_PERSON
	JOIN TP3.COURSES		AS C	ON Q.ID_COURSES = C.ID_COURSES
	JOIN TP3.PERSON			AS CP	ON CP.ID_PERSON = C.ID_PERSON
WHERE Q.SCORE <4

/*B. Cursos que hayan iniciado luego del primero de enero del 2015 y finalizado antes del 31 de Diciembre del 2016.*/
SELECT	
		C.TITLE_NAME	AS 'Título Curso',
		CP.DNI			AS 'DNI Docente',
		CP.LAST_NAME	AS 'Apellido Docente',
		C.FINISH_DATE	AS 'Fecha de Fin',
		C.START_DATE	AS 'Fecha de Inicio',
		P.DNI			AS 'DNI Alumno',
		P.LAST_NAME		AS 'Apellido Alumno',
		P.FIRST_NAME	AS 'Nombre Alumno',
		Q.SCORE			AS 'Nota Alumno'

FROM	 TP3.PERSON			AS P
	JOIN TP3.QUALIFICATION	AS Q	ON Q.ID_PERSON = P.ID_PERSON
	JOIN TP3.COURSES		AS C	ON Q.ID_COURSES = C.ID_COURSES
	JOIN TP3.PERSON			AS CP	ON CP.ID_PERSON = C.ID_PERSON
WHERE C.START_DATE > '2015-01-01' AND C.FINISH_DATE < '2016-12-31'

