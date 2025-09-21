import math
import sys

# Ejercicio 1
def ejer1():
    # Declaramos variables
    precio = 0.0
    descuento = 0.0
    precio_final = 0.0
    codigo = 0

    precio = float(input("Ingrese el precio del producto: "))
    codigo = int(input("Ingrese el código de descuento (1=Estudiante, 2=Empleado, 3=Cliente frecuente): "))

    # Cantidad de descuento
    if codigo == 1:
        descuento = 0.10
    elif codigo == 2:
        descuento = 0.15
    elif codigo == 3:
        descuento = 0.20
    else:
        print("Código inválido, no se aplica descuento.")
        descuento = 0.0

    # Aplicar descuento
    precio_final = precio - (precio * descuento)

    # Descuento adicional 
    if precio > 500:
        precio_final = precio_final - (precio_final * 0.05)

    print(f"El precio final es: {precio_final:.2f}")


# Ejercicio 2
def ejer2():
    # Declaramos Variables
    nota = 0
    clasificacion = ""

    nota = int(input("Ingrese una nota (0-20): "))

   
    if nota < 0 or nota > 20:
        print("Ingrese una nota valida.")
        sys.exit() 

    # Clasificamos
    if 0 <= nota <= 10:
        clasificacion = "Desaprobado"
    elif 11 <= nota <= 13:
        clasificacion = "Regular"
    elif 14 <= nota <= 17:
        clasificacion = "Bueno"
    else:  # 18-20
        clasificacion = "Excelente"

    print(f"Clasificación: {clasificacion}")

    # Condicionales
    if nota >= 14 and nota % 2 == 0:
        print("Buen desempeño con nota par")
    if nota % 2 != 0 or nota <= 11:
        print("Necesita reforzar")

    # Cálculos
    raiz = math.sqrt(nota)
    cubo = math.pow(nota, 3)

    print(f"Raíz cuadrada: {raiz:.1f}")
    print(f"Cubo de la nota: {cubo}")

def main():
    ejer1()
    input("\nPresione una tecla para continuar...")

    ejer2()
    input("\nPresione una tecla para salir...")


if __name__ == "__main__":
    main()

