namespace Pizzas
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxMesas = new System.Windows.Forms.GroupBox();
            this.labelTotalPedido = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.listBoxMesas = new System.Windows.Forms.ListBox();
            this.grpBoxStock = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMonto = new System.Windows.Forms.TextBox();
            this.btnStockear = new System.Windows.Forms.Button();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.cmbBoxStock = new System.Windows.Forms.ComboBox();
            this.grpBoxFinanzas = new System.Windows.Forms.GroupBox();
            this.calendarHasta = new System.Windows.Forms.MonthCalendar();
            this.calendarDesde = new System.Windows.Forms.MonthCalendar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelEgresos = new System.Windows.Forms.Label();
            this.labelIngresos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptarFinanzas = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.grpBoxMesas.SuspendLayout();
            this.grpBoxStock.SuspendLayout();
            this.grpBoxFinanzas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Local";
            // 
            // grpBoxMesas
            // 
            this.grpBoxMesas.Controls.Add(this.btnPagar);
            this.grpBoxMesas.Controls.Add(this.labelTotalPedido);
            this.grpBoxMesas.Controls.Add(this.label11);
            this.grpBoxMesas.Controls.Add(this.listBoxPedidos);
            this.grpBoxMesas.Controls.Add(this.listBoxMesas);
            this.grpBoxMesas.Location = new System.Drawing.Point(46, 114);
            this.grpBoxMesas.Name = "grpBoxMesas";
            this.grpBoxMesas.Size = new System.Drawing.Size(439, 317);
            this.grpBoxMesas.TabIndex = 5;
            this.grpBoxMesas.TabStop = false;
            this.grpBoxMesas.Text = "Mesas Ocupadas";
            // 
            // labelTotalPedido
            // 
            this.labelTotalPedido.AutoSize = true;
            this.labelTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPedido.Location = new System.Drawing.Point(335, 230);
            this.labelTotalPedido.Name = "labelTotalPedido";
            this.labelTotalPedido.Size = new System.Drawing.Size(58, 13);
            this.labelTotalPedido.TabIndex = 2;
            this.labelTotalPedido.Text = "Total: $0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(202, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Pedidos por mesa";
            // 
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(179, 64);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(150, 212);
            this.listBoxPedidos.TabIndex = 1;
            // 
            // listBoxMesas
            // 
            this.listBoxMesas.FormattingEnabled = true;
            this.listBoxMesas.Location = new System.Drawing.Point(13, 64);
            this.listBoxMesas.Name = "listBoxMesas";
            this.listBoxMesas.Size = new System.Drawing.Size(150, 212);
            this.listBoxMesas.TabIndex = 1;
            this.listBoxMesas.SelectedIndexChanged += new System.EventHandler(this.listBoxMesas_SelectedIndexChanged);
            // 
            // grpBoxStock
            // 
            this.grpBoxStock.Controls.Add(this.label3);
            this.grpBoxStock.Controls.Add(this.label12);
            this.grpBoxStock.Controls.Add(this.label9);
            this.grpBoxStock.Controls.Add(this.label2);
            this.grpBoxStock.Controls.Add(this.txtBoxMonto);
            this.grpBoxStock.Controls.Add(this.btnStockear);
            this.grpBoxStock.Controls.Add(this.txtBoxCantidad);
            this.grpBoxStock.Controls.Add(this.txtBoxStock);
            this.grpBoxStock.Controls.Add(this.cmbBoxStock);
            this.grpBoxStock.Location = new System.Drawing.Point(512, 114);
            this.grpBoxStock.Name = "grpBoxStock";
            this.grpBoxStock.Size = new System.Drawing.Size(501, 317);
            this.grpBoxStock.TabIndex = 6;
            this.grpBoxStock.TabStop = false;
            this.grpBoxStock.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reponer ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(170, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Monto ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad disp.";
            // 
            // txtBoxMonto
            // 
            this.txtBoxMonto.Location = new System.Drawing.Point(241, 230);
            this.txtBoxMonto.Name = "txtBoxMonto";
            this.txtBoxMonto.Size = new System.Drawing.Size(108, 20);
            this.txtBoxMonto.TabIndex = 1;
            // 
            // btnStockear
            // 
            this.btnStockear.Location = new System.Drawing.Point(281, 274);
            this.btnStockear.Name = "btnStockear";
            this.btnStockear.Size = new System.Drawing.Size(68, 23);
            this.btnStockear.TabIndex = 2;
            this.btnStockear.Text = "Aceptar";
            this.btnStockear.UseVisualStyleBackColor = true;
            this.btnStockear.Click += new System.EventHandler(this.btnStockear_Click);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(241, 172);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(108, 20);
            this.txtBoxCantidad.TabIndex = 1;
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Enabled = false;
            this.txtBoxStock.Location = new System.Drawing.Point(250, 77);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStock.TabIndex = 1;
            // 
            // cmbBoxStock
            // 
            this.cmbBoxStock.FormattingEnabled = true;
            this.cmbBoxStock.Location = new System.Drawing.Point(149, 39);
            this.cmbBoxStock.Name = "cmbBoxStock";
            this.cmbBoxStock.Size = new System.Drawing.Size(200, 21);
            this.cmbBoxStock.TabIndex = 0;
            this.cmbBoxStock.SelectedIndexChanged += new System.EventHandler(this.cmbBoxStock_SelectedIndexChanged);
            // 
            // grpBoxFinanzas
            // 
            this.grpBoxFinanzas.Controls.Add(this.calendarHasta);
            this.grpBoxFinanzas.Controls.Add(this.calendarDesde);
            this.grpBoxFinanzas.Controls.Add(this.labelTotal);
            this.grpBoxFinanzas.Controls.Add(this.labelEgresos);
            this.grpBoxFinanzas.Controls.Add(this.labelIngresos);
            this.grpBoxFinanzas.Controls.Add(this.label5);
            this.grpBoxFinanzas.Controls.Add(this.label4);
            this.grpBoxFinanzas.Controls.Add(this.btnAceptarFinanzas);
            this.grpBoxFinanzas.Location = new System.Drawing.Point(46, 450);
            this.grpBoxFinanzas.Name = "grpBoxFinanzas";
            this.grpBoxFinanzas.Size = new System.Drawing.Size(967, 347);
            this.grpBoxFinanzas.TabIndex = 7;
            this.grpBoxFinanzas.TabStop = false;
            this.grpBoxFinanzas.Text = "Finanzas";
            // 
            // calendarHasta
            // 
            this.calendarHasta.Location = new System.Drawing.Point(507, 69);
            this.calendarHasta.MaxSelectionCount = 1;
            this.calendarHasta.Name = "calendarHasta";
            this.calendarHasta.ShowTodayCircle = false;
            this.calendarHasta.TabIndex = 4;
            // 
            // calendarDesde
            // 
            this.calendarDesde.Location = new System.Drawing.Point(205, 69);
            this.calendarDesde.MaxSelectionCount = 1;
            this.calendarDesde.Name = "calendarDesde";
            this.calendarDesde.ShowTodayCircle = false;
            this.calendarDesde.TabIndex = 4;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(741, 272);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(89, 31);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total:";
            // 
            // labelEgresos
            // 
            this.labelEgresos.AutoSize = true;
            this.labelEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEgresos.Location = new System.Drawing.Point(420, 283);
            this.labelEgresos.Name = "labelEgresos";
            this.labelEgresos.Size = new System.Drawing.Size(72, 20);
            this.labelEgresos.TabIndex = 1;
            this.labelEgresos.Text = "Gastos:";
            // 
            // labelIngresos
            // 
            this.labelIngresos.AutoSize = true;
            this.labelIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresos.Location = new System.Drawing.Point(236, 283);
            this.labelIngresos.Name = "labelIngresos";
            this.labelIngresos.Size = new System.Drawing.Size(84, 20);
            this.labelIngresos.TabIndex = 1;
            this.labelIngresos.Text = "Ingresos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desde";
            // 
            // btnAceptarFinanzas
            // 
            this.btnAceptarFinanzas.Location = new System.Drawing.Point(806, 99);
            this.btnAceptarFinanzas.Name = "btnAceptarFinanzas";
            this.btnAceptarFinanzas.Size = new System.Drawing.Size(90, 116);
            this.btnAceptarFinanzas.TabIndex = 2;
            this.btnAceptarFinanzas.Text = "Aceptar";
            this.btnAceptarFinanzas.UseVisualStyleBackColor = true;
            this.btnAceptarFinanzas.Click += new System.EventHandler(this.btnAceptarFinanzas_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(338, 253);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 828);
            this.Controls.Add(this.grpBoxFinanzas);
            this.Controls.Add(this.grpBoxStock);
            this.Controls.Add(this.grpBoxMesas);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.grpBoxMesas.ResumeLayout(false);
            this.grpBoxMesas.PerformLayout();
            this.grpBoxStock.ResumeLayout(false);
            this.grpBoxStock.PerformLayout();
            this.grpBoxFinanzas.ResumeLayout(false);
            this.grpBoxFinanzas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxMesas;
        private System.Windows.Forms.GroupBox grpBoxStock;
        private System.Windows.Forms.GroupBox grpBoxFinanzas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStockear;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.ComboBox cmbBoxStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar calendarHasta;
        private System.Windows.Forms.MonthCalendar calendarDesde;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelEgresos;
        private System.Windows.Forms.Label labelIngresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxPedidos;
        private System.Windows.Forms.ListBox listBoxMesas;
        private System.Windows.Forms.Label labelTotalPedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxMonto;
        private System.Windows.Forms.Button btnAceptarFinanzas;
        private System.Windows.Forms.Button btnPagar;
    }
}