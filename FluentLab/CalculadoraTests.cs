using FluentAssertions;
using FluentLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private Calculadora _calculadora;

        [TestInitialize]
        public void Setup()
        {
            _calculadora = new Calculadora();
        }

        [TestMethod]
        public void Sumar_DosNumerosPositivos_DevuelveLaSumaCorrecta()
        {
            // Arrange
            double numero1 = 5;
            double numero2 = 3;
            double resultadoEsperado = 8;

            // Act
            double resultadoActual = _calculadora.Sumar(numero1, numero2);

            // Assert
            resultadoActual.Should().Be(resultadoEsperado, "la suma no es correcta");
        }

        [TestMethod]
        public void Restar_DosNumerosPositivos_DevuelveLaRestaCorrecta()
        {
            // Arrange
            double numero1 = 5;
            double numero2 = 3;
            double resultadoEsperado = 2;

            // Act
            double resultadoActual = _calculadora.Restar(numero1, numero2);

            // Assert
            resultadoActual.Should().BeGreaterThan(1, "la resta no es correcta");
        }

        [TestMethod]
        public void Multiplicar_DosNumerosPositivos_DevuelveElProductoCorrecto()
        {
            // Arrange
            double numero1 = 5;
            double numero2 = 3;
            double resultadoEsperado = 15;

            // Act
            double resultadoActual = _calculadora.Multiplicar(numero1, numero2);

            // Assert
            resultadoActual.Should().BePositive("el producto no es correcto");
        }

        [TestMethod]
        public void Dividir_DosNumerosPositivos_DevuelveElCocienteCorrecto()
        {
            // Arrange
            double numero1 = 5;
            double numero2 = 3;
            double resultadoEsperado = 1.6666666666666667;

            // Act
            double resultadoActual = _calculadora.Dividir(numero1, numero2);

            // Assert
            resultadoActual.Should().BeApproximately(resultadoEsperado, 0.00001, "el cociente no es correcto");
        }
    }
}