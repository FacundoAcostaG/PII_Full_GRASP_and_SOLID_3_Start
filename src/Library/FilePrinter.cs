//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText(@"c:\Recipe.txt", recipe.GetTextToPrint());
        }
    }
}

//Al dividir la clase que imprimia Recipe en 2, dependiendo si quiere imprimir por consola o archivo, estamos basandonos en el principio de SRP,
// ya que estamos asignando una responsabilidad a cada clase. A una que imprima por consola y otra en el archivo.
//Dichas responsabilidades las asignamos cumpliendo tambien con polimorfismo.