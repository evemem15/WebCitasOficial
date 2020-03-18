namespace Proyecto_Clinica
{
    partial class FormCitas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pacienteIdLabel;
            System.Windows.Forms.Label horaIdLabel;
            System.Windows.Forms.Label doctorIdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
            this.listaCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCitaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaCitaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.pacienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horaIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaHorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaDoctoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dataSet = new Proyecto_Clinica.DataSet();
            this.citaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citaTableAdapter = new Proyecto_Clinica.DataSetTableAdapters.CitaTableAdapter();
            this.tableAdapterManager = new Proyecto_Clinica.DataSetTableAdapters.TableAdapterManager();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            pacienteIdLabel = new System.Windows.Forms.Label();
            horaIdLabel = new System.Windows.Forms.Label();
            doctorIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingNavigator)).BeginInit();
            this.listaCitaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pacienteIdLabel
            // 
            pacienteIdLabel.AutoSize = true;
            pacienteIdLabel.Location = new System.Drawing.Point(371, 55);
            pacienteIdLabel.Name = "pacienteIdLabel";
            pacienteIdLabel.Size = new System.Drawing.Size(52, 13);
            pacienteIdLabel.TabIndex = 1;
            pacienteIdLabel.Text = "Paciente:";
            // 
            // horaIdLabel
            // 
            horaIdLabel.AutoSize = true;
            horaIdLabel.Location = new System.Drawing.Point(43, 98);
            horaIdLabel.Name = "horaIdLabel";
            horaIdLabel.Size = new System.Drawing.Size(33, 13);
            horaIdLabel.TabIndex = 3;
            horaIdLabel.Text = "Hora:";
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Location = new System.Drawing.Point(371, 104);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new System.Drawing.Size(42, 13);
            doctorIdLabel.TabIndex = 5;
            doctorIdLabel.Text = "Doctor:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(43, 51);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(43, 146);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // listaCitaBindingSource
            // 
            this.listaCitaBindingSource.DataSource = typeof(BL.Cita);
            // 
            // listaCitaBindingNavigator
            // 
            this.listaCitaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaCitaBindingNavigator.BindingSource = this.listaCitaBindingSource;
            this.listaCitaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCitaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaCitaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaCitaBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaCitaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaCitaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCitaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCitaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCitaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCitaBindingNavigator.Name = "listaCitaBindingNavigator";
            this.listaCitaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCitaBindingNavigator.Size = new System.Drawing.Size(669, 25);
            this.listaCitaBindingNavigator.TabIndex = 0;
            this.listaCitaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaCitaBindingNavigatorSaveItem
            // 
            this.listaCitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaCitaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaCitaBindingNavigatorSaveItem.Image")));
            this.listaCitaBindingNavigatorSaveItem.Name = "listaCitaBindingNavigatorSaveItem";
            this.listaCitaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaCitaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaCitaBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaCitaBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            // 
            // pacienteIdComboBox
            // 
            this.pacienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCitaBindingSource, "PacienteId", true));
            this.pacienteIdComboBox.DataSource = this.listaPacienteBindingSource;
            this.pacienteIdComboBox.DisplayMember = "Nombre";
            this.pacienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacienteIdComboBox.FormattingEnabled = true;
            this.pacienteIdComboBox.Location = new System.Drawing.Point(439, 55);
            this.pacienteIdComboBox.Name = "pacienteIdComboBox";
            this.pacienteIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.pacienteIdComboBox.TabIndex = 2;
            this.pacienteIdComboBox.ValueMember = "Id";
            // 
            // listaPacienteBindingSource
            // 
            this.listaPacienteBindingSource.DataSource = typeof(BL.Paciente);
            // 
            // horaIdComboBox
            // 
            this.horaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCitaBindingSource, "HoraId", true));
            this.horaIdComboBox.DataSource = this.listaHorasBindingSource;
            this.horaIdComboBox.DisplayMember = "Descripcion";
            this.horaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horaIdComboBox.FormattingEnabled = true;
            this.horaIdComboBox.Location = new System.Drawing.Point(97, 93);
            this.horaIdComboBox.Name = "horaIdComboBox";
            this.horaIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.horaIdComboBox.TabIndex = 4;
            this.horaIdComboBox.ValueMember = "Id";
            // 
            // listaHorasBindingSource
            // 
            this.listaHorasBindingSource.DataSource = typeof(BL.Hora);
            // 
            // doctorIdComboBox
            // 
            this.doctorIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCitaBindingSource, "DoctorId", true));
            this.doctorIdComboBox.DataSource = this.listaDoctoresBindingSource;
            this.doctorIdComboBox.DisplayMember = "Nombre";
            this.doctorIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorIdComboBox.FormattingEnabled = true;
            this.doctorIdComboBox.Location = new System.Drawing.Point(439, 101);
            this.doctorIdComboBox.Name = "doctorIdComboBox";
            this.doctorIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.doctorIdComboBox.TabIndex = 6;
            this.doctorIdComboBox.ValueMember = "Id";
            // 
            // listaDoctoresBindingSource
            // 
            this.listaDoctoresBindingSource.DataSource = typeof(BL.Doctor);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(97, 48);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citaBindingSource
            // 
            this.citaBindingSource.DataMember = "Cita";
            this.citaBindingSource.DataSource = this.dataSet;
            // 
            // citaTableAdapter
            // 
            this.citaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.CitaTableAdapter = this.citaTableAdapter;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.HoraTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto_Clinica.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.citaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(97, 146);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 10;
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Proyecto_Clinica.Properties.Resources.sala_espera_mostrador_ilustracion_aeropuerto_1262_16630;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(669, 249);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(doctorIdLabel);
            this.Controls.Add(this.doctorIdComboBox);
            this.Controls.Add(horaIdLabel);
            this.Controls.Add(this.horaIdComboBox);
            this.Controls.Add(pacienteIdLabel);
            this.Controls.Add(this.pacienteIdComboBox);
            this.Controls.Add(this.listaCitaBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "FormCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.FormCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingNavigator)).EndInit();
            this.listaCitaBindingNavigator.ResumeLayout(false);
            this.listaCitaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaCitaBindingSource;
        private System.Windows.Forms.BindingNavigator listaCitaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaCitaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.ComboBox pacienteIdComboBox;
        private System.Windows.Forms.ComboBox horaIdComboBox;
        private System.Windows.Forms.BindingSource listaHorasBindingSource;
        private System.Windows.Forms.ComboBox doctorIdComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource listaPacienteBindingSource;
        private System.Windows.Forms.BindingSource listaDoctoresBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource citaBindingSource;
        private DataSetTableAdapters.CitaTableAdapter citaTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
    }
}