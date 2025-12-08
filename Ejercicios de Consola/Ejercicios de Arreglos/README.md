# Ejercicios de Búsquedas en C#

Programación Estructurada

Estudiante: Rolando Mayorga

Docente: MSc. José Alejandro Durán García

## 📌 Descripción general

Este proyecto contiene la implementación de diferentes tipos de búsquedas en C#, aplicando únicamente conceptos básicos de programación estructurada tales como:

Arreglos

Listas

Ciclos for y foreach

Condicionales

Métodos simples

Comparaciones carácter por carácter

Matrices bidimensionales

Se evita el uso de funciones avanzadas o métodos predefinidos como Contains, IndexOf, BinarySearch o LINQ, 
cumpliendo estrictamente con los requisitos de cada ejercicio.

# 📚 Ejercicio 1 – Búsqueda lineal en un arreglo

## ✔️ Objetivo:

Crear un programa que:

Genere un arreglo de 20 números enteros aleatorios.

Solicite un número al usuario.

Realice una búsqueda lineal.

Muestre si el número existe o no en el arreglo.

## ✔️ Conceptos aplicados:

Uso de arreglos.

Recorrido con foreach.

Comparación simple de enteros.

## ✔️ Resultado:

El programa determina si el número buscado se encuentra en la lista y muestra un mensaje indicando su presencia o ausencia.

# 📚 Ejercicio 2 – Búsqueda binaria manual en una lista ordenada

## ✔️ Objetivo:

Generar una lista de números aleatorios.

Ordenarla con Sort().

Implementar la búsqueda binaria de forma manual, sin funciones avanzadas.

Mostrar si el número existe o no.

## ✔️ Conceptos aplicados:

División de rangos (izquierda, derecha, medio).

Comparaciones directas.

Lista ordenada para aplicar búsqueda binaria.

## ✔️ Resultado:

El usuario ingresa un número y el programa indica si fue encontrado en la lista ordenada y en qué posición.

# 📚 Ejercicio 3 – Búsqueda de una palabra en un párrafo (carácter por carácter)

## ✔️ Objetivo:

Recibir un párrafo y una palabra.

Buscar cuántas veces aparece esa palabra.

No diferenciar mayúsculas/minúsculas.

No utilizar métodos como Contains o IndexOf.

## ✔️ Conceptos aplicados:

Recorrido carácter por carácter.

Comparación manual de cadenas.

Búsqueda tipo "ventana deslizante" (sliding window) básica.

## ✔️ Resultado:

El programa devuelve cuántas veces aparece la palabra dentro del texto introducido por el usuario.

# 📚 Ejercicio 4 – Búsqueda de objetos en una colección

## ✔️ Objetivo:

Crear una colección de al menos 10 estudiantes.

Buscar por ID usando búsqueda lineal.

Buscar por Nombre usando búsqueda binaria manual.

Ordenar la lista de objetos alfabéticamente antes de la búsqueda.

## ✔️ Conceptos aplicados:

Listas de objetos.

Comparaciones entre cadenas.

Ordenamiento con Sort().

Búsqueda lineal vs. binaria.

## ✔️ Resultado:

El programa indica si existe el estudiante buscado por ID o por nombre, mostrando también sus datos.

# 📚 Ejercicio 5 – Búsqueda del valor máximo y mínimo

## ✔️ Objetivo:

Recorrer una lista de enteros.

Determinar:

El máximo.

El mínimo.

El número de iteraciones realizadas.

Sin usar Max() ni Min().

## ✔️ Conceptos aplicados:

Recorrido simple con foreach.

Comparaciones directas.

Contador de iteraciones.

## ✔️ Resultado:

El programa muestra el valor máximo, el mínimo y cuántas comparaciones fueron necesarias.

# 📚 Ejercicio 6 – Búsqueda en una matriz 10×10

## ✔️ Objetivo:

Crear una matriz 10x10 con números aleatorios.

Recibir un número del usuario.

Buscarlo de manera exhaustiva.

## ✔️ Conceptos aplicados:

Matrices bidimensionales en C#.

Recorridos anidados con dos ciclos for.

Comparación directa en cada casilla.

## ✔️ Resultado:

El programa indica en qué posiciones aparece el número o si no se encontró en ninguna parte de la matriz.

# 🧩 Conclusión general

Estos ejercicios permiten comprender y practicar los fundamentos de la programación estructurada, aplicando diferentes tipos de 
algoritmos de búsqueda sin apoyarse en funciones avanzadas. Cada ejercicio refuerza conceptos esenciales como:

Recorridos secuenciales y por rangos.

Comparaciones simples.

Arreglos y listas.

Manejo de cadenas.

Matrices 2D.

Ordenamiento y lógica condicional.

El conjunto forma una base sólida para entender cómo funcionan internamente los algoritmos de búsqueda más usados en programación.