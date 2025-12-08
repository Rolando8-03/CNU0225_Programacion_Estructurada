using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ListaApp
{
    public partial class Form1 : Form
    {
        // Lista única que contendrá los elementos
        private readonly List<Person> _personas = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            cmbOrdenar.SelectedIndex = 0;
            UpdateListBox();
        }

        // Clase que representa cada elemento de la lista
        private class Person
        {
            public string Nombre { get; }
            public string Apellido { get; }
            public string Cargo { get; }
            public decimal Salario { get; }

            public Person(string nombre, string apellido, string cargo, decimal salario)
            {
                Nombre = nombre;
                Apellido = apellido;
                Cargo = cargo;
                Salario = salario;
            }

            public override string ToString()
            {
                return $"{Nombre} {Apellido} | {Cargo} | {Salario.ToString("C", CultureInfo.CurrentCulture)}";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            // Validar que los cuatro textboxes estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                lblStatus.Text = "Todos los campos (*) deben completarse para agregar.";
                return;
            }

            // Validar salario
            if (!decimal.TryParse(txtSalario.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out var salario))
            {
                lblStatus.Text = "Salario no válido. Use formato numérico.";
                return;
            }

            var p = new Person(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtCargo.Text.Trim(), salario);
            _personas.Add(p);
            UpdateListBox();
            lblStatus.Text = "Elemento agregado.";

            // Opcional: limpiar entradas después de agregar
            txtNombre.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            // Esperamos índice en txtEliminarIndice
            if (string.IsNullOrWhiteSpace(txtEliminarIndice.Text))
            {
                lblStatus.Text = "Escriba el índice (0..n-1) del elemento a eliminar.";
                return;
            }

            if (!int.TryParse(txtEliminarIndice.Text.Trim(), out var idx))
            {
                lblStatus.Text = "Índice inválido.";
                return;
            }

            if (idx < 0 || idx >= _personas.Count)
            {
                lblStatus.Text = $"Índice fuera de rango. Hay {_personas.Count} elemento(s).";
                return;
            }

            var eliminado = _personas[idx];
            _personas.RemoveAt(idx);
            UpdateListBox();
            lblStatus.Text = $"Eliminado: {eliminado.Nombre} {eliminado.Apellido}";
            txtEliminarIndice.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            // Construir criterios a partir de los textboxes: si están vacíos se ignoran
            var nombre = txtNombre.Text.Trim();
            var apellido = txtApellido.Text.Trim();
            var cargo = txtCargo.Text.Trim();
            var salarioText = txtSalario.Text.Trim();

            IEnumerable<Person> query = _personas;

            if (!string.IsNullOrEmpty(nombre))
                query = query.Where(p => p.Nombre.IndexOf(nombre, StringComparison.CurrentCultureIgnoreCase) >= 0);

            if (!string.IsNullOrEmpty(apellido))
                query = query.Where(p => p.Apellido.IndexOf(apellido, StringComparison.CurrentCultureIgnoreCase) >= 0);

            if (!string.IsNullOrEmpty(cargo))
                query = query.Where(p => p.Cargo.IndexOf(cargo, StringComparison.CurrentCultureIgnoreCase) >= 0);

            if (!string.IsNullOrEmpty(salarioText))
            {
                if (decimal.TryParse(salarioText, NumberStyles.Number, CultureInfo.CurrentCulture, out var salario))
                {
                    query = query.Where(p => p.Salario == salario);
                }
                else
                {
                    lblStatus.Text = "Salario de búsqueda inválido. Use formato numérico o deje vacío.";
                    return;
                }
            }

            var results = query.ToList();
            lstPersonas.Items.Clear();
            for (int i = 0; i < results.Count; i++)
            {
                // Mostrar índice para que el usuario pueda eliminar por índice después
                lstPersonas.Items.Add($"[{_personas.IndexOf(results[i])}] {results[i]}");
            }

            lblStatus.Text = $"Encontrado(s): {results.Count}";
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            UpdateListBox();
            lblStatus.Text = "Mostrando todos los elementos.";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            var criterio = cmbOrdenar.SelectedItem as string;
            if (string.IsNullOrEmpty(criterio))
            {
                lblStatus.Text = "Seleccione un criterio de ordenación.";
                return;
            }

            switch (criterio)
            {
                case "Nombre":
                    _personas.Sort((a, b) => string.Compare(a.Nombre, b.Nombre, StringComparison.CurrentCultureIgnoreCase));
                    break;
                case "Apellido":
                    _personas.Sort((a, b) => string.Compare(a.Apellido, b.Apellido, StringComparison.CurrentCultureIgnoreCase));
                    break;
                case "Cargo":
                    _personas.Sort((a, b) => string.Compare(a.Cargo, b.Cargo, StringComparison.CurrentCultureIgnoreCase));
                    break;
                case "Salario":
                    _personas.Sort((a, b) => a.Salario.CompareTo(b.Salario));
                    break;
                default:
                    lblStatus.Text = "Criterio desconocido.";
                    return;
            }

            UpdateListBox();
            lblStatus.Text = $"Lista ordenada por {criterio}.";
        }

        // Actualiza la ListBox a partir de la lista única
        private void UpdateListBox()
        {
            lstPersonas.Items.Clear();
            for (int i = 0; i < _personas.Count; i++)
            {
                lstPersonas.Items.Add($"[{i}] {_personas[i]}");
            }
        }
    }
}
