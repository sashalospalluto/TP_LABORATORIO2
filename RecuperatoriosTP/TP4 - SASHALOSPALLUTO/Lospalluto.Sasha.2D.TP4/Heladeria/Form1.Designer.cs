namespace Heladeria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clbListaDeGustos = new System.Windows.Forms.CheckedListBox();
            this.lblHeladeria = new System.Windows.Forms.Label();
            this.btnEfectuarPedido = new System.Windows.Forms.Button();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.cmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblSeleccionGusto = new System.Windows.Forms.Label();
            this.lblNuevoPedido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblEnPreparacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(544, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // clbListaDeGustos
            // 
            this.clbListaDeGustos.FormattingEnabled = true;
            this.clbListaDeGustos.Location = new System.Drawing.Point(544, 246);
            this.clbListaDeGustos.Name = "clbListaDeGustos";
            this.clbListaDeGustos.Size = new System.Drawing.Size(241, 124);
            this.clbListaDeGustos.TabIndex = 1;
            // 
            // lblHeladeria
            // 
            this.lblHeladeria.AutoSize = true;
            this.lblHeladeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeladeria.Location = new System.Drawing.Point(326, 10);
            this.lblHeladeria.Name = "lblHeladeria";
            this.lblHeladeria.Size = new System.Drawing.Size(95, 25);
            this.lblHeladeria.TabIndex = 2;
            this.lblHeladeria.Text = "Heladeria";
            // 
            // btnEfectuarPedido
            // 
            this.btnEfectuarPedido.Location = new System.Drawing.Point(655, 413);
            this.btnEfectuarPedido.Name = "btnEfectuarPedido";
            this.btnEfectuarPedido.Size = new System.Drawing.Size(130, 38);
            this.btnEfectuarPedido.TabIndex = 3;
            this.btnEfectuarPedido.Text = "Efectuar Pedido";
            this.btnEfectuarPedido.UseVisualStyleBackColor = true;
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Location = new System.Drawing.Point(631, 115);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(136, 20);
            this.txbNombreCliente.TabIndex = 4;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(542, 118);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.lblNombreCliente.TabIndex = 5;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(695, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(763, 381);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotal.TabIndex = 7;
            this.lblMontoTotal.Text = "0";
            // 
            // cmbTipoDeProducto
            // 
            this.cmbTipoDeProducto.FormattingEnabled = true;
            this.cmbTipoDeProducto.Location = new System.Drawing.Point(631, 157);
            this.cmbTipoDeProducto.Name = "cmbTipoDeProducto";
            this.cmbTipoDeProducto.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoDeProducto.TabIndex = 8;
            this.cmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedIndexChanged);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(542, 160);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(78, 13);
            this.lblTipoProducto.TabIndex = 9;
            this.lblTipoProducto.Text = "Elegir producto";
            // 
            // lblSeleccionGusto
            // 
            this.lblSeleccionGusto.AutoSize = true;
            this.lblSeleccionGusto.Location = new System.Drawing.Point(624, 230);
            this.lblSeleccionGusto.Name = "lblSeleccionGusto";
            this.lblSeleccionGusto.Size = new System.Drawing.Size(97, 13);
            this.lblSeleccionGusto.TabIndex = 10;
            this.lblSeleccionGusto.Text = "Seleccionar gustos";
            // 
            // lblNuevoPedido
            // 
            this.lblNuevoPedido.AutoSize = true;
            this.lblNuevoPedido.Location = new System.Drawing.Point(628, 65);
            this.lblNuevoPedido.Name = "lblNuevoPedido";
            this.lblNuevoPedido.Size = new System.Drawing.Size(89, 13);
            this.lblNuevoPedido.TabIndex = 11;
            this.lblNuevoPedido.Text = "NUEVO PEDIDO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "AGREGAR AL PEDIDO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 129);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(74, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(402, 129);
            this.dataGridView2.TabIndex = 14;
            // 
            // lblEnPreparacion
            // 
            this.lblEnPreparacion.AutoSize = true;
            this.lblEnPreparacion.Location = new System.Drawing.Point(71, 65);
            this.lblEnPreparacion.Name = "lblEnPreparacion";
            this.lblEnPreparacion.Size = new System.Drawing.Size(102, 13);
            this.lblEnPreparacion.TabIndex = 15;
            this.lblEnPreparacion.Text = "EN PREPARACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FINALIZADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tamaño";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Location = new System.Drawing.Point(631, 189);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(136, 21);
            this.cmbTamanio.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 466);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnPreparacion);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNuevoPedido);
            this.Controls.Add(this.lblSeleccionGusto);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.cmbTipoDeProducto);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txbNombreCliente);
            this.Controls.Add(this.btnEfectuarPedido);
            this.Controls.Add(this.lblHeladeria);
            this.Controls.Add(this.clbListaDeGustos);
            this.Controls.Add(this.btnCancelar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox clbListaDeGustos;
        private System.Windows.Forms.Label lblHeladeria;
        private System.Windows.Forms.Button btnEfectuarPedido;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.ComboBox cmbTipoDeProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblSeleccionGusto;
        private System.Windows.Forms.Label lblNuevoPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblEnPreparacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamanio;
    }
}

