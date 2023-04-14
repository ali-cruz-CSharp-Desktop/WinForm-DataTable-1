
namespace Datatable1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fechaAltaDateTimeP = new System.Windows.Forms.DateTimePicker();
            this.listaUsuariosDGVSinPersonalizar = new System.Windows.Forms.DataGridView();
            this.agregarButton = new System.Windows.Forms.Button();
            this.actualizaDGVPersonalizadoButton = new System.Windows.Forms.Button();
            this.listaUsuariosDGVPersonalizado = new System.Windows.Forms.DataGridView();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listaUsuariosDGV = new System.Windows.Forms.DataGridView();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.seleccionDGV3Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGVSinPersonalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGVPersonalizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Alta";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(139, 45);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 116);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // fechaAltaDateTimeP
            // 
            this.fechaAltaDateTimeP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAltaDateTimeP.Location = new System.Drawing.Point(140, 221);
            this.fechaAltaDateTimeP.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.fechaAltaDateTimeP.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.fechaAltaDateTimeP.Name = "fechaAltaDateTimeP";
            this.fechaAltaDateTimeP.Size = new System.Drawing.Size(156, 20);
            this.fechaAltaDateTimeP.TabIndex = 6;
            // 
            // listaUsuariosDGVSinPersonalizar
            // 
            this.listaUsuariosDGVSinPersonalizar.AllowUserToAddRows = false;
            this.listaUsuariosDGVSinPersonalizar.AllowUserToDeleteRows = false;
            this.listaUsuariosDGVSinPersonalizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosDGVSinPersonalizar.Location = new System.Drawing.Point(328, 45);
            this.listaUsuariosDGVSinPersonalizar.Name = "listaUsuariosDGVSinPersonalizar";
            this.listaUsuariosDGVSinPersonalizar.ReadOnly = true;
            this.listaUsuariosDGVSinPersonalizar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUsuariosDGVSinPersonalizar.Size = new System.Drawing.Size(637, 133);
            this.listaUsuariosDGVSinPersonalizar.TabIndex = 6;
            this.listaUsuariosDGVSinPersonalizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaUsuariosDGVSinPersonalizar_CellClick);
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(137, 305);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(157, 23);
            this.agregarButton.TabIndex = 7;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // actualizaDGVPersonalizadoButton
            // 
            this.actualizaDGVPersonalizadoButton.Location = new System.Drawing.Point(890, 354);
            this.actualizaDGVPersonalizadoButton.Name = "actualizaDGVPersonalizadoButton";
            this.actualizaDGVPersonalizadoButton.Size = new System.Drawing.Size(75, 23);
            this.actualizaDGVPersonalizadoButton.TabIndex = 8;
            this.actualizaDGVPersonalizadoButton.Text = "Actualizar";
            this.actualizaDGVPersonalizadoButton.UseVisualStyleBackColor = true;
            this.actualizaDGVPersonalizadoButton.Click += new System.EventHandler(this.actualizaDGVButton_Click);
            // 
            // listaUsuariosDGVPersonalizado
            // 
            this.listaUsuariosDGVPersonalizado.AllowUserToAddRows = false;
            this.listaUsuariosDGVPersonalizado.AllowUserToDeleteRows = false;
            this.listaUsuariosDGVPersonalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosDGVPersonalizado.Location = new System.Drawing.Point(328, 225);
            this.listaUsuariosDGVPersonalizado.Name = "listaUsuariosDGVPersonalizado";
            this.listaUsuariosDGVPersonalizado.ReadOnly = true;
            this.listaUsuariosDGVPersonalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUsuariosDGVPersonalizado.Size = new System.Drawing.Size(637, 123);
            this.listaUsuariosDGVPersonalizado.TabIndex = 9;
            this.listaUsuariosDGVPersonalizado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaUsuariosDGVPersonalizado_CellClick);
            // 
            // edadTextBox
            // 
            this.edadTextBox.Location = new System.Drawing.Point(138, 172);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(156, 20);
            this.edadTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "DGV con datatable sin personalizar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "DGV con datatable personalizado";
            // 
            // listaUsuariosDGV
            // 
            this.listaUsuariosDGV.AllowUserToAddRows = false;
            this.listaUsuariosDGV.AllowUserToDeleteRows = false;
            this.listaUsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion,
            this.ID,
            this.FirstName,
            this.apellio,
            this.edad,
            this.fechaAlta});
            this.listaUsuariosDGV.Location = new System.Drawing.Point(328, 407);
            this.listaUsuariosDGV.Name = "listaUsuariosDGV";
            this.listaUsuariosDGV.ReadOnly = true;
            this.listaUsuariosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUsuariosDGV.Size = new System.Drawing.Size(637, 159);
            this.listaUsuariosDGV.TabIndex = 14;
            this.listaUsuariosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaUsuariosDGV_CellClick);
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Nombre";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // apellio
            // 
            this.apellio.HeaderText = "Apellido";
            this.apellio.Name = "apellio";
            this.apellio.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "DGV con datatable Forms";
            // 
            // seleccionDGV3Lbl
            // 
            this.seleccionDGV3Lbl.AutoSize = true;
            this.seleccionDGV3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionDGV3Lbl.Location = new System.Drawing.Point(567, 569);
            this.seleccionDGV3Lbl.Name = "seleccionDGV3Lbl";
            this.seleccionDGV3Lbl.Size = new System.Drawing.Size(87, 18);
            this.seleccionDGV3Lbl.TabIndex = 16;
            this.seleccionDGV3Lbl.Text = "Seleccion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 593);
            this.Controls.Add(this.seleccionDGV3Lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listaUsuariosDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaUsuariosDGVPersonalizado);
            this.Controls.Add(this.actualizaDGVPersonalizadoButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.listaUsuariosDGVSinPersonalizar);
            this.Controls.Add(this.fechaAltaDateTimeP);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CRUD DataTable SP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGVSinPersonalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGVPersonalizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker fechaAltaDateTimeP;
        private System.Windows.Forms.DataGridView listaUsuariosDGVSinPersonalizar;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button actualizaDGVPersonalizadoButton;
        private System.Windows.Forms.DataGridView listaUsuariosDGVPersonalizado;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView listaUsuariosDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellio;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.Label seleccionDGV3Lbl;
    }
}

