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

FROM TP3.PERSON P
	JOIN TP3.QUALIFICATION Q	ON Q.PERSON_ID = P.ID
	JOIN TP3.COURSES C			ON Q.COURSES_ID = C.ID
	JOIN TP3.PERSON CP			ON CP.ID = C.PERSON_ID
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

FROM TP3.PERSON P
	JOIN TP3.QUALIFICATION Q	ON Q.PERSON_ID = P.ID
	JOIN TP3.COURSES C			ON Q.COURSES_ID = C.ID
	JOIN TP3.PERSON CP			ON CP.ID = C.PERSON_ID
WHERE C.START_DATE > '2015-01-01' AND C.FINISH_DATE < '2016-12-31'

