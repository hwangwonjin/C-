namespace Calculation
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonDat = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonMinuse = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonMultiy = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("굴림", 30F);
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(449, 56);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonPlus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDat, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMinuse, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMultiy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivision, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSeven, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 437);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonPlus.Location = new System.Drawing.Point(342, 330);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(107, 103);
            this.ButtonPlus.TabIndex = 15;
            this.ButtonPlus.Text = "＋";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonDat
            // 
            this.ButtonDat.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonDat.Location = new System.Drawing.Point(229, 330);
            this.ButtonDat.Name = "ButtonDat";
            this.ButtonDat.Size = new System.Drawing.Size(107, 103);
            this.ButtonDat.TabIndex = 14;
            this.ButtonDat.Text = ".";
            this.ButtonDat.UseVisualStyleBackColor = true;
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonZero.Location = new System.Drawing.Point(116, 330);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(107, 103);
            this.ButtonZero.TabIndex = 13;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonClear.Location = new System.Drawing.Point(3, 330);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(107, 103);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "AC";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonMinuse
            // 
            this.ButtonMinuse.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonMinuse.Location = new System.Drawing.Point(342, 221);
            this.ButtonMinuse.Name = "ButtonMinuse";
            this.ButtonMinuse.Size = new System.Drawing.Size(107, 103);
            this.ButtonMinuse.TabIndex = 11;
            this.ButtonMinuse.Text = "－";
            this.ButtonMinuse.UseVisualStyleBackColor = true;
            this.ButtonMinuse.Click += new System.EventHandler(this.ButtonMinuse_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonThree.Location = new System.Drawing.Point(229, 221);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(107, 103);
            this.ButtonThree.TabIndex = 10;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonTwo.Location = new System.Drawing.Point(116, 221);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(107, 103);
            this.ButtonTwo.TabIndex = 9;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonOne.Location = new System.Drawing.Point(3, 221);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(107, 103);
            this.ButtonOne.TabIndex = 8;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonMultiy
            // 
            this.ButtonMultiy.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonMultiy.Location = new System.Drawing.Point(342, 112);
            this.ButtonMultiy.Name = "ButtonMultiy";
            this.ButtonMultiy.Size = new System.Drawing.Size(107, 103);
            this.ButtonMultiy.TabIndex = 7;
            this.ButtonMultiy.Text = "×";
            this.ButtonMultiy.UseVisualStyleBackColor = true;
            this.ButtonMultiy.Click += new System.EventHandler(this.ButtonMultiy_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonSix.Location = new System.Drawing.Point(229, 112);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(107, 103);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonFive.Location = new System.Drawing.Point(116, 112);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(107, 103);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonFour.Location = new System.Drawing.Point(3, 112);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(107, 103);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonDivision.Location = new System.Drawing.Point(342, 3);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(107, 103);
            this.ButtonDivision.TabIndex = 3;
            this.ButtonDivision.Text = "÷";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            this.ButtonDivision.Click += new System.EventHandler(this.ButtonDivision_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonNine.Location = new System.Drawing.Point(229, 3);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(107, 103);
            this.ButtonNine.TabIndex = 2;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonEight.Location = new System.Drawing.Point(116, 3);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(107, 103);
            this.ButtonEight.TabIndex = 1;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("굴림", 20F);
            this.ButtonSeven.Location = new System.Drawing.Point(3, 3);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(107, 103);
            this.ButtonSeven.TabIndex = 0;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Font = new System.Drawing.Font("굴림", 25F);
            this.ButtonResult.Location = new System.Drawing.Point(-6, 525);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(455, 74);
            this.ButtonResult.TabIndex = 2;
            this.ButtonResult.Text = "＝";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonAnser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 600);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonDat;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonMinuse;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonMultiy;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonResult;
    }
}

