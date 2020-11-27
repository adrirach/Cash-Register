namespace Cash_Register
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drinktext = new System.Windows.Forms.TextBox();
            this.burgertext = new System.Windows.Forms.TextBox();
            this.friestext = new System.Windows.Forms.TextBox();
            this.caculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taxtotal = new System.Windows.Forms.Label();
            this.tendered = new System.Windows.Forms.Label();
            this.tenderdtext = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.subtotals = new System.Windows.Forms.Label();
            this.taxtotals = new System.Windows.Forms.Label();
            this.totaltext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changetext = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.foodbox = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(534, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 380);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Drinks ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Burgers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of fries";
            // 
            // drinktext
            // 
            this.drinktext.Location = new System.Drawing.Point(191, 50);
            this.drinktext.Name = "drinktext";
            this.drinktext.Size = new System.Drawing.Size(50, 20);
            this.drinktext.TabIndex = 4;
            // 
            // burgertext
            // 
            this.burgertext.Location = new System.Drawing.Point(200, 108);
            this.burgertext.Name = "burgertext";
            this.burgertext.Size = new System.Drawing.Size(50, 20);
            this.burgertext.TabIndex = 5;
            this.burgertext.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // friestext
            // 
            this.friestext.Location = new System.Drawing.Point(168, 77);
            this.friestext.Name = "friestext";
            this.friestext.Size = new System.Drawing.Size(50, 20);
            this.friestext.TabIndex = 6;
            // 
            // caculate
            // 
            this.caculate.BackColor = System.Drawing.Color.White;
            this.caculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.caculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caculate.Location = new System.Drawing.Point(58, 140);
            this.caculate.Name = "caculate";
            this.caculate.Size = new System.Drawing.Size(136, 23);
            this.caculate.TabIndex = 7;
            this.caculate.Text = "caculate";
            this.caculate.UseVisualStyleBackColor = false;
            this.caculate.Click += new System.EventHandler(this.Caculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sub Total";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // taxtotal
            // 
            this.taxtotal.AutoSize = true;
            this.taxtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxtotal.Location = new System.Drawing.Point(29, 239);
            this.taxtotal.Name = "taxtotal";
            this.taxtotal.Size = new System.Drawing.Size(34, 20);
            this.taxtotal.TabIndex = 10;
            this.taxtotal.Text = "Tax";
            // 
            // tendered
            // 
            this.tendered.AutoSize = true;
            this.tendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendered.Location = new System.Drawing.Point(29, 324);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(77, 20);
            this.tendered.TabIndex = 11;
            this.tendered.Text = "Tendered";
            // 
            // tenderdtext
            // 
            this.tenderdtext.Location = new System.Drawing.Point(112, 326);
            this.tenderdtext.Name = "tenderdtext";
            this.tenderdtext.Size = new System.Drawing.Size(100, 20);
            this.tenderdtext.TabIndex = 12;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(20, 391);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(69, 20);
            this.change.TabIndex = 14;
            this.change.Text = "Change ";
            this.change.Click += new System.EventHandler(this.Label8_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.White;
            this.print.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Location = new System.Drawing.Point(67, 416);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(136, 23);
            this.print.TabIndex = 15;
            this.print.Text = "Print Receipt";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.Button1_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.White;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Location = new System.Drawing.Point(67, 352);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(136, 23);
            this.calculate.TabIndex = 16;
            this.calculate.Text = " Calculate Change";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.Button2_Click);
            // 
            // subtotals
            // 
            this.subtotals.AutoSize = true;
            this.subtotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotals.Location = new System.Drawing.Point(171, 204);
            this.subtotals.Name = "subtotals";
            this.subtotals.Size = new System.Drawing.Size(0, 16);
            this.subtotals.TabIndex = 19;
            // 
            // taxtotals
            // 
            this.taxtotals.AutoSize = true;
            this.taxtotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxtotals.Location = new System.Drawing.Point(136, 244);
            this.taxtotals.Name = "taxtotals";
            this.taxtotals.Size = new System.Drawing.Size(0, 16);
            this.taxtotals.TabIndex = 20;
            // 
            // totaltext
            // 
            this.totaltext.AutoSize = true;
            this.totaltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltext.Location = new System.Drawing.Point(159, 287);
            this.totaltext.Name = "totaltext";
            this.totaltext.Size = new System.Drawing.Size(0, 16);
            this.totaltext.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(24, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 14);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // changetext
            // 
            this.changetext.AutoSize = true;
            this.changetext.Location = new System.Drawing.Point(159, 400);
            this.changetext.Name = "changetext";
            this.changetext.Size = new System.Drawing.Size(0, 13);
            this.changetext.TabIndex = 23;
            this.changetext.Click += new System.EventHandler(this.Changetext_Click);
            // 
            // bill
            // 
            this.bill.AutoSize = true;
            this.bill.BackColor = System.Drawing.Color.White;
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.Location = new System.Drawing.Point(606, 61);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(96, 16);
            this.bill.TabIndex = 24;
            this.bill.Text = "Bills Burgers";
            this.bill.Visible = false;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.BackColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(574, 103);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(88, 13);
            this.order.TabIndex = 25;
            this.order.Text = "Order Number 77";
            this.order.Visible = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(574, 128);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 13);
            this.date.TabIndex = 27;
            this.date.Text = "November 26 2020";
            this.date.Visible = false;
            this.date.Click += new System.EventHandler(this.Label8_Click_1);
            // 
            // foodbox
            // 
            this.foodbox.AutoSize = true;
            this.foodbox.BackColor = System.Drawing.Color.White;
            this.foodbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodbox.Location = new System.Drawing.Point(574, 167);
            this.foodbox.Name = "foodbox";
            this.foodbox.Size = new System.Drawing.Size(0, 16);
            this.foodbox.TabIndex = 28;
            this.foodbox.Visible = false;
            this.foodbox.Click += new System.EventHandler(this.Label6_Click);
            // 
            // numberbox
            // 
            this.numberbox.AutoSize = true;
            this.numberbox.BackColor = System.Drawing.Color.White;
            this.numberbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberbox.Location = new System.Drawing.Point(677, 167);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(0, 16);
            this.numberbox.TabIndex = 29;
            this.numberbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.foodbox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.order);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.changetext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.totaltext);
            this.Controls.Add(this.taxtotals);
            this.Controls.Add(this.subtotals);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.print);
            this.Controls.Add(this.change);
            this.Controls.Add(this.tenderdtext);
            this.Controls.Add(this.tendered);
            this.Controls.Add(this.taxtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caculate);
            this.Controls.Add(this.friestext);
            this.Controls.Add(this.burgertext);
            this.Controls.Add(this.drinktext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Bills Burgers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drinktext;
        private System.Windows.Forms.TextBox burgertext;
        private System.Windows.Forms.TextBox friestext;
        private System.Windows.Forms.Button caculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label taxtotal;
        private System.Windows.Forms.Label tendered;
        private System.Windows.Forms.TextBox tenderdtext;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label subtotals;
        private System.Windows.Forms.Label taxtotals;
        private System.Windows.Forms.Label totaltext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label changetext;
        private System.Windows.Forms.Label bill;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label foodbox;
        private System.Windows.Forms.Label numberbox;
    }
}

