from flask import Flask, render_template, request, redirect
from negocio import alumno_negocio

app = Flask(__name__)

@app.route('/')
def inicio():
    return redirect('/alumnos')

@app.route('/alumnos')
def mostrar_alumnos():
    alumnos = alumno_negocio.listar_alumnos()
    return render_template('alumnos.html', alumnos=alumnos)

@app.route('/alumnos/nuevo', methods=['GET', 'POST'])
def nuevo_alumno():
    if request.method == 'POST':
        nombre = request.form['nombre']
        alumno_negocio.crear_alumno(nombre)
        return redirect('/alumnos')
    return render_template('form_alumno.html')

@app.route('/alumnos/editar/<int:id>', methods=['GET', 'POST'])
def editar_alumno(id):
    if request.method == 'POST':
        nombre = request.form['nombre']
        alumno_negocio.modificar_alumno(id, nombre)
        return redirect('/alumnos')
    alumno = alumno_negocio.obtener_alumno(id)
    return render_template('form_alumno.html', alumno=alumno)

@app.route('/alumnos/eliminar/<int:id>')
def eliminar_alumno(id):
    alumno_negocio.borrar_alumno(id)
    return redirect('/alumnos')

if __name__ == '__main__':
    app.run(debug=True)