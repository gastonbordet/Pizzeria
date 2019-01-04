namespace Pizzas
{
    partial class Form8
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
            this.dataGridPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdioBtnLocal = new System.Windows.Forms.RadioButton();
            this.rdioBtnDelivery = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPedidos
            // 
            this.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidos.Location = new System.Drawing.Point(52, 218);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.Size = new System.Drawing.Size(702, 217);
            this.dataGridPedidos.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxBuscar);
            this.groupBox1.Location = new System.Drawing.Point(52, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "",
            "Cliente",
            "Mesa",
            "IdEmpleado",
            "Facturado"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(151, 32);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(225, 21);
            this.comboBoxBuscar.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(547, 32);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(412, 33);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(120, 20);
            this.txtBoxBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Pedidos";
            // 
            // rdioBtnLocal
            // 
            this.rdioBtnLocal.AutoSize = true;
            this.rdioBtnLocal.Checked = true;
            this.rdioBtnLocal.Location = new System.Drawing.Point(312, 91);
            this.rdioBtnLocal.Name = "rdioBtnLocal";
            this.rdioBtnLocal.Size = new System.Drawing.Size(99, 17);
            this.rdioBtnLocal.TabIndex = 13;
            this.rdioBtnLocal.TabStop = true;
            this.rdioBtnLocal.Text = "Pedidos locales";
            this.rdioBtnLocal.UseVisualStyleBackColor = true;
            this.rdioBtnLocal.CheckedChanged += new System.EventHandler(this.rdioBtnLocal_CheckedChanged);
            // 
            // rdioBtnDelivery
            // 
            this.rdioBtnDelivery.AutoSize = true;
            this.rdioBtnDelivery.Location = new System.Drawing.Point(422, 91);
            this.rdioBtnDelivery.Name = "rdioBtnDelivery";
            this.rdioBtnDelivery.Size = new System.Drawing.Size(102, 17);
            this.rdioBtnDelivery.TabIndex = 13;
            this.rdioBtnDelivery.TabStop = true;
            this.rdioBtnDelivery.Text = "Pedidos delivery";
            this.rdioBtnDelivery.UseVisualStyleBackColor = true;
            this.rdioBtnDelivery.CheckedChanged += new System.EventHandler(this.rdioBtnDelivery_CheckedChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdioBtnDelivery);
            this.Controls.Add(this.rdioBtnLocal);
            this.Controls.Add(this.dataGridPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdioBtnLocal;
        private System.Windows.Forms.RadioButton rdioBtnDelivery;
    }
}