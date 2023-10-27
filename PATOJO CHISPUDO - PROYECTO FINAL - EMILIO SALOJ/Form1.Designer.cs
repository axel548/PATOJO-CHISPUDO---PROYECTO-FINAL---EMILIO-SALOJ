namespace PATOJO_CHISPUDO___PROYECTO_FINAL___EMILIO_SALOJ
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label dpiLabel;
            System.Windows.Forms.Label isrLabel;
            System.Windows.Forms.Label igssLabel;
            System.Windows.Forms.Label irtraLabel;
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            this.dpiTextBox = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.patojos_chispudosDataSet = new PATOJO_CHISPUDO___PROYECTO_FINAL___EMILIO_SALOJ.patojos_chispudosDataSet();
            this.patojoschispudosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new PATOJO_CHISPUDO___PROYECTO_FINAL___EMILIO_SALOJ.patojos_chispudosDataSetTableAdapters.empleadosTableAdapter();
            this.tableAdapterManager = new PATOJO_CHISPUDO___PROYECTO_FINAL___EMILIO_SALOJ.patojos_chispudosDataSetTableAdapters.TableAdapterManager();
            this.isrTextBox = new System.Windows.Forms.TextBox();
            this.igssTextBox = new System.Windows.Forms.TextBox();
            this.irtraTextBox = new System.Windows.Forms.TextBox();
            this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            dpiLabel = new System.Windows.Forms.Label();
            isrLabel = new System.Windows.Forms.Label();
            igssLabel = new System.Windows.Forms.Label();
            irtraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patojos_chispudosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patojoschispudosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(41, 155);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(76, 19);
            nombreLabel.TabIndex = 44;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(41, 187);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(77, 19);
            apellidoLabel.TabIndex = 45;
            apellidoLabel.Text = "Apellido:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargoLabel.Location = new System.Drawing.Point(41, 219);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(62, 19);
            cargoLabel.TabIndex = 46;
            cargoLabel.Text = "Cargo:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departamentoLabel.Location = new System.Drawing.Point(41, 251);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(123, 19);
            departamentoLabel.TabIndex = 47;
            departamentoLabel.Text = "Departamento:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sueldoLabel.Location = new System.Drawing.Point(41, 283);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(69, 19);
            sueldoLabel.TabIndex = 48;
            sueldoLabel.Text = "Sueldo:";
            // 
            // dpiLabel
            // 
            dpiLabel.AutoSize = true;
            dpiLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dpiLabel.Location = new System.Drawing.Point(41, 123);
            dpiLabel.Name = "dpiLabel";
            dpiLabel.Size = new System.Drawing.Size(42, 19);
            dpiLabel.TabIndex = 49;
            dpiLabel.Text = "DPI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-83, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-83, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-84, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-83, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sueldo";
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "empleados";
            this.empleadosBindingSource1.DataSource = this.patojoschispudosDataSetBindingSource;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.patojoschispudosDataSetBindingSource;
            this.empleadosBindingSource.CurrentChanged += new System.EventHandler(this.empleadosBindingSource_CurrentChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Departamento de administración y finanzas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "EMPRESA PATOJOS CHISPUDOS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(477, 515);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 47);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(333, 515);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(138, 47);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(189, 515);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(138, 47);
            this.btnInsertar.TabIndex = 18;
            this.btnInsertar.Text = "Guardar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(45, 515);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 47);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoEllipsis = true;
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(395, 455);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(42, 16);
            this.lbl_error.TabIndex = 43;
            this.lbl_error.Text = "Error";
            this.lbl_error.Visible = false;
            this.lbl_error.Click += new System.EventHandler(this.label14_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(621, 515);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(138, 47);
            this.btn_Limpiar.TabIndex = 44;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(178, 152);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(164, 26);
            this.nombreTextBox.TabIndex = 45;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(178, 184);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(164, 26);
            this.apellidoTextBox.TabIndex = 46;
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "cargo", true));
            this.cargoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoTextBox.Location = new System.Drawing.Point(178, 216);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(164, 26);
            this.cargoTextBox.TabIndex = 47;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "departamento", true));
            this.departamentoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoTextBox.Location = new System.Drawing.Point(178, 248);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(164, 26);
            this.departamentoTextBox.TabIndex = 48;
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "sueldo", true));
            this.sueldoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoTextBox.Location = new System.Drawing.Point(178, 280);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(164, 26);
            this.sueldoTextBox.TabIndex = 49;
            // 
            // dpiTextBox
            // 
            this.dpiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "dpi", true));
            this.dpiTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpiTextBox.Location = new System.Drawing.Point(178, 120);
            this.dpiTextBox.Name = "dpiTextBox";
            this.dpiTextBox.Size = new System.Drawing.Size(164, 26);
            this.dpiTextBox.TabIndex = 50;
            // 
            // empleadosBindingSource2
            // 
            this.empleadosBindingSource2.DataMember = "empleados";
            this.empleadosBindingSource2.DataSource = this.patojos_chispudosDataSet;
            // 
            // patojos_chispudosDataSet
            // 
            this.patojos_chispudosDataSet.DataSetName = "patojos_chispudosDataSet";
            this.patojos_chispudosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patojoschispudosDataSetBindingSource
            // 
            this.patojoschispudosDataSetBindingSource.DataSource = this.patojos_chispudosDataSet;
            this.patojoschispudosDataSetBindingSource.Position = 0;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.empleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.UpdateOrder = PATOJO_CHISPUDO___PROYECTO_FINAL___EMILIO_SALOJ.patojos_chispudosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // isrLabel
            // 
            isrLabel.AutoSize = true;
            isrLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isrLabel.Location = new System.Drawing.Point(41, 344);
            isrLabel.Name = "isrLabel";
            isrLabel.Size = new System.Drawing.Size(42, 19);
            isrLabel.TabIndex = 50;
            isrLabel.Text = "ISR:";
            // 
            // isrTextBox
            // 
            this.isrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "isr", true));
            this.isrTextBox.Enabled = false;
            this.isrTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isrTextBox.Location = new System.Drawing.Point(178, 341);
            this.isrTextBox.Name = "isrTextBox";
            this.isrTextBox.Size = new System.Drawing.Size(164, 26);
            this.isrTextBox.TabIndex = 51;
            // 
            // igssLabel
            // 
            igssLabel.AutoSize = true;
            igssLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            igssLabel.Location = new System.Drawing.Point(41, 376);
            igssLabel.Name = "igssLabel";
            igssLabel.Size = new System.Drawing.Size(53, 19);
            igssLabel.TabIndex = 51;
            igssLabel.Text = "IGSS:";
            // 
            // igssTextBox
            // 
            this.igssTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "igss", true));
            this.igssTextBox.Enabled = false;
            this.igssTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igssTextBox.Location = new System.Drawing.Point(178, 373);
            this.igssTextBox.Name = "igssTextBox";
            this.igssTextBox.Size = new System.Drawing.Size(164, 26);
            this.igssTextBox.TabIndex = 52;
            // 
            // irtraLabel
            // 
            irtraLabel.AutoSize = true;
            irtraLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            irtraLabel.Location = new System.Drawing.Point(41, 408);
            irtraLabel.Name = "irtraLabel";
            irtraLabel.Size = new System.Drawing.Size(64, 19);
            irtraLabel.TabIndex = 52;
            irtraLabel.Text = "IRTRA:";
            // 
            // irtraTextBox
            // 
            this.irtraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource2, "irtra", true));
            this.irtraTextBox.Enabled = false;
            this.irtraTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irtraTextBox.Location = new System.Drawing.Point(178, 405);
            this.irtraTextBox.Name = "irtraTextBox";
            this.irtraTextBox.Size = new System.Drawing.Size(164, 26);
            this.irtraTextBox.TabIndex = 53;
            // 
            // empleadosDataGridView
            // 
            this.empleadosDataGridView.AutoGenerateColumns = false;
            this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.empleadosDataGridView.DataSource = this.empleadosBindingSource2;
            this.empleadosDataGridView.Location = new System.Drawing.Point(421, 123);
            this.empleadosDataGridView.Name = "empleadosDataGridView";
            this.empleadosDataGridView.Size = new System.Drawing.Size(612, 308);
            this.empleadosDataGridView.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dpi";
            this.dataGridViewTextBoxColumn1.HeaderText = "dpi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cargo";
            this.dataGridViewTextBoxColumn4.HeaderText = "cargo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "departamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "departamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "sueldo";
            this.dataGridViewTextBoxColumn6.HeaderText = "sueldo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "sueldo1";
            this.dataGridViewTextBoxColumn7.HeaderText = "sueldo1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "isr";
            this.dataGridViewTextBoxColumn8.HeaderText = "isr";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "igss";
            this.dataGridViewTextBoxColumn9.HeaderText = "igss";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "irtra";
            this.dataGridViewTextBoxColumn10.HeaderText = "irtra";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 582);
            this.Controls.Add(this.empleadosDataGridView);
            this.Controls.Add(irtraLabel);
            this.Controls.Add(this.irtraTextBox);
            this.Controls.Add(igssLabel);
            this.Controls.Add(this.igssTextBox);
            this.Controls.Add(isrLabel);
            this.Controls.Add(this.isrTextBox);
            this.Controls.Add(dpiLabel);
            this.Controls.Add(this.dpiTextBox);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patojos_chispudosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patojoschispudosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource patojoschispudosDataSetBindingSource;
        private patojos_chispudosDataSet patojos_chispudosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private patojos_chispudosDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private System.Windows.Forms.BindingSource empleadosBindingSource2;
        private patojos_chispudosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.TextBox sueldoTextBox;
        private System.Windows.Forms.TextBox dpiTextBox;
        private System.Windows.Forms.TextBox isrTextBox;
        private System.Windows.Forms.TextBox igssTextBox;
        private System.Windows.Forms.TextBox irtraTextBox;
        private System.Windows.Forms.DataGridView empleadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

