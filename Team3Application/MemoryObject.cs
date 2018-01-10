using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3Application {
    class MemoryObject {

        /// <summary>
        /// Length of hex strings.
        /// </summary>
        /// 
        public int
            temp = 0;
        public double
            temp2 = 0;
            
        public const int
            HEX_LENGTH = 5,
            HEX_NEGATIVE_LENGTH = 8;

        /// <summary>
        /// Opcode definition.
        /// </summary>
        public const int
            OP_NOP = -1,
            OP_READ = 0,        // 10
            OP_WRITE = 1,       // 11
            OP_LOAD = 2,        // 20
            OP_STORE = 3,       // 21
            OP_ADD = 4,         // 30
            OP_SUBTRACT = 5,    // 31
            OP_DIVIDE = 6,      // 32
            OP_MULTIPLY = 7,    // 33'
            OP_EXPONENTIAL = 12,// 34
            OP_REMAINDER = 13,  // 35
            OP_BRANCH = 8,      // 40
            OP_BRANCHNEG = 9,   // 41
            OP_BRANCHZERO = 10, // 42
            OP_HALT = 11;       // 43

        #region Variables

        /// <summary>
        /// Instruction label.
        /// </summary>
        private string label = "";

        /// <summary>
        /// Data in the memory location.
        /// </summary>
        private string data = "00000";

        /// <summary>
        /// Opcode represented by data.
        /// </summary>
        private string opcode = "NOP";

        /// <summary>
        /// Value represented by data.
        /// </summary>
        private int value = 0;

        /// <summary>
        /// Pointer back to the main window.
        /// </summary>
        private Form1 mainWindow = null;

        /// <summary>
        /// Pointer to the associated data row.
        /// </summary>
        private System.Data.DataRow dataRow = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="form"></param>
        public MemoryObject(Form1 form, System.Data.DataRow row) {
            // set main window pointer
            mainWindow = form;

            // set data row pointer
            dataRow = row;
        }

        #endregion

        #region Getters/Setters

        /// <summary>
        /// Set the memory values from hex string.
        /// </summary>
        /// <param name="val"></param>
        public void SetValue(int val) {
            // convert the value to the hex string.
            string hex = IntToHex(val);

            // set the values
            data = hex;
            opcode = OpcodeForGUI(hex);
            value = HexToInt(IntToHex(val));

            // refresh the GUI
            UpdateGUI();
        }

        /// <summary>
        /// Get the value of this memory location.
        /// </summary>
        /// <returns></returns>
        public int GetValue() {
            return value;
        }

        #endregion

        #region Conversions

        /// <summary>
        /// Generate string representing the opcode to show to the user.
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string OpcodeForGUI(string hex) {
            // setup return value
            string code;

            // setup suffix
            string suffix = hex.Substring(2);

            // determine the instruction text based on logical instruction
            switch (OpcodeForLogic(hex)) {
                case OP_READ:
                    code = "READ " + suffix;
                    break;
                case OP_WRITE:
                    code = "WRITE " + suffix;
                    break;
                case OP_LOAD:
                    code = "LOAD " + suffix;
                    break;
                case OP_STORE:
                    code = "STORE " + suffix;
                    break;
                case OP_ADD:
                    code = "ADD " + suffix;
                    break;
                case OP_SUBTRACT:
                    code = "SUBTRACT " + suffix;
                    break;
                case OP_DIVIDE:
                    code = "DIVIDE " + suffix;
                    break;
                case OP_MULTIPLY:
                    code = "MULTIPLY " + suffix;
                    break;
                case OP_EXPONENTIAL:
                    code = "EXPONENTIAL " + suffix;
                    break;
                case OP_REMAINDER:
                    code = "REMAINDER " + suffix;
                    break;
                case OP_BRANCH:
                    code = "BRANCH " + suffix;
                    break;
                case OP_BRANCHNEG:
                    code = "BRANCH-NEG " + suffix;
                    break;
                case OP_BRANCHZERO:
                    code = "BRANCH-ZERO " + suffix;
                    break;
                case OP_HALT:
                    code = "HALT";
                    break;
                default:
                    code = "NOP";
                    break;
            }

            // return the generated string
            return code;
        }

        /// <summary>
        /// Get logical operation based on hex string.
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static int OpcodeForLogic(string hex) {
            // setup return value
            int code = OP_NOP;

            // get the first two characters of the data to decide code
            string pre = hex.Substring(0, 2);

            // return the value based on the code
            switch (pre) {
                case "10":
                    code = OP_READ;
                    break;
                case "11":
                    code = OP_WRITE;
                    break;
                case "20":
                    code = OP_LOAD;
                    break;
                case "21":
                    code = OP_STORE;
                    break;
                case "30":
                    code = OP_ADD;
                    break;
                case "31":
                    code = OP_SUBTRACT;
                    break;
                case "32":
                    code = OP_DIVIDE;
                    break;
                case "33":
                    code = OP_MULTIPLY;
                    break;
                case "34":
                    code = OP_EXPONENTIAL;
                    break;
                case "35":
                    code = OP_REMAINDER;
                    break;

                case "40":
                    code = OP_BRANCH;
                    break;
                case "41":
                    code = OP_BRANCHNEG;
                    break;
                case "42":
                    code = OP_BRANCHZERO;
                    break;
                case "43":
                    code = OP_HALT;
                    break;
            }

            // return the opcode value
            return code;
        }

        /// <summary>
        /// Convert hex to integer.
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static int HexToInt(string hex) {
            // ensure that the hex string exists
            if (hex == null || hex.Length == 0) {
                hex = "00000";
            }

            // ensure the string is the correct length
            SetHexToCorrectLength(ref hex);

            // ensure that the hex string only holds valid characters
            string _hex = "";
            hex = hex.ToUpper();
            for (int i = 0; i < hex.Length; i++) {
                char c = hex[i];
                if ((c < '0' || c > '9') && (c < 'A' || c > 'F')) {
                    c = '0';
                }
                _hex += c;
            }

            // if the value should be negative then prepend F until it is the correct length
            if (_hex[0] == '8' || _hex[0] == '9' || (_hex[0] >= 'A' && _hex[0] <= 'F')) {
                while (_hex.Length < HEX_NEGATIVE_LENGTH) {
                    _hex = 'F' + _hex;
                }
            }

            // setup return value
            int val = Convert.ToInt32(_hex, 16);

            // return converted value
            return val;
        }

        /// <summary>
        /// Convert int to hex string.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string IntToHex(int val) {
            // setup string to return
            string hex = Convert.ToString(val, 16);

            // ensure the string is the correct length
            SetHexToCorrectLength(ref hex);

            // set all to upper case
            hex = hex.ToUpper();

            // return the hex string
            return hex;
        }

        /// <summary>
        /// Sets hex string to the correct length.
        /// </summary>
        /// <param name="hex"></param>
        private static void SetHexToCorrectLength(ref string hex) {
            // add 0's to the left until it is the correct length
            while (hex.Length < HEX_LENGTH) {
                hex = '0' + hex;
            }
            // remove everything to the left until it is the correct length
            if (hex.Length > HEX_LENGTH) {
                hex = hex.Substring(hex.Length - HEX_LENGTH);
            }
        }

        #endregion

        /// <summary>
        /// Updates the values in the GUI. Should be called at the end of any value changes.
        /// </summary>
        public void UpdateGUI() {
            dataRow["Label"] = label;
            dataRow["Data"] = data;
            dataRow["Opcode"] = opcode;
            dataRow["Value"] = value;
        }

        /// <summary>
        /// Attempts to execute instruction in this memory location.
        /// </summary>
        public void Execute() {
            // get address
            int address = HexToInt(data.Substring(2));

            // determine nature of the instruction.
            switch (OpcodeForLogic(data)) {
                case OP_READ:
                    Read(address);
                    break;
                case OP_WRITE:
                    Write(address);
                    break;
                case OP_LOAD:
                    Load(address);
                    break;
                case OP_STORE:
                    Store(address);
                    break;
                case OP_ADD:
                    Add(address);
                    break;
                case OP_SUBTRACT:
                    Subtract(address);
                    break;
                case OP_DIVIDE:
                    Divide(address);
                    break;
                case OP_MULTIPLY:
                    Multiply(address);
                    break;
                case OP_EXPONENTIAL:
                    Exponential(address);
                    break;
                case OP_REMAINDER:
                   Remainder(address);
                    break;



                case OP_BRANCH:
                    Branch(address);
                    break;
                case OP_BRANCHNEG:
                    BranchNegative(address);
                    break;
                case OP_BRANCHZERO:
                    BranchZero(address);
                    break;
                case OP_HALT:
                    mainWindow.Halt();
                    break;
                default:
                    // stop the timer and tell the user that the opcode was invalid
                    mainWindow.Halt();
                    System.Windows.Forms.MessageBox.Show("Unrecognized instruction. Halting the processor.");
                    break;
            }
        }

        /// <summary>
        /// Test if the address is valid or not and tell the user that there is an error (if at all).
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private bool IsAddressValid(int address) {
            // if the address is out of range then throw an error to the user and halt the program
            if (address < 0 || address >= Form1.MEMORY_SIZE) {
                mainWindow.Halt();
                System.Windows.Forms.MessageBox.Show("Address is out of range. Halting the processor.");
                return false;
            }
            return true;
        }

        #region Logic

        public void Read(int address) {
            if (!IsAddressValid(address)) {
                return;
            }
            
            mainWindow.SetConsole("Enter a character: ");
            mainWindow.GetConsole();
        }

        public void Write(int address) {
            if (!IsAddressValid(address)) {
                return;
            }
            mainWindow.SetConsole($"{address}\r\n");
        }

        public void Load(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            mainWindow.SetAccumulator(mainWindow.GetMemoryAtAddress(address));
        }
        
        public void Store(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            mainWindow.SetMemoryAtAddress(address, mainWindow.GetAccumulator());
        }

        public void Add(int address) {
            if (!IsAddressValid(address)) {
                return;
            }
            
            mainWindow.SetAccumulator(mainWindow.GetAccumulator() + mainWindow.GetMemoryAtAddress(address));
        }

        public void Subtract(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            mainWindow.SetAccumulator(mainWindow.GetAccumulator() - mainWindow.GetMemoryAtAddress(address));
        }

        public void Divide(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            mainWindow.SetAccumulator(mainWindow.GetAccumulator() / mainWindow.GetMemoryAtAddress(address));
        }

        public void Multiply(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            mainWindow.SetAccumulator(mainWindow.GetAccumulator() * mainWindow.GetMemoryAtAddress(address));
        }

        public void Branch(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            mainWindow.SetPC(address);
        }

        public void BranchNegative(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            if (mainWindow.GetAccumulator() < 0) {
                mainWindow.SetPC(address);
            }
        }

        public void BranchZero(int address) {
            if (!IsAddressValid(address)) {
                return;
            }

            if (mainWindow.GetAccumulator() == 0) {
                mainWindow.SetPC(address);
            }
        }

        public void Exponential(int address)
        {
            if (!IsAddressValid(address))
            {
                return;
            }
            temp2 = Math.Pow(mainWindow.GetAccumulator(), mainWindow.GetMemoryAtAddress(address));  //set result of exponential function to a double variable 
            temp = (int)temp2;                                                                      //Cast double to int
            mainWindow.SetAccumulator(temp);                                                        //Set the accumulator to the result
        }
        
        public void Remainder(int address)
        {
            if (!IsAddressValid(address))
            {
                return;
            }

        mainWindow.SetAccumulator(mainWindow.GetAccumulator() % mainWindow.GetMemoryAtAddress(address));
        }
            #endregion

        }
}
