# Registro Comunitario – ASP.NET Core MVC

**Proyecto académico desarrollado en Visual Studio 2022**  
**Tecnología:** ASP.NET Core MVC (.NET 6/7)  
**Cliente:** *Organización “Comunidad Conectada”*  
**Autor:** Carlos Ramírez  
**Fecha:** Noviembre 2025  

---

## Objetivo General

Desarrollar una aplicación web en ASP.NET Core MVC que permita registrar y visualizar información de vecinos de la comunidad mediante un formulario dinámico, aplicando el patrón **MVC**, la separación de responsabilidades y validaciones de datos.

---

## Historia del Cliente

La organización *“Comunidad Conectada”* necesita registrar a los vecinos que se inscriben en sus actividades comunitarias.  
El sistema debe permitir ingresar:

- Identificación  
- Nombre  
- Apellidos  
- Teléfono  
- Correo electrónico  
- Género  
- Edad  

Al enviar el formulario, los datos se guardan en una lista temporal (en memoria) y se muestran en una tabla de registros.

---

## Reglas de Validación

| Campo | Validación |
|-------|-------------|
| **Nombre** | Obligatorio, mínimo 3 caracteres |
| **Correo** | Formato válido (puede ser nulo) |
| **Edad** | Entre 1 y 120 años (sin valores negativos) |

---

## Tecnologías Utilizadas

- **ASP.NET Core MVC** (.NET 6/7)  
- **C# 10/11**  
- **Razor Pages**  
- **Bootstrap 5.3**  
- **DataAnnotations** (validación de modelo)  
- **Repositorio en memoria (Singleton)**  
- **Git y GitHub** (control de versiones)

---

## Arquitectura del Proyecto

