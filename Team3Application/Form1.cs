using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Team3Application {
    public partial class Form1 : Form {

        /// <summary>
        /// The number of memory locations in this "computer."
        /// </summary>
        public const int MEMORY_SIZE = 100;

        /// <summary>
        /// Data represented in the GridMemory object exposed to the GUI.
        /// </summary>
        private DataTable memory = new DataTable();

        private string data = "00000";
        private int value = 0;
        private int pc = 0;
        private bool alreadyExpanded = false;
        OpenFileDialog openFileMain = new OpenFileDialog();

        /// <summary>
        /// Memory objects array.
        /// </summary>
        private MemoryObject[] memoryRows = new MemoryObject[MEMORY_SIZE];

        public Form1() {
            // initialize sub-components
            InitializeComponent();


            // don't allow the user to add any rows
            GridMemory.AllowUserToAddRows = false;

            // bind data objects
            GridMemory.DataSource = memory;

            // setup the collumns
            memory.Columns.AddRange(new DataColumn[] { new DataColumn("Location"), new DataColumn("Label", typeof(string)), new DataColumn("Data", typeof(string)), new DataColumn("Opcode"), new DataColumn("Value", typeof(Int32)) });
            GridMemory.Columns[0].ReadOnly = true;
            GridMemory.Columns[3].ReadOnly = true;

            // setup memory rows
            for (int i = 0; i < MEMORY_SIZE; i++) {
                // add memory row
                memory.Rows.Add(new object[] { MemoryObject.IntToHex(i), "", "00000", "NOP", 0 });

                // add memory object
                memoryRows[i] = new MemoryObject(this, memory.Rows[i]);
            }

            GridMemory.CellValueChanged += GridMemory_CellValueChanged;
        }

        private void GridMemory_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            // determine what was changed
            if (e.ColumnIndex == 1) { // label
                // not currently implemented
            }
            else if (e.ColumnIndex == 2) { // data
                // set the value
                memoryRows[e.RowIndex].SetValue(MemoryObject.HexToInt((string)GridMemory.Rows[e.RowIndex].Cells[2].Value));
            }
            else if (e.ColumnIndex == 4) { // value
                // set the value
                int val = (int)GridMemory.Rows[e.RowIndex].Cells[4].Value;
                memoryRows[e.RowIndex].SetValue(val);
            }
        }

        public int GetAccumulator() {
            return value;
        }

        public void SetAccumulator(int val) {
            data = MemoryObject.IntToHex(val);
            value = MemoryObject.HexToInt(data);
            TxtAccumulator.Text = data;
            LabelAccumulatorValue.Text = value.ToString();
        }

        public void SetConsole(string text)
        {
            Console.Text += text;
        }

        public void GetConsole()
        {
            Chrono.Stop();
            Console.ReadOnly = false;
        }

        public int GetMemoryAtAddress(int address) {
            return memoryRows[address].GetValue();
        }

        public void SetMemoryAtAddress(int address, int val) {
            memoryRows[address].SetValue(val);
        }

        public void SetPC(int val) {
            pc = val;
        }

        public void Execute() {
            // get the memory object at the correct location and increment the pc
            MemoryObject m = memoryRows[pc++];

            // execute the instruction
            m.Execute();

            // clear all selections
            GridMemory.ClearSelection();

            // highlight the next instruction
            GridMemory.Rows[pc].Selected = true;
        }

        public void Halt() {
            Chrono.Stop();
        }

        private void Chrono_Tick(object sender, EventArgs e) {
            // execute the next instruction
            Execute();
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e) {
            Execute();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e) {
            Halt();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) {
            Chrono.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            Halt();
            pc = 0;
            SetAccumulator(0);
        }

        private void Console_KeyDown(object sender, KeyEventArgs e) {
            if (!Console.ReadOnly) {
                Console.Text += $"{e.KeyData}\r\n";
                SetAccumulator((int)e.KeyData);
                Console.ReadOnly = true;
                Chrono.Start();
            }
        }

        private void BtnExpand_Click(object sender, EventArgs e)
        {
            if (alreadyExpanded == true)
            {
                Form1.ActiveForm.Width = 594;
                alreadyExpanded = false;
                BtnExpand.Text = "Show Text Editor";
            }
            else
            {
                Form1.ActiveForm.Width = 950;
                alreadyExpanded = true;
                BtnExpand.Text = "Hide Text Editor";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Width = 594;
            this.Width = 594;
            for(int i = 0; i < MEMORY_SIZE; i++)
            {
                RTBoxMain.Text += "\n";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RTBoxMain.Text = "";
            for (int i = 0; i < MEMORY_SIZE; i++)
            {
                RTBoxMain.Text += "\n";
            }
        }

            private void BtnTransferPtoTE_Click(object sender, EventArgs e)
        {
            RTBoxMain.Text = "";
            for (int i = 0; i < MEMORY_SIZE; i++)
            {
                string tempstring = GridMemory.Rows[i].Cells[2].Value.ToString();
                if (tempstring == "00000")
                    tempstring = "";
                tempstring += '\n';
                RTBoxMain.Text += tempstring;
            }
        }

        private void BtnTransferTEtoP_Click(object sender, EventArgs e)
        {
            string tempString = "";
            string failureMessage = "The following lines were not inputted into the system due to inproper format and have been flagged red:\n";
            string myReg = "^[0-9a-fA-F]{5}$";
            Regex r = new Regex(myReg);
            Match m;
            bool aFailedLine = false;

            for (int i = 0; i < 100; i++)
            {
                tempString = RTBoxMain.Lines[i].ToString();
                m = r.Match(tempString);
                if (m.Success)
                {
                    GridMemory.Rows[i].Cells[2].Value = tempString;
                }
                else if(tempString != "00000")
                {
                    if (tempString == "")
                    { }
                    else
                    {
                        string myColorString = tempString;
                        int my1stPosition = RTBoxMain.Find(myColorString);
                        RTBoxMain.SelectionStart = my1stPosition;
                        RTBoxMain.SelectionLength = myColorString.Length;
                        RTBoxMain.SelectionColor = Color.Red;

                        failureMessage += "Line #" + i + ", ";
                        aFailedLine = true;
                    }
                }

            }


            if (aFailedLine == true)
            {
                failureMessage = failureMessage.Substring(0, failureMessage.Length - 2);
                MessageBox.Show(failureMessage);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Box Information:\n\nInsert one memory location per line.  Accepts any HEX value up to 5 characters long per line.  Any value not allowed will be flagged as red.  Make sure to include BLANK locations where needed.");
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {


            openFileMain.DefaultExt = "*.txt";
            openFileMain.Filter = "TXT Files|*.txt";

            if(openFileMain.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileMain.FileName.Length > 0)
            {
                RTBoxMain.LoadFile(openFileMain.FileName, RichTextBoxStreamType.PlainText);
            }
            for (int i = 0; i < MEMORY_SIZE; i++)
            {
                RTBoxMain.Text += "\n";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileMain = new SaveFileDialog();

            saveFileMain.DefaultExt = "*.txt";
            saveFileMain.Filter = "TXT files|*.txt";

            if(saveFileMain.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileMain.FileName.Length > 0)
            {
                RTBoxMain.SaveFile(saveFileMain.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
