using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigeonholeSort1._0
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
        }
        // Manejador de eventos para el clic del botón
        private void btnSort_Click_Click(object sender, EventArgs e)
        {
            // Obtener los valores de entrada del cuadro de texto
            string[] inputValues = tbInput.Text.Split(',');

            // Convertir los valores de entrada a enteros
            numbers = new int[inputValues.Length];
            for (int i = 0; i < inputValues.Length; i++)
            {
                if (int.TryParse(inputValues[i], out int num))
                {
                    numbers[i] = num;
                }
                else
                {
                    // Mostrar un mensaje de error si la entrada no es un entero válido
                    MessageBox.Show("Entrada no válida. Por favor, ingrese enteros separados por comas.");
                    return;
                }
            }

            // Inicializar el índice y el temporizador
            currentIndex = 0;
            Timer timer = new Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (puedes ajustar este valor)
            timer.Tick += Timer_Tick;

            // Habilitar el temporizador para iniciar la animación
            timer.Start();
        }
        // Manejador de eventos del temporizador
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Verificar si se ha completado la clasificación
            if (currentIndex < numbers.Length)
            {
                // Mostrar el estado actual en el cuadro de texto de salida
                tbOutput.Text = string.Join(", ", numbers);

                // Realizar un paso de Pigeonhole Sort
                PigeonholeSortStep();

                // Incrementar el índice para el próximo paso
                currentIndex++;
            }
            else
            {
                // Deshabilitar el temporizador cuando se completa la clasificación
                ((Timer)sender).Stop();
            }
        }
        // Algoritmo Pigeonhole Sort para un solo paso
        private void PigeonholeSortStep()
        {
            // Encontrar los valores mínimo y máximo en el arreglo
            int min = numbers[0], max = numbers[0];
            for (int i = 1; i <= currentIndex; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }

            // Calcular el rango de valores
            int range = max - min + 1;

            // Crear un arreglo para representar los "pigeonholes" (contenedores)
            int[] pigeonholes = new int[range];

            // Inicializar los "pigeonholes" con ceros
            for (int i = 0; i < range; i++)
            {
                pigeonholes[i] = 0;
            }

            // Incrementar el conteo en los "pigeonholes" según los valores en el arreglo hasta el índice actual
            for (int i = 0; i <= currentIndex; i++)
            {
                pigeonholes[numbers[i] - min]++;
            }

            // Copiar los elementos desde los "pigeonholes" de vuelta al arreglo hasta el índice actual
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (pigeonholes[i]-- > 0)
                {
                    numbers[index++] = i + min;
                }
            }
        }
    }
}
