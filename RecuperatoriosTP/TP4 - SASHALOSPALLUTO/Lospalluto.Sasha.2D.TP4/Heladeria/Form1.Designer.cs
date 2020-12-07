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
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.dgvEnPreparacion = new System.Windows.Forms.DataGridView();
            this.numPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEnPreparacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFinalizados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(703, 570);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // clbListaDeGustos
            // 
            this.clbListaDeGustos.FormattingEnabled = true;
            this.clbListaDeGustos.Location = new System.Drawing.Point(703, 229);
            this.clbListaDeGustos.Name = "clbListaDeGustos";
            this.clbListaDeGustos.Size = new System.Drawing.Size(241, 124);
            this.clbListaDeGustos.TabIndex = 1;
            this.clbListaDeGustos.SelectedIndexChanged += new System.EventHandler(this.clbListaDeGustos_SelectedIndexChanged);
            this.clbListaDeGustos.DoubleClick += new System.EventHandler(this.clbListaDeGustos_DoubleClick);
            // 
            // lblHeladeria
            // 
            this.lblHeladeria.AutoSize = true;
            this.lblHeladeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeladeria.Location = new System.Drawing.Point(467, 9);
            this.lblHeladeria.Name = "lblHeladeria";
            this.lblHeladeria.Size = new System.Drawing.Size(95, 25);
            this.lblHeladeria.TabIndex = 2;
            this.lblHeladeria.Text = "Heladeria";
            // 
            // btnEfectuarPedido
            // 
            this.btnEfectuarPedido.Location = new System.Drawing.Point(814, 570);
            this.btnEfectuarPedido.Name = "btnEfectuarPedido";
            this.btnEfectuarPedido.Size = new System.Drawing.Size(130, 38);
            this.btnEfectuarPedido.TabIndex = 3;
            this.btnEfectuarPedido.Text = "Efectuar Pedido";
            this.btnEfectuarPedido.UseVisualStyleBackColor = true;
            this.btnEfectuarPedido.Click += new System.EventHandler(this.btnEfectuarPedido_Click);
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Location = new System.Drawing.Point(758, 98);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(136, 20);
            this.txbNombreCliente.TabIndex = 4;
            this.txbNombreCliente.TextChanged += new System.EventHandler(this.txbNombreCliente_TextChanged);
            this.txbNombreCliente.Leave += new System.EventHandler(this.txbNombreCliente_Leave);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(669, 101);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.lblNombreCliente.TabIndex = 5;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(863, 524);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(931, 524);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotal.TabIndex = 7;
            this.lblMontoTotal.Text = "0";
            // 
            // cmbTipoDeProducto
            // 
            this.cmbTipoDeProducto.FormattingEnabled = true;
            this.cmbTipoDeProducto.Location = new System.Drawing.Point(758, 140);
            this.cmbTipoDeProducto.Name = "cmbTipoDeProducto";
            this.cmbTipoDeProducto.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoDeProducto.TabIndex = 8;
            this.cmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedIndexChanged);
            this.cmbTipoDeProducto.SelectedValueChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedValueChanged);
            this.cmbTipoDeProducto.TextChanged += new System.EventHandler(this.cmbTipoDeProducto_TextChanged);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(669, 143);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(78, 13);
            this.lblTipoProducto.TabIndex = 9;
            this.lblTipoProducto.Text = "Elegir producto";
            // 
            // lblSeleccionGusto
            // 
            this.lblSeleccionGusto.AutoSize = true;
            this.lblSeleccionGusto.Location = new System.Drawing.Point(771, 213);
            this.lblSeleccionGusto.Name = "lblSeleccionGusto";
            this.lblSeleccionGusto.Size = new System.Drawing.Size(97, 13);
            this.lblSeleccionGusto.TabIndex = 10;
            this.lblSeleccionGusto.Text = "Seleccionar gustos";
            // 
            // lblNuevoPedido
            // 
            this.lblNuevoPedido.AutoSize = true;
            this.lblNuevoPedido.Location = new System.Drawing.Point(779, 38);
            this.lblNuevoPedido.Name = "lblNuevoPedido";
            this.lblNuevoPedido.Size = new System.Drawing.Size(89, 13);
            this.lblNuevoPedido.TabIndex = 11;
            this.lblNuevoPedido.Text = "NUEVO PEDIDO";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPedido.Location = new System.Drawing.Point(704, 360);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(241, 23);
            this.btnAgregarPedido.TabIndex = 12;
            this.btnAgregarPedido.Text = "AGREGAR AL PEDIDO";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // dgvEnPreparacion
            // 
            this.dgvEnPreparacion.AllowUserToDeleteRows = false;
            this.dgvEnPreparacion.AllowUserToResizeColumns = false;
            this.dgvEnPreparacion.AllowUserToResizeRows = false;
            this.dgvEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnPreparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPedido,
            this.Cliente,
            this.total});
            this.dgvEnPreparacion.Location = new System.Drawing.Point(25, 105);
            this.dgvEnPreparacion.Name = "dgvEnPreparacion";
            this.dgvEnPreparacion.ReadOnly = true;
            this.dgvEnPreparacion.Size = new System.Drawing.Size(442, 210);
            this.dgvEnPreparacion.TabIndex = 14;
            // 
            // numPedido
            // 
            this.numPedido.HeaderText = "Numero de pedido";
            this.numPedido.Name = "numPedido";
            this.numPedido.ReadOnly = true;
            this.numPedido.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Monto Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // lblEnPreparacion
            // 
            this.lblEnPreparacion.AutoSize = true;
            this.lblEnPreparacion.Location = new System.Drawing.Point(171, 77);
            this.lblEnPreparacion.Name = "lblEnPreparacion";
            this.lblEnPreparacion.Size = new System.Drawing.Size(102, 13);
            this.lblEnPreparacion.TabIndex = 15;
            this.lblEnPreparacion.Text = "EN PREPARACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "FINALIZADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tamaño";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Location = new System.Drawing.Point(758, 172);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(136, 21);
            this.cmbTamanio.TabIndex = 19;
            this.cmbTamanio.SelectedValueChanged += new System.EventHandler(this.cmbTamanio_SelectedValueChanged);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeColumns = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPedido,
            this.Tam,
            this.Tipo,
            this.precio,
            this.sabor,
            this.Sabor2,
            this.Sabor3,
            this.Sabor4});
            this.dgvCarrito.Location = new System.Drawing.Point(550, 404);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(532, 113);
            this.dgvCarrito.TabIndex = 20;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Numero Pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tam
            // 
            this.Tam.HeaderText = "Tamaño";
            this.Tam.Name = "Tam";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // sabor
            // 
            this.sabor.HeaderText = "Sabor1";
            this.sabor.Name = "sabor";
            // 
            // Sabor2
            // 
            this.Sabor2.HeaderText = "Sabor2";
            this.Sabor2.Name = "Sabor2";
            // 
            // Sabor3
            // 
            this.Sabor3.HeaderText = "Sabor3";
            this.Sabor3.Name = "Sabor3";
            // 
            // Sabor4
            // 
            this.Sabor4.HeaderText = "Sabor4";
            this.Sabor4.Name = "Sabor4";
            // 
            // dgvFinalizados
            // 
            this.dgvFinalizados.AllowUserToDeleteRows = false;
            this.dgvFinalizados.AllowUserToResizeColumns = false;
            this.dgvFinalizados.AllowUserToResizeRows = false;
            this.dgvFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvFinalizados.Location = new System.Drawing.Point(25, 398);
            this.dgvFinalizados.Name = "dgvFinalizados";
            this.dgvFinalizados.ReadOnly = true;
            this.dgvFinalizados.Size = new System.Drawing.Size(442, 210);
            this.dgvFinalizados.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero de pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 635);
            this.Controls.Add(this.dgvFinalizados);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnPreparacion);
            this.Controls.Add(this.dgvEnPreparacion);
            this.Controls.Add(this.btnAgregarPedido);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 - SASHA LOSPALLUTO - 2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizados)).EndInit();
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
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridView dgvEnPreparacion;
        private System.Windows.Forms.Label lblEnPreparacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridView dgvFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

