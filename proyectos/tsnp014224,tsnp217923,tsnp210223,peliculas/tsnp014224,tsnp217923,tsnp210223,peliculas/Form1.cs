using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsnp014224_tsnp217923_tsnp210223_peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet.peliculas);
            registros();
        }
        private void registros()
        {
            lblRegistros.Text = (peliculasBindingSource.Position + 1) + " de " + peliculasBindingSource.Count;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveFirst();
            registros();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MovePrevious();
            registros();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveNext();
            registros();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            peliculasBindingSource.MoveLast();
            registros();
        }

        private void estadoctrls(Boolean estado)
        {
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
            grbDatos.Enabled = !estado;
            registros();
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if( btnAgregar.Text=="Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoctrls(false);
                peliculasBindingSource.AddNew();// agrega un nuevo registro.
            }else //guardar 
            {
                peliculasBindingSource.EndEdit();
                peliculasTableAdapter.Update(this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet);
                estadoctrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoctrls(false);
            }
            else //cancelar
                peliculasBindingSource.CancelEdit();
            {
                estadoctrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            if (MessageBox.Show("Estas seguro de eliminar a: "+ nombreTextBox.Text+ "?", "Eliminando registros peliculas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                peliculasBindingSource.RemoveCurrent();
                peliculasTableAdapter.Update(_db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet);
                registros();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = peliculasDataGridView.DataSource;
            bs.Filter = "titulo like '%" + txtBuscar.Text + "%'  or autor like '%" + txtBuscar.Text + "%'";
            peliculasDataGridView.DataSource = bs;
        }
    }
    }
    
    
    
    
    