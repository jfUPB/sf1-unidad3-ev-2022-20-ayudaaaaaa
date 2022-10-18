# Parcial 3
Tomamos los datos de aceleracion de 3 ejes del sensor mediante la libreria Adafruit MP6050 y creamos unarreglo de 12 enteros.
Luego copiamos los 3 datos (4 bytes cada uno) en el arreglo y cuando se ejecuta el comando "s" los enviamos por serial a unity.
En unity tenemos un arreglo de 12 bytes donde vamos a almacenar lo que se recibio por el serial, 3 variables para cada eje y un timer.
Luego de verificar que se recibieron los 12 bytes convertimos estos a float y los asignamos a cada variable.
Finalmente con la ayuda de la funcion transform.rotation actualizamos el movimiento del gameobject cada ciclo del update.
Tambien tenemos un if que despues de cada ciclo  del timer escribe "s" por serial al microcontrolador, despues de que este lo recibe actualiza
los datos del sensor.
