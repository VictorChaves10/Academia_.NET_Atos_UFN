namespace Parking
{
    partial class Parking
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
            this.components = new System.ComponentModel.Container();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.cbxVehicleType = new System.Windows.Forms.ComboBox();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.txbNumberPlate = new System.Windows.Forms.TextBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblParkingSpace = new System.Windows.Forms.Label();
            this.cbxParkingSpace = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVehicleType.Location = new System.Drawing.Point(39, 86);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(117, 28);
            this.lblVehicleType.TabIndex = 0;
            this.lblVehicleType.Text = "Vehicle type";
            // 
            // cbxVehicleType
            // 
            this.cbxVehicleType.FormattingEnabled = true;
            this.cbxVehicleType.Items.AddRange(new object[] {
            "Car",
            "Motorcycle",
            "Truck"});
            this.cbxVehicleType.Location = new System.Drawing.Point(208, 86);
            this.cbxVehicleType.Name = "cbxVehicleType";
            this.cbxVehicleType.Size = new System.Drawing.Size(159, 28);
            this.cbxVehicleType.TabIndex = 1;
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberPlate.Location = new System.Drawing.Point(39, 138);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(132, 28);
            this.lblNumberPlate.TabIndex = 2;
            this.lblNumberPlate.Text = "Number Plate";
            // 
            // txbNumberPlate
            // 
            this.txbNumberPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNumberPlate.Location = new System.Drawing.Point(208, 138);
            this.txbNumberPlate.MaxLength = 7;
            this.txbNumberPlate.Name = "txbNumberPlate";
            this.txbNumberPlate.Size = new System.Drawing.Size(159, 27);
            this.txbNumberPlate.TabIndex = 3;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(39, 262);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(117, 33);
            this.btnAddVehicle.TabIndex = 4;
            this.btnAddVehicle.Text = "Adicionar";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // lblParkingSpace
            // 
            this.lblParkingSpace.AutoSize = true;
            this.lblParkingSpace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParkingSpace.Location = new System.Drawing.Point(39, 187);
            this.lblParkingSpace.Name = "lblParkingSpace";
            this.lblParkingSpace.Size = new System.Drawing.Size(163, 28);
            this.lblParkingSpace.TabIndex = 5;
            this.lblParkingSpace.Text = "Parking space no.";
            // 
            // cbxParkingSpace
            // 
            this.cbxParkingSpace.FormattingEnabled = true;
            this.cbxParkingSpace.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxParkingSpace.Location = new System.Drawing.Point(208, 187);
            this.cbxParkingSpace.Name = "cbxParkingSpace";
            this.cbxParkingSpace.Size = new System.Drawing.Size(105, 28);
            this.cbxParkingSpace.TabIndex = 6;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 496);
            this.Controls.Add(this.cbxParkingSpace);
            this.Controls.Add(this.lblParkingSpace);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.txbNumberPlate);
            this.Controls.Add(this.lblNumberPlate);
            this.Controls.Add(this.cbxVehicleType);
            this.Controls.Add(this.lblVehicleType);
            this.Name = "Parking";
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVehicleType;
        private ComboBox cbxVehicleType;
        private Label lblNumberPlate;
        private TextBox txbNumberPlate;
        private Button btnAddVehicle;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Label lblParkingSpace;
        private ComboBox cbxParkingSpace;
    }
}