namespace GestionInventario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rAdmin_Nombre = new TextBox();
            rAdmin_Edad = new TextBox();
            iAdmin_Email = new TextBox();
            iAdmin_Password = new TextBox();
            txtBox_Nombre = new TextBox();
            txtBox_Precio = new TextBox();
            txtBox_Cantidad = new TextBox();
            txtBox_Categoria = new TextBox();
            label2 = new Label();
            add_btn = new Button();
            delete_btn = new Button();
            txtBox_Id = new TextBox();
            update_btn = new Button();
            read_btn = new Button();
            read_all_btn = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            rAdmin_Email = new TextBox();
            rAdmin_Password = new TextBox();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label5 = new Label();
            adminRegister = new Button();
            adminLogIn = new Button();
            adminbtn_delete = new Button();
            adminbtn_update = new Button();
            adminbtn_read = new Button();
            admin_id = new TextBox();
            label6 = new Label();
            adminbtn_readAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // rAdmin_Nombre
            // 
            rAdmin_Nombre.Location = new Point(12, 278);
            rAdmin_Nombre.Name = "rAdmin_Nombre";
            rAdmin_Nombre.Size = new Size(131, 23);
            rAdmin_Nombre.TabIndex = 1;
            rAdmin_Nombre.Text = "Nombre";
            // 
            // rAdmin_Edad
            // 
            rAdmin_Edad.Location = new Point(12, 307);
            rAdmin_Edad.Name = "rAdmin_Edad";
            rAdmin_Edad.Size = new Size(131, 23);
            rAdmin_Edad.TabIndex = 2;
            rAdmin_Edad.Text = "Edad";
            // 
            // iAdmin_Email
            // 
            iAdmin_Email.Location = new Point(12, 61);
            iAdmin_Email.Name = "iAdmin_Email";
            iAdmin_Email.Size = new Size(131, 23);
            iAdmin_Email.TabIndex = 3;
            iAdmin_Email.Text = "Email";
            // 
            // iAdmin_Password
            // 
            iAdmin_Password.Location = new Point(12, 90);
            iAdmin_Password.Name = "iAdmin_Password";
            iAdmin_Password.Size = new Size(131, 23);
            iAdmin_Password.TabIndex = 4;
            iAdmin_Password.Text = "Password";
            // 
            // txtBox_Nombre
            // 
            txtBox_Nombre.Location = new Point(13, 447);
            txtBox_Nombre.Name = "txtBox_Nombre";
            txtBox_Nombre.Size = new Size(131, 23);
            txtBox_Nombre.TabIndex = 5;
            txtBox_Nombre.Text = "Nombre";
            // 
            // txtBox_Precio
            // 
            txtBox_Precio.Location = new Point(13, 476);
            txtBox_Precio.Name = "txtBox_Precio";
            txtBox_Precio.Size = new Size(131, 23);
            txtBox_Precio.TabIndex = 6;
            txtBox_Precio.Text = "Precio";
            // 
            // txtBox_Cantidad
            // 
            txtBox_Cantidad.Location = new Point(13, 505);
            txtBox_Cantidad.Name = "txtBox_Cantidad";
            txtBox_Cantidad.Size = new Size(131, 23);
            txtBox_Cantidad.TabIndex = 7;
            txtBox_Cantidad.Text = "Cantidad";
            // 
            // txtBox_Categoria
            // 
            txtBox_Categoria.Location = new Point(13, 534);
            txtBox_Categoria.Name = "txtBox_Categoria";
            txtBox_Categoria.Size = new Size(131, 23);
            txtBox_Categoria.TabIndex = 8;
            txtBox_Categoria.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 400);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 9;
            label2.Text = "Datos producto:";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(174, 585);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(92, 23);
            add_btn.TabIndex = 15;
            add_btn.Text = "Agregar";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(174, 615);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(93, 23);
            delete_btn.TabIndex = 16;
            delete_btn.Text = "Eliminar";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // txtBox_Id
            // 
            txtBox_Id.Location = new Point(13, 418);
            txtBox_Id.Name = "txtBox_Id";
            txtBox_Id.Size = new Size(131, 23);
            txtBox_Id.TabIndex = 18;
            txtBox_Id.Text = "Id";
            // 
            // update_btn
            // 
            update_btn.Location = new Point(174, 644);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(93, 23);
            update_btn.TabIndex = 19;
            update_btn.Text = "Modificar";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // read_btn
            // 
            read_btn.Location = new Point(174, 672);
            read_btn.Name = "read_btn";
            read_btn.Size = new Size(92, 23);
            read_btn.TabIndex = 20;
            read_btn.Text = "Leer";
            read_btn.UseVisualStyleBackColor = true;
            read_btn.Click += read_btn_Click;
            // 
            // read_all_btn
            // 
            read_all_btn.Location = new Point(174, 701);
            read_all_btn.Name = "read_all_btn";
            read_all_btn.Size = new Size(93, 23);
            read_all_btn.TabIndex = 21;
            read_all_btn.Text = "Leer todo";
            read_all_btn.UseVisualStyleBackColor = true;
            read_all_btn.Click += read_all_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 397);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(659, 327);
            dataGridView1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 43);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 23;
            label3.Text = "Iniciar sesion de admin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 202);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 24;
            label4.Text = "Registrar admin:";
            // 
            // rAdmin_Email
            // 
            rAdmin_Email.Location = new Point(12, 220);
            rAdmin_Email.Name = "rAdmin_Email";
            rAdmin_Email.Size = new Size(131, 23);
            rAdmin_Email.TabIndex = 25;
            rAdmin_Email.Text = "Email";
            // 
            // rAdmin_Password
            // 
            rAdmin_Password.Location = new Point(12, 249);
            rAdmin_Password.Name = "rAdmin_Password";
            rAdmin_Password.Size = new Size(131, 23);
            rAdmin_Password.TabIndex = 26;
            rAdmin_Password.Text = "Password";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(272, 61);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(659, 269);
            dataGridView2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 379);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 28;
            label1.Text = "Datos productos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 43);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 29;
            label5.Text = "Datos Admin:";
            // 
            // adminRegister
            // 
            adminRegister.Location = new Point(12, 336);
            adminRegister.Name = "adminRegister";
            adminRegister.Size = new Size(92, 23);
            adminRegister.TabIndex = 30;
            adminRegister.Text = "Registrar";
            adminRegister.UseVisualStyleBackColor = true;
            adminRegister.Click += adminRegister_Click;
            // 
            // adminLogIn
            // 
            adminLogIn.Location = new Point(12, 119);
            adminLogIn.Name = "adminLogIn";
            adminLogIn.Size = new Size(92, 23);
            adminLogIn.TabIndex = 31;
            adminLogIn.Text = "Iniciar sesion";
            adminLogIn.UseVisualStyleBackColor = true;
            adminLogIn.Click += adminLogIn_Click;
            // 
            // adminbtn_delete
            // 
            adminbtn_delete.Location = new Point(991, 167);
            adminbtn_delete.Name = "adminbtn_delete";
            adminbtn_delete.Size = new Size(92, 23);
            adminbtn_delete.TabIndex = 32;
            adminbtn_delete.Text = "Eliminar";
            adminbtn_delete.UseVisualStyleBackColor = true;
            adminbtn_delete.Click += adminbtn_delete_Click;
            // 
            // adminbtn_update
            // 
            adminbtn_update.Location = new Point(991, 138);
            adminbtn_update.Name = "adminbtn_update";
            adminbtn_update.Size = new Size(92, 23);
            adminbtn_update.TabIndex = 33;
            adminbtn_update.Text = "Modificar";
            adminbtn_update.UseVisualStyleBackColor = true;
            adminbtn_update.Click += adminbtn_update_Click;
            // 
            // adminbtn_read
            // 
            adminbtn_read.Location = new Point(991, 109);
            adminbtn_read.Name = "adminbtn_read";
            adminbtn_read.Size = new Size(92, 23);
            adminbtn_read.TabIndex = 34;
            adminbtn_read.Text = "Buscar";
            adminbtn_read.UseVisualStyleBackColor = true;
            adminbtn_read.Click += adminbtn_read_Click;
            // 
            // admin_id
            // 
            admin_id.Location = new Point(1089, 66);
            admin_id.Name = "admin_id";
            admin_id.Size = new Size(100, 23);
            admin_id.TabIndex = 35;
            admin_id.Text = "id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(991, 69);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 36;
            label6.Text = "Acciones extras:";
            // 
            // adminbtn_readAll
            // 
            adminbtn_readAll.Location = new Point(991, 196);
            adminbtn_readAll.Name = "adminbtn_readAll";
            adminbtn_readAll.Size = new Size(92, 23);
            adminbtn_readAll.TabIndex = 37;
            adminbtn_readAll.Text = "Buscar Todos";
            adminbtn_readAll.UseVisualStyleBackColor = true;
            adminbtn_readAll.Click += adminbtn_readAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 841);
            Controls.Add(adminbtn_readAll);
            Controls.Add(label6);
            Controls.Add(admin_id);
            Controls.Add(adminbtn_read);
            Controls.Add(adminbtn_update);
            Controls.Add(adminbtn_delete);
            Controls.Add(adminLogIn);
            Controls.Add(adminRegister);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(rAdmin_Password);
            Controls.Add(rAdmin_Email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(read_all_btn);
            Controls.Add(read_btn);
            Controls.Add(update_btn);
            Controls.Add(txtBox_Id);
            Controls.Add(delete_btn);
            Controls.Add(add_btn);
            Controls.Add(label2);
            Controls.Add(txtBox_Categoria);
            Controls.Add(txtBox_Cantidad);
            Controls.Add(txtBox_Precio);
            Controls.Add(txtBox_Nombre);
            Controls.Add(iAdmin_Password);
            Controls.Add(iAdmin_Email);
            Controls.Add(rAdmin_Edad);
            Controls.Add(rAdmin_Nombre);
            Name = "Form1";
            Text = "Gestion de inventario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox iAdmin_Password;
        private TextBox txtBox_Nombre;
        private TextBox txtBox_Precio;
        private TextBox txtBox_Cantidad;
        private TextBox txtBox_Categoria;
        private Label label2;
        private Button add_btn;
        private Button delete_btn;
        private TextBox txtBox_Id;
        private Button update_btn;
        private Button read_btn;
        private Button read_all_btn;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private TextBox rAdmin_Email;
        private TextBox rAdmin_Password;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label5;
        private Button adminRegister;
        private Button adminLogIn;
        private Button adminbtn_delete;
        private Button adminbtn_update;
        private Button adminbtn_read;
        private TextBox admin_id;
        private Label label6;
        private Button adminbtn_readAll;
        private TextBox rAdmin_Nombre;
        private TextBox rAdmin_Edad;
        private TextBox iAdmin_Email;
    }
}