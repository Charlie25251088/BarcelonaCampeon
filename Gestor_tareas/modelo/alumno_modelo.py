from modelo.conexion import obtener_conexion

def obtener_alumnos():
    conexion = obtener_conexion()
    with conexion.cursor() as cursor:
        cursor.execute("SELECT * FROM alumnos")
        alumnos = cursor.fetchall()
    conexion.close()
    return alumnos

def insertar_alumno(nombre):
    conexion = obtener_conexion()
    with conexion.cursor() as cursor:
        cursor.execute("INSERT INTO alumnos (nombre) VALUES (%s)", (nombre,))
    conexion.commit()
    conexion.close()

def eliminar_alumno(id_alumno):
    conexion = obtener_conexion()
    with conexion.cursor() as cursor:
        cursor.execute("DELETE FROM alumnos WHERE id_alumno = %s", (id_alumno,))
    conexion.commit()
    conexion.close()

def obtener_alumno_por_id(id_alumno):
    conexion = obtener_conexion()
    with conexion.cursor() as cursor:
        cursor.execute("SELECT * FROM alumnos WHERE id_alumno = %s", (id_alumno,))
        alumno = cursor.fetchone()
    conexion.close()
    return alumno

def actualizar_alumno(id_alumno, nombre):
    conexion = obtener_conexion()
    with conexion.cursor() as cursor:
        cursor.execute("UPDATE alumnos SET nombre = %s WHERE id_alumno = %s", (nombre, id_alumno))
    conexion.commit()
    conexion.close()