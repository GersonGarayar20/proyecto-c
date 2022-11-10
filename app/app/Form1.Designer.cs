namespace app
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
            this.lb_n1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_n2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_r = new System.Windows.Forms.Label();
            this.rb_facil = new System.Windows.Forms.RadioButton();
            this.rb_medio = new System.Windows.Forms.RadioButton();
            this.rb_dificil = new System.Windows.Forms.RadioButton();
            this.gb_dificultad = new System.Windows.Forms.GroupBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_comprobar = new System.Windows.Forms.Button();
            this.lb_puntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n2)).BeginInit();
            this.gb_dificultad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_n1
            // 
            this.lb_n1.AutoSize = true;
            this.lb_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_n1.Location = new System.Drawing.Point(53, 274);
            this.lb_n1.Name = "lb_n1";
            this.lb_n1.Size = new System.Drawing.Size(29, 31);
            this.lb_n1.TabIndex = 0;
            this.lb_n1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // nud_n2
            // 
            this.nud_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_n2.Location = new System.Drawing.Point(139, 272);
            this.nud_n2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nud_n2.Name = "nud_n2";
            this.nud_n2.Size = new System.Drawing.Size(108, 38);
            this.nud_n2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "=";
            // 
            // lb_r
            // 
            this.lb_r.AutoSize = true;
            this.lb_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_r.Location = new System.Drawing.Point(289, 274);
            this.lb_r.Name = "lb_r";
            this.lb_r.Size = new System.Drawing.Size(29, 31);
            this.lb_r.TabIndex = 4;
            this.lb_r.Text = "0";
            // 
            // rb_facil
            // 
            this.rb_facil.AutoSize = true;
            this.rb_facil.Checked = true;
            this.rb_facil.Location = new System.Drawing.Point(19, 29);
            this.rb_facil.Name = "rb_facil";
            this.rb_facil.Size = new System.Drawing.Size(47, 17);
            this.rb_facil.TabIndex = 5;
            this.rb_facil.TabStop = true;
            this.rb_facil.Text = "Facil";
            this.rb_facil.UseVisualStyleBackColor = true;
            // 
            // rb_medio
            // 
            this.rb_medio.AutoSize = true;
            this.rb_medio.Location = new System.Drawing.Point(84, 29);
            this.rb_medio.Name = "rb_medio";
            this.rb_medio.Size = new System.Drawing.Size(54, 17);
            this.rb_medio.TabIndex = 6;
            this.rb_medio.TabStop = true;
            this.rb_medio.Text = "Medio";
            this.rb_medio.UseVisualStyleBackColor = true;
            // 
            // rb_dificil
            // 
            this.rb_dificil.AutoSize = true;
            this.rb_dificil.Location = new System.Drawing.Point(153, 29);
            this.rb_dificil.Name = "rb_dificil";
            this.rb_dificil.Size = new System.Drawing.Size(50, 17);
            this.rb_dificil.TabIndex = 7;
            this.rb_dificil.TabStop = true;
            this.rb_dificil.Text = "Dificil";
            this.rb_dificil.UseVisualStyleBackColor = true;
            // 
            // gb_dificultad
            // 
            this.gb_dificultad.Controls.Add(this.rb_dificil);
            this.gb_dificultad.Controls.Add(this.rb_medio);
            this.gb_dificultad.Controls.Add(this.rb_facil);
            this.gb_dificultad.Location = new System.Drawing.Point(31, 85);
            this.gb_dificultad.Name = "gb_dificultad";
            this.gb_dificultad.Size = new System.Drawing.Size(228, 70);
            this.gb_dificultad.TabIndex = 8;
            this.gb_dificultad.TabStop = false;
            this.gb_dificultad.Text = "Dificultad";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(277, 101);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(86, 41);
            this.btn_iniciar.TabIndex = 9;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_comprobar
            // 
            this.btn_comprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobar.Location = new System.Drawing.Point(393, 274);
            this.btn_comprobar.Name = "btn_comprobar";
            this.btn_comprobar.Size = new System.Drawing.Size(96, 36);
            this.btn_comprobar.TabIndex = 10;
            this.btn_comprobar.Text = "Comprobar";
            this.btn_comprobar.UseVisualStyleBackColor = true;
            this.btn_comprobar.Click += new System.EventHandler(this.btn_comprobar_Click);
            // 
            // lb_puntos
            // 
            this.lb_puntos.AutoSize = true;
            this.lb_puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_puntos.Location = new System.Drawing.Point(27, 198);
            this.lb_puntos.Name = "lb_puntos";
            this.lb_puntos.Size = new System.Drawing.Size(76, 20);
            this.lb_puntos.TabIndex = 11;
            this.lb_puntos.Text = "Puntos: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Juego de Ecuaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_puntos);
            this.Controls.Add(this.btn_comprobar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.gb_dificultad);
            this.Controls.Add(this.lb_r);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_n2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_n1);
            this.Name = "Form1";
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.nud_n2)).EndInit();
            this.gb_dificultad.ResumeLayout(false);
            this.gb_dificultad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_n1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_n2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_r;
        private System.Windows.Forms.RadioButton rb_facil;
        private System.Windows.Forms.RadioButton rb_medio;
        private System.Windows.Forms.RadioButton rb_dificil;
        private System.Windows.Forms.GroupBox gb_dificultad;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_comprobar;
        private System.Windows.Forms.Label lb_puntos;
        private System.Windows.Forms.Label label1;
    }
}

