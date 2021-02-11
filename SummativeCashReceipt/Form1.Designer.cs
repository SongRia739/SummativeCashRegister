namespace SummativeCashReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rasgullaLabel = new System.Windows.Forms.Label();
            this.pedalabel = new System.Windows.Forms.Label();
            this.jalebiLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rasgullaBox = new System.Windows.Forms.TextBox();
            this.pedaBox = new System.Windows.Forms.TextBox();
            this.jalebiBox = new System.Windows.Forms.TextBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.rButton = new System.Windows.Forms.Button();
            this.signButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rasgullaLabel
            // 
            this.rasgullaLabel.AutoSize = true;
            this.rasgullaLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rasgullaLabel.Location = new System.Drawing.Point(9, 55);
            this.rasgullaLabel.Name = "rasgullaLabel";
            this.rasgullaLabel.Size = new System.Drawing.Size(79, 14);
            this.rasgullaLabel.TabIndex = 0;
            this.rasgullaLabel.Text = "Rasgulla Box";
            // 
            // pedalabel
            // 
            this.pedalabel.AutoSize = true;
            this.pedalabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedalabel.Location = new System.Drawing.Point(9, 91);
            this.pedalabel.Name = "pedalabel";
            this.pedalabel.Size = new System.Drawing.Size(57, 14);
            this.pedalabel.TabIndex = 1;
            this.pedalabel.Text = "Peda Box";
            // 
            // jalebiLabel
            // 
            this.jalebiLabel.AutoSize = true;
            this.jalebiLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jalebiLabel.Location = new System.Drawing.Point(9, 130);
            this.jalebiLabel.Name = "jalebiLabel";
            this.jalebiLabel.Size = new System.Drawing.Size(64, 14);
            this.jalebiLabel.TabIndex = 2;
            this.jalebiLabel.Text = "Jalebi Box";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calculateButton.Font = new System.Drawing.Font("MisterEarl BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(51, 165);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 30);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // rasgullaBox
            // 
            this.rasgullaBox.Location = new System.Drawing.Point(138, 49);
            this.rasgullaBox.Name = "rasgullaBox";
            this.rasgullaBox.Size = new System.Drawing.Size(74, 20);
            this.rasgullaBox.TabIndex = 4;
            // 
            // pedaBox
            // 
            this.pedaBox.Location = new System.Drawing.Point(138, 85);
            this.pedaBox.Name = "pedaBox";
            this.pedaBox.Size = new System.Drawing.Size(74, 20);
            this.pedaBox.TabIndex = 5;
            // 
            // jalebiBox
            // 
            this.jalebiBox.Location = new System.Drawing.Point(138, 124);
            this.jalebiBox.Name = "jalebiBox";
            this.jalebiBox.Size = new System.Drawing.Size(74, 20);
            this.jalebiBox.TabIndex = 6;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(9, 198);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(60, 14);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(9, 229);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(27, 14);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(9, 257);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(37, 14);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(9, 296);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(62, 14);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered ";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(138, 290);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(74, 20);
            this.tenderedBox.TabIndex = 11;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeButton.Font = new System.Drawing.Font("MisterEarl BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(51, 339);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(115, 28);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Mirarae BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(9, 383);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(50, 14);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change";
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rButton.Font = new System.Drawing.Font("MisterEarl BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton.Location = new System.Drawing.Point(12, 415);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(200, 30);
            this.rButton.TabIndex = 14;
            this.rButton.Text = "Print  Receipt";
            this.rButton.UseVisualStyleBackColor = false;
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signButton.Font = new System.Drawing.Font("MisterEarl BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signButton.Image = ((System.Drawing.Image)(resources.GetObject("signButton.Image")));
            this.signButton.ImageKey = "(none)";
            this.signButton.Location = new System.Drawing.Point(-10, 0);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(604, 42);
            this.signButton.TabIndex = 16;
            this.signButton.Text = "Indian Sweets Shop";
            this.signButton.UseVisualStyleBackColor = false;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("Mirarae BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Image = ((System.Drawing.Image)(resources.GetObject("receiptLabel.Image")));
            this.receiptLabel.Location = new System.Drawing.Point(293, 48);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(285, 347);
            this.receiptLabel.TabIndex = 17;
            // 
            // neworderButton
            // 
            this.neworderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.neworderButton.Font = new System.Drawing.Font("MisterEarl BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.Location = new System.Drawing.Point(292, 415);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(286, 30);
            this.neworderButton.TabIndex = 18;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.jalebiBox);
            this.Controls.Add(this.pedaBox);
            this.Controls.Add(this.rasgullaBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.jalebiLabel);
            this.Controls.Add(this.pedalabel);
            this.Controls.Add(this.rasgullaLabel);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rasgullaLabel;
        private System.Windows.Forms.Label pedalabel;
        private System.Windows.Forms.Label jalebiLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox rasgullaBox;
        private System.Windows.Forms.TextBox pedaBox;
        private System.Windows.Forms.TextBox jalebiBox;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button neworderButton;
    }
}

