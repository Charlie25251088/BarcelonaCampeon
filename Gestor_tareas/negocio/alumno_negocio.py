from modelo import alumno_modelo

def listar_alumnos():
    return alumno_modelo.obtener_alumnos()

def crear_alumno(nombre):
    alumno_modelo.insertar_alumno(nombre)

def borrar_alumno(id_alumno):
    alumno_modelo.eliminar_alumno(id_alumno)

def obtener_alumno(id_alumno):
    return alumno_modelo.obtener_alumno_por_id(id_alumno)

def modificar_alumno(id_alumno, nombre):
    alumno_modelo.actualizar_alumno(id_alumno, nombre)
