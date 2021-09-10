namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.pac_nombres = new System.Windows.Forms.TextBox();
            this.pac_documento = new System.Windows.Forms.TextBox();
            this.pac_apellidos = new System.Windows.Forms.TextBox();
            this.pac_tipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pac_fechaNacimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pac_telefono = new System.Windows.Forms.TextBox();
            this.pac_estadoCivil = new System.Windows.Forms.ComboBox();
            this.pac_sexo = new System.Windows.Forms.ComboBox();
            this.pac_correo = new System.Windows.Forms.TextBox();
            this.pac_direccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pac_ciudad = new System.Windows.Forms.TextBox();
            this.pac_recomendacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tblresponsables_id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.odo_fecha = new System.Windows.Forms.TextBox();
            this.odo_pronostico = new System.Windows.Forms.TextBox();
            this.odo_cop = new System.Windows.Forms.TextBox();
            this.tblzonas_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(386, 380);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // pac_nombres
            // 
            this.pac_nombres.Location = new System.Drawing.Point(151, 93);
            this.pac_nombres.Name = "pac_nombres";
            this.pac_nombres.Size = new System.Drawing.Size(100, 20);
            this.pac_nombres.TabIndex = 4;
            // 
            // pac_documento
            // 
            this.pac_documento.Location = new System.Drawing.Point(151, 63);
            this.pac_documento.Name = "pac_documento";
            this.pac_documento.Size = new System.Drawing.Size(100, 20);
            this.pac_documento.TabIndex = 5;
            // 
            // pac_apellidos
            // 
            this.pac_apellidos.Location = new System.Drawing.Point(151, 123);
            this.pac_apellidos.Name = "pac_apellidos";
            this.pac_apellidos.Size = new System.Drawing.Size(100, 20);
            this.pac_apellidos.TabIndex = 6;
            // 
            // pac_tipoDocumento
            // 
            this.pac_tipoDocumento.FormattingEnabled = true;
            this.pac_tipoDocumento.Items.AddRange(new object[] {
            "Cedula",
            "Tarjeta de Identidad",
            "Registro civivl",
            "Cedula Extranjera"});
            this.pac_tipoDocumento.Location = new System.Drawing.Point(151, 29);
            this.pac_tipoDocumento.Name = "pac_tipoDocumento";
            this.pac_tipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.pac_tipoDocumento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado Civil:";
            // 
            // pac_fechaNacimiento
            // 
            this.pac_fechaNacimiento.Location = new System.Drawing.Point(151, 155);
            this.pac_fechaNacimiento.Name = "pac_fechaNacimiento";
            this.pac_fechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.pac_fechaNacimiento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Correo:";
            // 
            // pac_telefono
            // 
            this.pac_telefono.Location = new System.Drawing.Point(151, 243);
            this.pac_telefono.Name = "pac_telefono";
            this.pac_telefono.Size = new System.Drawing.Size(100, 20);
            this.pac_telefono.TabIndex = 15;
            // 
            // pac_estadoCivil
            // 
            this.pac_estadoCivil.FormattingEnabled = true;
            this.pac_estadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Soltero(a)",
            "Viudo(a)"});
            this.pac_estadoCivil.Location = new System.Drawing.Point(151, 184);
            this.pac_estadoCivil.Name = "pac_estadoCivil";
            this.pac_estadoCivil.Size = new System.Drawing.Size(121, 21);
            this.pac_estadoCivil.TabIndex = 16;
            // 
            // pac_sexo
            // 
            this.pac_sexo.FormattingEnabled = true;
            this.pac_sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.pac_sexo.Location = new System.Drawing.Point(151, 214);
            this.pac_sexo.Name = "pac_sexo";
            this.pac_sexo.Size = new System.Drawing.Size(121, 21);
            this.pac_sexo.TabIndex = 17;
            // 
            // pac_correo
            // 
            this.pac_correo.Location = new System.Drawing.Point(151, 274);
            this.pac_correo.Name = "pac_correo";
            this.pac_correo.Size = new System.Drawing.Size(100, 20);
            this.pac_correo.TabIndex = 18;
            // 
            // pac_direccion
            // 
            this.pac_direccion.Location = new System.Drawing.Point(151, 307);
            this.pac_direccion.Name = "pac_direccion";
            this.pac_direccion.Size = new System.Drawing.Size(100, 20);
            this.pac_direccion.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Direccion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Responsables ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ciudad:";
            // 
            // pac_ciudad
            // 
            this.pac_ciudad.Location = new System.Drawing.Point(151, 342);
            this.pac_ciudad.Name = "pac_ciudad";
            this.pac_ciudad.Size = new System.Drawing.Size(100, 20);
            this.pac_ciudad.TabIndex = 23;
            // 
            // pac_recomendacion
            // 
            this.pac_recomendacion.Location = new System.Drawing.Point(151, 412);
            this.pac_recomendacion.Multiline = true;
            this.pac_recomendacion.Name = "pac_recomendacion";
            this.pac_recomendacion.Size = new System.Drawing.Size(121, 78);
            this.pac_recomendacion.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Recomendaciones:";
            // 
            // tblresponsables_id
            // 
            this.tblresponsables_id.Location = new System.Drawing.Point(151, 377);
            this.tblresponsables_id.Name = "tblresponsables_id";
            this.tblresponsables_id.Size = new System.Drawing.Size(100, 20);
            this.tblresponsables_id.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "PACIENTES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(383, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "ODONTOGRAMAS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Fecha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(330, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Pronostico:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(330, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "COP:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(330, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Zona:";
            // 
            // odo_fecha
            // 
            this.odo_fecha.Location = new System.Drawing.Point(401, 30);
            this.odo_fecha.Name = "odo_fecha";
            this.odo_fecha.Size = new System.Drawing.Size(100, 20);
            this.odo_fecha.TabIndex = 33;
            // 
            // odo_pronostico
            // 
            this.odo_pronostico.Location = new System.Drawing.Point(401, 63);
            this.odo_pronostico.Name = "odo_pronostico";
            this.odo_pronostico.Size = new System.Drawing.Size(100, 20);
            this.odo_pronostico.TabIndex = 34;
            // 
            // odo_cop
            // 
            this.odo_cop.Location = new System.Drawing.Point(401, 93);
            this.odo_cop.Name = "odo_cop";
            this.odo_cop.Size = new System.Drawing.Size(100, 20);
            this.odo_cop.TabIndex = 35;
            // 
            // tblzonas_id
            // 
            this.tblzonas_id.Location = new System.Drawing.Point(401, 123);
            this.tblzonas_id.Name = "tblzonas_id";
            this.tblzonas_id.Size = new System.Drawing.Size(100, 20);
            this.tblzonas_id.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(466, 482);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Daya :3";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 504);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblzonas_id);
            this.Controls.Add(this.odo_cop);
            this.Controls.Add(this.odo_pronostico);
            this.Controls.Add(this.odo_fecha);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tblresponsables_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pac_recomendacion);
            this.Controls.Add(this.pac_ciudad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pac_direccion);
            this.Controls.Add(this.pac_correo);
            this.Controls.Add(this.pac_sexo);
            this.Controls.Add(this.pac_estadoCivil);
            this.Controls.Add(this.pac_telefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pac_fechaNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pac_tipoDocumento);
            this.Controls.Add(this.pac_apellidos);
            this.Controls.Add(this.pac_documento);
            this.Controls.Add(this.pac_nombres);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox pac_nombres;
        private System.Windows.Forms.TextBox pac_documento;
        private System.Windows.Forms.TextBox pac_apellidos;
        private System.Windows.Forms.ComboBox pac_tipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pac_fechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pac_telefono;
        private System.Windows.Forms.ComboBox pac_estadoCivil;
        private System.Windows.Forms.ComboBox pac_sexo;
        private System.Windows.Forms.TextBox pac_correo;
        private System.Windows.Forms.TextBox pac_direccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pac_ciudad;
        private System.Windows.Forms.TextBox pac_recomendacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tblresponsables_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox odo_fecha;
        private System.Windows.Forms.TextBox odo_pronostico;
        private System.Windows.Forms.TextBox odo_cop;
        private System.Windows.Forms.TextBox tblzonas_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
    }
}

