namespace DemoWebService
{
    partial class FrmPronosticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPronosticos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSolPone = new System.Windows.Forms.Label();
            this.lblSolSale = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLunaPone = new System.Windows.Forms.Label();
            this.lblLunaSale = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFaseLunar = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMañanaR = new System.Windows.Forms.Panel();
            this.lblComentarioM = new System.Windows.Forms.TextBox();
            this.lblTituloM = new System.Windows.Forms.Label();
            this.pbxImagenM = new System.Windows.Forms.PictureBox();
            this.pnlTardeR = new System.Windows.Forms.Panel();
            this.lblComentarioT = new System.Windows.Forms.TextBox();
            this.lblTituloT = new System.Windows.Forms.Label();
            this.pbxImagenT = new System.Windows.Forms.PictureBox();
            this.pnlNocheR = new System.Windows.Forms.Panel();
            this.lblComentarioN = new System.Windows.Forms.TextBox();
            this.lblTituloN = new System.Windows.Forms.Label();
            this.pbxImagenN = new System.Windows.Forms.PictureBox();
            this.boxRegiones = new System.Windows.Forms.ComboBox();
            this.PronosticoRegionalRegion = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMañanaC = new System.Windows.Forms.Panel();
            this.lblCCM = new System.Windows.Forms.TextBox();
            this.lblCTM = new System.Windows.Forms.Label();
            this.pbxCM = new System.Windows.Forms.PictureBox();
            this.pnlTardeC = new System.Windows.Forms.Panel();
            this.lblCCT = new System.Windows.Forms.TextBox();
            this.lblCTT = new System.Windows.Forms.Label();
            this.pbxCT = new System.Windows.Forms.PictureBox();
            this.pnlNocheC = new System.Windows.Forms.Panel();
            this.lblCCN = new System.Windows.Forms.TextBox();
            this.lblCTN = new System.Windows.Forms.Label();
            this.pbxCN = new System.Windows.Forms.PictureBox();
            this.boxCiudad = new System.Windows.Forms.ComboBox();
            this.PronosticoRegionalRegionCiudad = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.boxEfeSol = new System.Windows.Forms.CheckBox();
            this.boxEfeLuna = new System.Windows.Forms.CheckBox();
            this.boxFaseLunar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlMañanaR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenM)).BeginInit();
            this.pnlTardeR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenT)).BeginInit();
            this.pnlNocheR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PronosticoRegionalRegion)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlMañanaC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCM)).BeginInit();
            this.pnlTardeC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCT)).BeginInit();
            this.pnlNocheC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PronosticoRegionalRegionCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSolPone);
            this.groupBox1.Controls.Add(this.lblSolSale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(622, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(148, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sol:";
            // 
            // lblSolPone
            // 
            this.lblSolPone.AutoSize = true;
            this.lblSolPone.Location = new System.Drawing.Point(6, 64);
            this.lblSolPone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolPone.Name = "lblSolPone";
            this.lblSolPone.Size = new System.Drawing.Size(50, 20);
            this.lblSolPone.TabIndex = 1;
            this.lblSolPone.Text = "Pone:";
            // 
            // lblSolSale
            // 
            this.lblSolSale.AutoSize = true;
            this.lblSolSale.Location = new System.Drawing.Point(8, 31);
            this.lblSolSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolSale.Name = "lblSolSale";
            this.lblSolSale.Size = new System.Drawing.Size(45, 20);
            this.lblSolSale.TabIndex = 0;
            this.lblSolSale.Text = "Sale:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLunaPone);
            this.groupBox2.Controls.Add(this.lblLunaSale);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(622, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(148, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luna:";
            // 
            // lblLunaPone
            // 
            this.lblLunaPone.AutoSize = true;
            this.lblLunaPone.Location = new System.Drawing.Point(6, 64);
            this.lblLunaPone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunaPone.Name = "lblLunaPone";
            this.lblLunaPone.Size = new System.Drawing.Size(50, 20);
            this.lblLunaPone.TabIndex = 1;
            this.lblLunaPone.Text = "Pone:";
            // 
            // lblLunaSale
            // 
            this.lblLunaSale.AutoSize = true;
            this.lblLunaSale.Location = new System.Drawing.Point(8, 31);
            this.lblLunaSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunaSale.Name = "lblLunaSale";
            this.lblLunaSale.Size = new System.Drawing.Size(49, 20);
            this.lblLunaSale.TabIndex = 0;
            this.lblLunaSale.Text = "Sale: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFaseLunar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(622, 266);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(148, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fase Lunar";
            // 
            // lblFaseLunar
            // 
            this.lblFaseLunar.AutoSize = true;
            this.lblFaseLunar.Location = new System.Drawing.Point(9, 31);
            this.lblFaseLunar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaseLunar.Name = "lblFaseLunar";
            this.lblFaseLunar.Size = new System.Drawing.Size(45, 20);
            this.lblFaseLunar.TabIndex = 1;
            this.lblFaseLunar.Text = "Fase";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Controls.Add(this.boxRegiones);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 35);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(291, 322);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Regional";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlMañanaR);
            this.flowLayoutPanel1.Controls.Add(this.pnlTardeR);
            this.flowLayoutPanel1.Controls.Add(this.pnlNocheR);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 64);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 241);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlMañanaR
            // 
            this.pnlMañanaR.Controls.Add(this.lblComentarioM);
            this.pnlMañanaR.Controls.Add(this.lblTituloM);
            this.pnlMañanaR.Controls.Add(this.pbxImagenM);
            this.pnlMañanaR.Location = new System.Drawing.Point(2, 2);
            this.pnlMañanaR.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMañanaR.Name = "pnlMañanaR";
            this.pnlMañanaR.Size = new System.Drawing.Size(261, 77);
            this.pnlMañanaR.TabIndex = 0;
            // 
            // lblComentarioM
            // 
            this.lblComentarioM.BackColor = System.Drawing.SystemColors.Control;
            this.lblComentarioM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblComentarioM.Enabled = false;
            this.lblComentarioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioM.Location = new System.Drawing.Point(76, 32);
            this.lblComentarioM.Margin = new System.Windows.Forms.Padding(2);
            this.lblComentarioM.Multiline = true;
            this.lblComentarioM.Name = "lblComentarioM";
            this.lblComentarioM.ReadOnly = true;
            this.lblComentarioM.Size = new System.Drawing.Size(178, 38);
            this.lblComentarioM.TabIndex = 2;
            this.lblComentarioM.Text = "Comentarios";
            // 
            // lblTituloM
            // 
            this.lblTituloM.AutoSize = true;
            this.lblTituloM.Location = new System.Drawing.Point(71, 11);
            this.lblTituloM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloM.Name = "lblTituloM";
            this.lblTituloM.Size = new System.Drawing.Size(60, 20);
            this.lblTituloM.TabIndex = 1;
            this.lblTituloM.Text = "Estado";
            // 
            // pbxImagenM
            // 
            this.pbxImagenM.Location = new System.Drawing.Point(2, 3);
            this.pbxImagenM.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImagenM.Name = "pbxImagenM";
            this.pbxImagenM.Size = new System.Drawing.Size(66, 69);
            this.pbxImagenM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenM.TabIndex = 0;
            this.pbxImagenM.TabStop = false;
            // 
            // pnlTardeR
            // 
            this.pnlTardeR.Controls.Add(this.lblComentarioT);
            this.pnlTardeR.Controls.Add(this.lblTituloT);
            this.pnlTardeR.Controls.Add(this.pbxImagenT);
            this.pnlTardeR.Location = new System.Drawing.Point(2, 83);
            this.pnlTardeR.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTardeR.Name = "pnlTardeR";
            this.pnlTardeR.Size = new System.Drawing.Size(261, 77);
            this.pnlTardeR.TabIndex = 1;
            // 
            // lblComentarioT
            // 
            this.lblComentarioT.BackColor = System.Drawing.SystemColors.Control;
            this.lblComentarioT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblComentarioT.Enabled = false;
            this.lblComentarioT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioT.Location = new System.Drawing.Point(76, 34);
            this.lblComentarioT.Margin = new System.Windows.Forms.Padding(2);
            this.lblComentarioT.Multiline = true;
            this.lblComentarioT.Name = "lblComentarioT";
            this.lblComentarioT.ReadOnly = true;
            this.lblComentarioT.Size = new System.Drawing.Size(178, 38);
            this.lblComentarioT.TabIndex = 2;
            this.lblComentarioT.Text = "Comentarios";
            // 
            // lblTituloT
            // 
            this.lblTituloT.AutoSize = true;
            this.lblTituloT.Location = new System.Drawing.Point(74, 8);
            this.lblTituloT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloT.Name = "lblTituloT";
            this.lblTituloT.Size = new System.Drawing.Size(60, 20);
            this.lblTituloT.TabIndex = 1;
            this.lblTituloT.Text = "Estado";
            // 
            // pbxImagenT
            // 
            this.pbxImagenT.Location = new System.Drawing.Point(2, 4);
            this.pbxImagenT.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImagenT.Name = "pbxImagenT";
            this.pbxImagenT.Size = new System.Drawing.Size(66, 69);
            this.pbxImagenT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenT.TabIndex = 0;
            this.pbxImagenT.TabStop = false;
            // 
            // pnlNocheR
            // 
            this.pnlNocheR.Controls.Add(this.lblComentarioN);
            this.pnlNocheR.Controls.Add(this.lblTituloN);
            this.pnlNocheR.Controls.Add(this.pbxImagenN);
            this.pnlNocheR.Location = new System.Drawing.Point(2, 164);
            this.pnlNocheR.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNocheR.Name = "pnlNocheR";
            this.pnlNocheR.Size = new System.Drawing.Size(261, 77);
            this.pnlNocheR.TabIndex = 2;
            // 
            // lblComentarioN
            // 
            this.lblComentarioN.BackColor = System.Drawing.SystemColors.Control;
            this.lblComentarioN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblComentarioN.Enabled = false;
            this.lblComentarioN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioN.Location = new System.Drawing.Point(78, 32);
            this.lblComentarioN.Margin = new System.Windows.Forms.Padding(2);
            this.lblComentarioN.Multiline = true;
            this.lblComentarioN.Name = "lblComentarioN";
            this.lblComentarioN.ReadOnly = true;
            this.lblComentarioN.Size = new System.Drawing.Size(174, 38);
            this.lblComentarioN.TabIndex = 2;
            this.lblComentarioN.Text = "Comentarios";
            // 
            // lblTituloN
            // 
            this.lblTituloN.AutoSize = true;
            this.lblTituloN.Location = new System.Drawing.Point(74, 8);
            this.lblTituloN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloN.Name = "lblTituloN";
            this.lblTituloN.Size = new System.Drawing.Size(60, 20);
            this.lblTituloN.TabIndex = 1;
            this.lblTituloN.Text = "Estado";
            // 
            // pbxImagenN
            // 
            this.pbxImagenN.Location = new System.Drawing.Point(2, 2);
            this.pbxImagenN.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImagenN.Name = "pbxImagenN";
            this.pbxImagenN.Size = new System.Drawing.Size(66, 69);
            this.pbxImagenN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenN.TabIndex = 0;
            this.pbxImagenN.TabStop = false;
            // 
            // boxRegiones
            // 
            this.boxRegiones.DataSource = this.PronosticoRegionalRegion;
            this.boxRegiones.DisplayMember = "nombre";
            this.boxRegiones.FormattingEnabled = true;
            this.boxRegiones.Location = new System.Drawing.Point(16, 30);
            this.boxRegiones.Margin = new System.Windows.Forms.Padding(2);
            this.boxRegiones.Name = "boxRegiones";
            this.boxRegiones.Size = new System.Drawing.Size(264, 28);
            this.boxRegiones.TabIndex = 0;
            this.boxRegiones.ValueMember = "idRegion";
            this.boxRegiones.SelectedIndexChanged += new System.EventHandler(this.SeleccionRegion);
            // 
            // PronosticoRegionalRegion
            // 
            this.PronosticoRegionalRegion.DataSource = typeof(DemoWebService.PRONOSTICO_REGIONALREGION);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel2);
            this.groupBox5.Controls.Add(this.boxCiudad);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(312, 35);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(291, 322);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ciudad";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pnlMañanaC);
            this.flowLayoutPanel2.Controls.Add(this.pnlTardeC);
            this.flowLayoutPanel2.Controls.Add(this.pnlNocheC);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 64);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(262, 241);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pnlMañanaC
            // 
            this.pnlMañanaC.Controls.Add(this.lblCCM);
            this.pnlMañanaC.Controls.Add(this.lblCTM);
            this.pnlMañanaC.Controls.Add(this.pbxCM);
            this.pnlMañanaC.Location = new System.Drawing.Point(2, 2);
            this.pnlMañanaC.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMañanaC.Name = "pnlMañanaC";
            this.pnlMañanaC.Size = new System.Drawing.Size(261, 77);
            this.pnlMañanaC.TabIndex = 0;
            // 
            // lblCCM
            // 
            this.lblCCM.BackColor = System.Drawing.SystemColors.Control;
            this.lblCCM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCCM.Enabled = false;
            this.lblCCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCM.Location = new System.Drawing.Point(76, 32);
            this.lblCCM.Margin = new System.Windows.Forms.Padding(2);
            this.lblCCM.Multiline = true;
            this.lblCCM.Name = "lblCCM";
            this.lblCCM.ReadOnly = true;
            this.lblCCM.Size = new System.Drawing.Size(178, 38);
            this.lblCCM.TabIndex = 2;
            this.lblCCM.Text = "Comentarios";
            // 
            // lblCTM
            // 
            this.lblCTM.AutoSize = true;
            this.lblCTM.Location = new System.Drawing.Point(71, 11);
            this.lblCTM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTM.Name = "lblCTM";
            this.lblCTM.Size = new System.Drawing.Size(60, 20);
            this.lblCTM.TabIndex = 1;
            this.lblCTM.Text = "Estado";
            // 
            // pbxCM
            // 
            this.pbxCM.Location = new System.Drawing.Point(2, 3);
            this.pbxCM.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCM.Name = "pbxCM";
            this.pbxCM.Size = new System.Drawing.Size(66, 69);
            this.pbxCM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCM.TabIndex = 0;
            this.pbxCM.TabStop = false;
            // 
            // pnlTardeC
            // 
            this.pnlTardeC.Controls.Add(this.lblCCT);
            this.pnlTardeC.Controls.Add(this.lblCTT);
            this.pnlTardeC.Controls.Add(this.pbxCT);
            this.pnlTardeC.Location = new System.Drawing.Point(2, 83);
            this.pnlTardeC.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTardeC.Name = "pnlTardeC";
            this.pnlTardeC.Size = new System.Drawing.Size(261, 77);
            this.pnlTardeC.TabIndex = 1;
            // 
            // lblCCT
            // 
            this.lblCCT.BackColor = System.Drawing.SystemColors.Control;
            this.lblCCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCCT.Enabled = false;
            this.lblCCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCT.Location = new System.Drawing.Point(76, 34);
            this.lblCCT.Margin = new System.Windows.Forms.Padding(2);
            this.lblCCT.Multiline = true;
            this.lblCCT.Name = "lblCCT";
            this.lblCCT.ReadOnly = true;
            this.lblCCT.Size = new System.Drawing.Size(178, 38);
            this.lblCCT.TabIndex = 2;
            this.lblCCT.Text = "Comentarios";
            // 
            // lblCTT
            // 
            this.lblCTT.AutoSize = true;
            this.lblCTT.Location = new System.Drawing.Point(74, 8);
            this.lblCTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTT.Name = "lblCTT";
            this.lblCTT.Size = new System.Drawing.Size(60, 20);
            this.lblCTT.TabIndex = 1;
            this.lblCTT.Text = "Estado";
            // 
            // pbxCT
            // 
            this.pbxCT.Location = new System.Drawing.Point(2, 4);
            this.pbxCT.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCT.Name = "pbxCT";
            this.pbxCT.Size = new System.Drawing.Size(66, 69);
            this.pbxCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCT.TabIndex = 0;
            this.pbxCT.TabStop = false;
            // 
            // pnlNocheC
            // 
            this.pnlNocheC.Controls.Add(this.lblCCN);
            this.pnlNocheC.Controls.Add(this.lblCTN);
            this.pnlNocheC.Controls.Add(this.pbxCN);
            this.pnlNocheC.Location = new System.Drawing.Point(2, 164);
            this.pnlNocheC.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNocheC.Name = "pnlNocheC";
            this.pnlNocheC.Size = new System.Drawing.Size(261, 77);
            this.pnlNocheC.TabIndex = 2;
            // 
            // lblCCN
            // 
            this.lblCCN.BackColor = System.Drawing.SystemColors.Control;
            this.lblCCN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCCN.Enabled = false;
            this.lblCCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCN.Location = new System.Drawing.Point(78, 32);
            this.lblCCN.Margin = new System.Windows.Forms.Padding(2);
            this.lblCCN.Multiline = true;
            this.lblCCN.Name = "lblCCN";
            this.lblCCN.ReadOnly = true;
            this.lblCCN.Size = new System.Drawing.Size(174, 38);
            this.lblCCN.TabIndex = 2;
            this.lblCCN.Text = "Comentarios";
            // 
            // lblCTN
            // 
            this.lblCTN.AutoSize = true;
            this.lblCTN.Location = new System.Drawing.Point(74, 8);
            this.lblCTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTN.Name = "lblCTN";
            this.lblCTN.Size = new System.Drawing.Size(60, 20);
            this.lblCTN.TabIndex = 1;
            this.lblCTN.Text = "Estado";
            // 
            // pbxCN
            // 
            this.pbxCN.Location = new System.Drawing.Point(2, 2);
            this.pbxCN.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCN.Name = "pbxCN";
            this.pbxCN.Size = new System.Drawing.Size(66, 69);
            this.pbxCN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCN.TabIndex = 0;
            this.pbxCN.TabStop = false;
            // 
            // boxCiudad
            // 
            this.boxCiudad.DataSource = this.PronosticoRegionalRegionCiudad;
            this.boxCiudad.DisplayMember = "nombre";
            this.boxCiudad.FormattingEnabled = true;
            this.boxCiudad.Location = new System.Drawing.Point(12, 30);
            this.boxCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.boxCiudad.Name = "boxCiudad";
            this.boxCiudad.Size = new System.Drawing.Size(264, 28);
            this.boxCiudad.TabIndex = 1;
            this.boxCiudad.ValueMember = "id";
            this.boxCiudad.SelectedIndexChanged += new System.EventHandler(this.SeleccionCiudad);
            // 
            // PronosticoRegionalRegionCiudad
            // 
            this.PronosticoRegionalRegionCiudad.DataSource = typeof(DemoWebService.PRONOSTICO_REGIONALREGIONCIUDAD);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(261, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // boxEfeSol
            // 
            this.boxEfeSol.AutoSize = true;
            this.boxEfeSol.Location = new System.Drawing.Point(12, 12);
            this.boxEfeSol.Name = "boxEfeSol";
            this.boxEfeSol.Size = new System.Drawing.Size(116, 17);
            this.boxEfeSol.TabIndex = 5;
            this.boxEfeSol.Text = "Ver Efemeridad Sol";
            this.boxEfeSol.UseVisualStyleBackColor = true;
            this.boxEfeSol.CheckedChanged += new System.EventHandler(this.boxEfeSol_CheckedChanged);
            // 
            // boxEfeLuna
            // 
            this.boxEfeLuna.AutoSize = true;
            this.boxEfeLuna.Location = new System.Drawing.Point(246, 12);
            this.boxEfeLuna.Name = "boxEfeLuna";
            this.boxEfeLuna.Size = new System.Drawing.Size(125, 17);
            this.boxEfeLuna.TabIndex = 6;
            this.boxEfeLuna.Text = "Ver Efemeridad Luna";
            this.boxEfeLuna.UseVisualStyleBackColor = true;
            this.boxEfeLuna.CheckedChanged += new System.EventHandler(this.boxEfeLuna_CheckedChanged);
            // 
            // boxFaseLunar
            // 
            this.boxFaseLunar.AutoSize = true;
            this.boxFaseLunar.Location = new System.Drawing.Point(505, 12);
            this.boxFaseLunar.Name = "boxFaseLunar";
            this.boxFaseLunar.Size = new System.Drawing.Size(98, 17);
            this.boxFaseLunar.TabIndex = 7;
            this.boxFaseLunar.Text = "Ver Fase Lunar";
            this.boxFaseLunar.UseVisualStyleBackColor = true;
            this.boxFaseLunar.CheckedChanged += new System.EventHandler(this.boxFaseLunar_CheckedChanged);
            // 
            // FrmPronosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(613, 400);
            this.Controls.Add(this.boxFaseLunar);
            this.Controls.Add(this.boxEfeLuna);
            this.Controls.Add(this.boxEfeSol);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPronosticos";
            this.Text = "Pronósticos";
            this.Load += new System.EventHandler(this.FrmPronostico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlMañanaR.ResumeLayout(false);
            this.pnlMañanaR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenM)).EndInit();
            this.pnlTardeR.ResumeLayout(false);
            this.pnlTardeR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenT)).EndInit();
            this.pnlNocheR.ResumeLayout(false);
            this.pnlNocheR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PronosticoRegionalRegion)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlMañanaC.ResumeLayout(false);
            this.pnlMañanaC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCM)).EndInit();
            this.pnlTardeC.ResumeLayout(false);
            this.pnlTardeC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCT)).EndInit();
            this.pnlNocheC.ResumeLayout(false);
            this.pnlNocheC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PronosticoRegionalRegionCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSolPone;
        private System.Windows.Forms.Label lblSolSale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLunaPone;
        private System.Windows.Forms.Label lblLunaSale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFaseLunar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox boxRegiones;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.BindingSource PronosticoRegionalRegion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlMañanaR;
        private System.Windows.Forms.TextBox lblComentarioM;
        private System.Windows.Forms.Label lblTituloM;
        private System.Windows.Forms.PictureBox pbxImagenM;
        private System.Windows.Forms.Panel pnlTardeR;
        private System.Windows.Forms.TextBox lblComentarioT;
        private System.Windows.Forms.Label lblTituloT;
        private System.Windows.Forms.PictureBox pbxImagenT;
        private System.Windows.Forms.Panel pnlNocheR;
        private System.Windows.Forms.TextBox lblComentarioN;
        private System.Windows.Forms.Label lblTituloN;
        private System.Windows.Forms.PictureBox pbxImagenN;
        private System.Windows.Forms.ComboBox boxCiudad;
        private System.Windows.Forms.BindingSource PronosticoRegionalRegionCiudad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pnlMañanaC;
        private System.Windows.Forms.TextBox lblCCM;
        private System.Windows.Forms.Label lblCTM;
        private System.Windows.Forms.PictureBox pbxCM;
        private System.Windows.Forms.Panel pnlTardeC;
        private System.Windows.Forms.TextBox lblCCT;
        private System.Windows.Forms.Label lblCTT;
        private System.Windows.Forms.PictureBox pbxCT;
        private System.Windows.Forms.Panel pnlNocheC;
        private System.Windows.Forms.TextBox lblCCN;
        private System.Windows.Forms.Label lblCTN;
        private System.Windows.Forms.PictureBox pbxCN;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox boxEfeSol;
        private System.Windows.Forms.CheckBox boxEfeLuna;
        private System.Windows.Forms.CheckBox boxFaseLunar;
    }
}