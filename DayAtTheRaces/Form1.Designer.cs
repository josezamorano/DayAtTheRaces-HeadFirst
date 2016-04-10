namespace DayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStartRace = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDistanceDescription = new System.Windows.Forms.Label();
            this.labelTimeDesc = new System.Windows.Forms.Label();
            this.buttonNewDog = new System.Windows.Forms.Button();
            this.labelTrackDistance = new System.Windows.Forms.Label();
            this.LabelWinnerDogName = new System.Windows.Forms.Label();
            this.labelWinnerDogNameDesc = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelComboBox = new System.Windows.Forms.Label();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.labelGuyPlacingBet = new System.Windows.Forms.Label();
            this.numericBet = new System.Windows.Forms.NumericUpDown();
            this.labelStaticMessage = new System.Windows.Forms.Label();
            this.buttonPlaceBet = new System.Windows.Forms.Button();
            this.labelGuySituation = new System.Windows.Forms.Label();
            this.numericUpDownDeposit = new System.Windows.Forms.NumericUpDown();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.labelAlSituation = new System.Windows.Forms.Label();
            this.labelBobSituation = new System.Windows.Forms.Label();
            this.labelJoeSituation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxBetsPlaced = new System.Windows.Forms.ListBox();
            this.pictureBoxRaceTrack = new System.Windows.Forms.PictureBox();
            this.groupBoxBasePlatform = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNumericDogPosition = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this.label1DogName = new System.Windows.Forms.Label();
            this.label4DogName = new System.Windows.Forms.Label();
            this.label3DogName = new System.Windows.Forms.Label();
            this.label2DogName = new System.Windows.Forms.Label();
            this.pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaceTrack)).BeginInit();
            this.groupBoxBasePlatform.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).BeginInit();
            this.SuspendLayout();
            //           
            // buttonStartRace
            // 
            this.buttonStartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartRace.Location = new System.Drawing.Point(269, 73);
            this.buttonStartRace.Name = "buttonStartRace";
            this.buttonStartRace.Size = new System.Drawing.Size(129, 35);
            this.buttonStartRace.TabIndex = 0;
            this.buttonStartRace.Text = "Start Race!";
            this.buttonStartRace.UseVisualStyleBackColor = true;
            this.buttonStartRace.Click += new System.EventHandler(this.buttonStartRace_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(24, 49);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(102, 13);
            this.labelDistance.TabIndex = 1;
            this.labelDistance.Text = "Total Distance Mts.:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(24, 65);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(107, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Total Time Min-Secs:";
            // 
            // labelDistanceDescription
            // 
            this.labelDistanceDescription.AutoSize = true;
            this.labelDistanceDescription.Location = new System.Drawing.Point(141, 49);
            this.labelDistanceDescription.Name = "labelDistanceDescription";
            this.labelDistanceDescription.Size = new System.Drawing.Size(105, 13);
            this.labelDistanceDescription.TabIndex = 3;
            this.labelDistanceDescription.Text = "Distance Description";
            // 
            // labelTimeDesc
            // 
            this.labelTimeDesc.AutoSize = true;
            this.labelTimeDesc.Location = new System.Drawing.Point(141, 65);
            this.labelTimeDesc.Name = "labelTimeDesc";
            this.labelTimeDesc.Size = new System.Drawing.Size(59, 13);
            this.labelTimeDesc.TabIndex = 4;
            this.labelTimeDesc.Text = "Race Time";
            // 
            // buttonNewDog
            // 
            this.buttonNewDog.Location = new System.Drawing.Point(27, 85);
            this.buttonNewDog.Name = "buttonNewDog";
            this.buttonNewDog.Size = new System.Drawing.Size(92, 23);
            this.buttonNewDog.TabIndex = 5;
            this.buttonNewDog.Text = "Add New Dog";
            this.buttonNewDog.UseVisualStyleBackColor = true;
            this.buttonNewDog.Click += new System.EventHandler(this.buttonNewDog_Click);
            // 
            // labelTrackDistance
            // 
            this.labelTrackDistance.AutoSize = true;
            this.labelTrackDistance.Location = new System.Drawing.Point(3, 87);
            this.labelTrackDistance.Name = "labelTrackDistance";
            this.labelTrackDistance.Size = new System.Drawing.Size(99, 13);
            this.labelTrackDistance.TabIndex = 7;
            this.labelTrackDistance.Text = "Set Track Distance";
            // 
            // LabelWinnerDogName
            // 
            this.LabelWinnerDogName.AutoSize = true;
            this.LabelWinnerDogName.Location = new System.Drawing.Point(24, 30);
            this.LabelWinnerDogName.Name = "LabelWinnerDogName";
            this.LabelWinnerDogName.Size = new System.Drawing.Size(98, 13);
            this.LabelWinnerDogName.TabIndex = 8;
            this.LabelWinnerDogName.Text = "Winner Dog Name:";
            // 
            // labelWinnerDogNameDesc
            // 
            this.labelWinnerDogNameDesc.AutoSize = true;
            this.labelWinnerDogNameDesc.Location = new System.Drawing.Point(141, 30);
            this.labelWinnerDogNameDesc.Name = "labelWinnerDogNameDesc";
            this.labelWinnerDogNameDesc.Size = new System.Drawing.Size(64, 13);
            this.labelWinnerDogNameDesc.TabIndex = 9;
            this.labelWinnerDogNameDesc.Text = "Winner Dog";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Location = new System.Drawing.Point(3, 30);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(47, 13);
            this.labelWarning.TabIndex = 10;
            this.labelWarning.Text = "Warning";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "se";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select a Distance",
            "50",
            "100",
            "200",
            "400",
            "500"});
            this.comboBox1.Location = new System.Drawing.Point(108, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // labelComboBox
            // 
            this.labelComboBox.AutoSize = true;
            this.labelComboBox.Location = new System.Drawing.Point(3, 55);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(89, 13);
            this.labelComboBox.TabIndex = 12;
            this.labelComboBox.Text = "Race Notification";
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Location = new System.Drawing.Point(18, 56);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(42, 17);
            this.radioButtonJoe.TabIndex = 13;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "Joe";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            this.radioButtonJoe.CheckedChanged += new System.EventHandler(this.radioButtonJoe_CheckedChanged);
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Location = new System.Drawing.Point(18, 79);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBob.TabIndex = 14;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "Bob";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            this.radioButtonBob.CheckedChanged += new System.EventHandler(this.radioButtonBob_CheckedChanged);
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Location = new System.Drawing.Point(18, 36);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(34, 17);
            this.radioButtonAl.TabIndex = 15;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "Al";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            this.radioButtonAl.CheckedChanged += new System.EventHandler(this.radioButtonAl_CheckedChanged);
            // 
            // labelGuyPlacingBet
            // 
            this.labelGuyPlacingBet.AutoSize = true;
            this.labelGuyPlacingBet.Location = new System.Drawing.Point(34, 20);
            this.labelGuyPlacingBet.Name = "labelGuyPlacingBet";
            this.labelGuyPlacingBet.Size = new System.Drawing.Size(26, 13);
            this.labelGuyPlacingBet.TabIndex = 16;
            this.labelGuyPlacingBet.Text = "Guy";
            // 
            // numericBet
            // 
            this.numericBet.Location = new System.Drawing.Point(147, 18);
            this.numericBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericBet.Name = "numericBet";
            this.numericBet.Size = new System.Drawing.Size(120, 20);
            this.numericBet.TabIndex = 17;
            this.numericBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelStaticMessage
            // 
            this.labelStaticMessage.AutoSize = true;
            this.labelStaticMessage.Location = new System.Drawing.Point(273, 20);
            this.labelStaticMessage.Name = "labelStaticMessage";
            this.labelStaticMessage.Size = new System.Drawing.Size(92, 13);
            this.labelStaticMessage.TabIndex = 18;
            this.labelStaticMessage.Text = "Bucks on Dog No";
            // 
            // buttonPlaceBet
            // 
            this.buttonPlaceBet.Location = new System.Drawing.Point(66, 15);
            this.buttonPlaceBet.Name = "buttonPlaceBet";
            this.buttonPlaceBet.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceBet.TabIndex = 20;
            this.buttonPlaceBet.Text = "Place Bet";
            this.buttonPlaceBet.UseVisualStyleBackColor = true;
            this.buttonPlaceBet.Click += new System.EventHandler(this.buttonPlaceBet_Click);
            // 
            // labelGuySituation
            // 
            this.labelGuySituation.AutoSize = true;
            this.labelGuySituation.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelGuySituation.Location = new System.Drawing.Point(6, 40);
            this.labelGuySituation.Name = "labelGuySituation";
            this.labelGuySituation.Size = new System.Drawing.Size(70, 13);
            this.labelGuySituation.TabIndex = 21;
            this.labelGuySituation.Text = "Guy Situation";
            // 
            // numericUpDownDeposit
            // 
            this.numericUpDownDeposit.Location = new System.Drawing.Point(28, 130);
            this.numericUpDownDeposit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDeposit.Name = "numericUpDownDeposit";
            this.numericUpDownDeposit.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDeposit.TabIndex = 22;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(43, 154);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(93, 23);
            this.buttonDeposit.TabIndex = 23;
            this.buttonDeposit.Tag = "";
            this.buttonDeposit.Text = "Make Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // labelAlSituation
            // 
            this.labelAlSituation.AutoSize = true;
            this.labelAlSituation.Location = new System.Drawing.Point(69, 40);
            this.labelAlSituation.Name = "labelAlSituation";
            this.labelAlSituation.Size = new System.Drawing.Size(60, 13);
            this.labelAlSituation.TabIndex = 24;
            this.labelAlSituation.Text = "Al Situation";
            // 
            // labelBobSituation
            // 
            this.labelBobSituation.AutoSize = true;
            this.labelBobSituation.Location = new System.Drawing.Point(69, 83);
            this.labelBobSituation.Name = "labelBobSituation";
            this.labelBobSituation.Size = new System.Drawing.Size(70, 13);
            this.labelBobSituation.TabIndex = 25;
            this.labelBobSituation.Text = "Bob Situation";
            // 
            // labelJoeSituation
            // 
            this.labelJoeSituation.AutoSize = true;
            this.labelJoeSituation.Location = new System.Drawing.Point(69, 60);
            this.labelJoeSituation.Name = "labelJoeSituation";
            this.labelJoeSituation.Size = new System.Drawing.Size(68, 13);
            this.labelJoeSituation.TabIndex = 26;
            this.labelJoeSituation.Text = "Joe Situation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownDeposit);
            this.panel1.Controls.Add(this.labelAlSituation);
            this.panel1.Controls.Add(this.radioButtonAl);
            this.panel1.Controls.Add(this.buttonDeposit);
            this.panel1.Controls.Add(this.radioButtonJoe);
            this.panel1.Controls.Add(this.labelJoeSituation);
            this.panel1.Controls.Add(this.labelBobSituation);
            this.panel1.Controls.Add(this.radioButtonBob);
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 183);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a guy and make a deposit";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTrackDistance);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.labelComboBox);
            this.panel2.Controls.Add(this.labelWarning);
            this.panel2.Location = new System.Drawing.Point(202, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 118);
            this.panel2.TabIndex = 28;
            // 
            // listBoxBetsPlaced
            // 
            this.listBoxBetsPlaced.FormattingEnabled = true;
            this.listBoxBetsPlaced.Location = new System.Drawing.Point(42, 44);
            this.listBoxBetsPlaced.Name = "listBoxBetsPlaced";
            this.listBoxBetsPlaced.Size = new System.Drawing.Size(451, 56);
            this.listBoxBetsPlaced.TabIndex = 21;
            // 
            // pictureBoxRaceTrack
            // 
            this.pictureBoxRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRaceTrack.Image")));
            this.pictureBoxRaceTrack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxRaceTrack.Name = "pictureBoxRaceTrack";
            this.pictureBoxRaceTrack.Size = new System.Drawing.Size(1015, 229);
            this.pictureBoxRaceTrack.TabIndex = 30;
            this.pictureBoxRaceTrack.TabStop = false;
            // 
            // groupBoxBasePlatform
            // 
            this.groupBoxBasePlatform.Controls.Add(this.groupBox1);
            this.groupBoxBasePlatform.Controls.Add(this.labelGuySituation);
            this.groupBoxBasePlatform.Controls.Add(this.groupBox2);
            this.groupBoxBasePlatform.Controls.Add(this.panel2);
            this.groupBoxBasePlatform.Controls.Add(this.panel1);
            this.groupBoxBasePlatform.Location = new System.Drawing.Point(6, 235);
            this.groupBoxBasePlatform.Name = "groupBoxBasePlatform";
            this.groupBoxBasePlatform.Size = new System.Drawing.Size(1050, 246);
            this.groupBoxBasePlatform.TabIndex = 31;
            this.groupBoxBasePlatform.TabStop = false;
            this.groupBoxBasePlatform.Text = "Betting Parlor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNumericDogPosition);
            this.groupBox1.Controls.Add(this.numericBet);
            this.groupBox1.Controls.Add(this.buttonPlaceBet);
            this.groupBox1.Controls.Add(this.listBoxBetsPlaced);
            this.groupBox1.Controls.Add(this.labelGuyPlacingBet);
            this.groupBox1.Controls.Add(this.labelStaticMessage);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 104);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Section";
            // 
            // comboBoxNumericDogPosition
            // 
            this.comboBoxNumericDogPosition.FormattingEnabled = true;
            this.comboBoxNumericDogPosition.Location = new System.Drawing.Point(371, 15);
            this.comboBoxNumericDogPosition.Name = "comboBoxNumericDogPosition";
            this.comboBoxNumericDogPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumericDogPosition.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelWinnerDogName);
            this.groupBox2.Controls.Add(this.buttonStartRace);
            this.groupBox2.Controls.Add(this.labelDistance);
            this.groupBox2.Controls.Add(this.labelTime);
            this.groupBox2.Controls.Add(this.labelWinnerDogNameDesc);
            this.groupBox2.Controls.Add(this.labelDistanceDescription);
            this.groupBox2.Controls.Add(this.labelTimeDesc);
            this.groupBox2.Controls.Add(this.buttonNewDog);
            this.groupBox2.Location = new System.Drawing.Point(491, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 118);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dogs in the Race";
            // 
            // pictureBoxDog1
            // 
            this.pictureBoxDog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog1.Image")));
            this.pictureBoxDog1.Location = new System.Drawing.Point(20, 21);
            this.pictureBoxDog1.Name = "pictureBoxDog1";
            this.pictureBoxDog1.Size = new System.Drawing.Size(78, 23);
            this.pictureBoxDog1.TabIndex = 32;
            this.pictureBoxDog1.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this.pictureBoxDog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog2.Image")));
            this.pictureBoxDog2.Location = new System.Drawing.Point(20, 70);
            this.pictureBoxDog2.Name = "pictureBoxDog2";
            this.pictureBoxDog2.Size = new System.Drawing.Size(78, 23);
            this.pictureBoxDog2.TabIndex = 33;
            this.pictureBoxDog2.TabStop = false;
            // 
            // label1DogName
            // 
            this.label1DogName.AutoSize = true;
            this.label1DogName.Location = new System.Drawing.Point(12, 47);
            this.label1DogName.Name = "label1DogName";
            this.label1DogName.Size = new System.Drawing.Size(67, 13);
            this.label1DogName.TabIndex = 37;
            this.label1DogName.Text = "Dog 1 Name";
            // 
            // label4DogName
            // 
            this.label4DogName.AutoSize = true;
            this.label4DogName.Location = new System.Drawing.Point(15, 214);
            this.label4DogName.Name = "label4DogName";
            this.label4DogName.Size = new System.Drawing.Size(67, 13);
            this.label4DogName.TabIndex = 38;
            this.label4DogName.Text = "Dog 4 Name";
            // 
            // label3DogName
            // 
            this.label3DogName.AutoSize = true;
            this.label3DogName.Location = new System.Drawing.Point(15, 155);
            this.label3DogName.Name = "label3DogName";
            this.label3DogName.Size = new System.Drawing.Size(67, 13);
            this.label3DogName.TabIndex = 39;
            this.label3DogName.Text = "Dog 3 Name";
            // 
            // label2DogName
            // 
            this.label2DogName.AutoSize = true;
            this.label2DogName.Location = new System.Drawing.Point(15, 96);
            this.label2DogName.Name = "label2DogName";
            this.label2DogName.Size = new System.Drawing.Size(67, 13);
            this.label2DogName.TabIndex = 40;
            this.label2DogName.Text = "Dog 2 Name";
            // 
            // pictureBoxDog3
            // 
            this.pictureBoxDog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog3.Image")));
            this.pictureBoxDog3.Location = new System.Drawing.Point(20, 129);
            this.pictureBoxDog3.Name = "pictureBoxDog3";
            this.pictureBoxDog3.Size = new System.Drawing.Size(78, 23);
            this.pictureBoxDog3.TabIndex = 41;
            this.pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog4
            // 
            this.pictureBoxDog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog4.Image")));
            this.pictureBoxDog4.Location = new System.Drawing.Point(20, 188);
            this.pictureBoxDog4.Name = "pictureBoxDog4";
            this.pictureBoxDog4.Size = new System.Drawing.Size(78, 23);
            this.pictureBoxDog4.TabIndex = 42;
            this.pictureBoxDog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 493);
            this.Controls.Add(this.pictureBoxDog4);
            this.Controls.Add(this.pictureBoxDog3);
            this.Controls.Add(this.label2DogName);
            this.Controls.Add(this.label3DogName);
            this.Controls.Add(this.label4DogName);
            this.Controls.Add(this.label1DogName);
            this.Controls.Add(this.pictureBoxDog2);
            this.Controls.Add(this.pictureBoxDog1);
            this.Controls.Add(this.groupBoxBasePlatform);
            this.Controls.Add(this.pictureBoxRaceTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaceTrack)).EndInit();
            this.groupBoxBasePlatform.ResumeLayout(false);
            this.groupBoxBasePlatform.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStartRace;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDistanceDescription;
        private System.Windows.Forms.Label labelTimeDesc;
        private System.Windows.Forms.Button buttonNewDog;
        private System.Windows.Forms.Label labelTrackDistance;
        private System.Windows.Forms.Label LabelWinnerDogName;
        private System.Windows.Forms.Label labelWinnerDogNameDesc;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelComboBox;
        private System.Windows.Forms.RadioButton radioButtonJoe;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.Label labelGuyPlacingBet;
        private System.Windows.Forms.NumericUpDown numericBet;
        private System.Windows.Forms.Label labelStaticMessage;
        private System.Windows.Forms.Button buttonPlaceBet;
        private System.Windows.Forms.Label labelGuySituation;
        private System.Windows.Forms.NumericUpDown numericUpDownDeposit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Label labelAlSituation;
        private System.Windows.Forms.Label labelBobSituation;
        private System.Windows.Forms.Label labelJoeSituation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxBetsPlaced;
        private System.Windows.Forms.PictureBox pictureBoxRaceTrack;
        private System.Windows.Forms.GroupBox groupBoxBasePlatform;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxDog1;
        private System.Windows.Forms.PictureBox pictureBoxDog2;
        private System.Windows.Forms.Label label1DogName;
        private System.Windows.Forms.Label label4DogName;
        private System.Windows.Forms.Label label3DogName;
        private System.Windows.Forms.Label label2DogName;
        private System.Windows.Forms.PictureBox pictureBoxDog3;
        private System.Windows.Forms.PictureBox pictureBoxDog4;
        private System.Windows.Forms.ComboBox comboBoxNumericDogPosition;
    }
}

