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
            label1 = new Label();
            clientName = new TextBox();
            clientEdad = new TextBox();
            clientEmail = new TextBox();
            clientPassword = new TextBox();
            productoName = new TextBox();
            productoPrecio = new TextBox();
            productoCant = new TextBox();
            productoCategoria = new TextBox();
            label2 = new Label();
            addPedidos = new Button();
            getPedidos = new Button();
            button1 = new Button();
            DatosPedidos = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos cliente:";
            // 
            // clientName
            // 
            clientName.Location = new Point(116, 13);
            clientName.Name = "clientName";
            clientName.Size = new Size(131, 23);
            clientName.TabIndex = 1;
            clientName.Text = "Nombre";
            // 
            // clientEdad
            // 
            clientEdad.Location = new Point(116, 42);
            clientEdad.Name = "clientEdad";
            clientEdad.Size = new Size(131, 23);
            clientEdad.TabIndex = 2;
            clientEdad.Text = "Edad";
            // 
            // clientEmail
            // 
            clientEmail.Location = new Point(116, 71);
            clientEmail.Name = "clientEmail";
            clientEmail.Size = new Size(131, 23);
            clientEmail.TabIndex = 3;
            clientEmail.Text = "Email";
            // 
            // clientPassword
            // 
            clientPassword.Location = new Point(116, 100);
            clientPassword.Name = "clientPassword";
            clientPassword.Size = new Size(131, 23);
            clientPassword.TabIndex = 4;
            clientPassword.Text = "Password";
            // 
            // productoName
            // 
            productoName.Location = new Point(116, 164);
            productoName.Name = "productoName";
            productoName.Size = new Size(131, 23);
            productoName.TabIndex = 5;
            productoName.Text = "Nombre";
            // 
            // productoPrecio
            // 
            productoPrecio.Location = new Point(116, 193);
            productoPrecio.Name = "productoPrecio";
            productoPrecio.Size = new Size(131, 23);
            productoPrecio.TabIndex = 6;
            productoPrecio.Text = "Precio";
            // 
            // productoCant
            // 
            productoCant.Location = new Point(116, 222);
            productoCant.Name = "productoCant";
            productoCant.Size = new Size(131, 23);
            productoCant.TabIndex = 7;
            productoCant.Text = "Cantidad";
            // 
            // productoCategoria
            // 
            productoCategoria.Location = new Point(116, 251);
            productoCategoria.Name = "productoCategoria";
            productoCategoria.Size = new Size(131, 23);
            productoCategoria.TabIndex = 8;
            productoCategoria.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 164);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 9;
            label2.Text = "Datos producto:";
            // 
            // addPedidos
            // 
            addPedidos.Location = new Point(137, 305);
            addPedidos.Name = "addPedidos";
            addPedidos.Size = new Size(110, 32);
            addPedidos.TabIndex = 10;
            addPedidos.Text = "Generar pedido";
            addPedidos.UseVisualStyleBackColor = true;
            addPedidos.Click += addPedidos_Click;
            // 
            // getPedidos
            // 
            getPedidos.Location = new Point(341, 22);
            getPedidos.Name = "getPedidos";
            getPedidos.Size = new Size(110, 32);
            getPedidos.TabIndex = 13;
            getPedidos.Text = "Mostrar pedidos";
            getPedidos.UseVisualStyleBackColor = true;
            getPedidos.Click += getPedidos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 305);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 14;
            button1.Text = "Generar cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // DatosPedidos
            // 
            DatosPedidos.AutoSize = true;
            DatosPedidos.BorderStyle = BorderStyle.FixedSingle;
            DatosPedidos.Location = new Point(488, 22);
            DatosPedidos.MinimumSize = new Size(300, 400);
            DatosPedidos.Name = "DatosPedidos";
            DatosPedidos.Size = new Size(300, 400);
            DatosPedidos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 841);
            Controls.Add(button1);
            Controls.Add(getPedidos);
            Controls.Add(DatosPedidos);
            Controls.Add(addPedidos);
            Controls.Add(label2);
            Controls.Add(productoCategoria);
            Controls.Add(productoCant);
            Controls.Add(productoPrecio);
            Controls.Add(productoName);
            Controls.Add(clientPassword);
            Controls.Add(clientEmail);
            Controls.Add(clientEdad);
            Controls.Add(clientName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox clientName;
        private TextBox clientEdad;
        private TextBox clientEmail;
        private TextBox clientPassword;
        private TextBox productoName;
        private TextBox productoPrecio;
        private TextBox productoCant;
        private TextBox productoCategoria;
        private Label label2;
        private Button addPedidos;
        private Button getPedidos;
        private Button button1;
        private Label DatosPedidos;
    }
}