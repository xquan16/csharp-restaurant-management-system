using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_admin_
{
    public partial class k1 : Form
    {
        private Dictionary<string, Item> _menuItems; 
        private List<Order> _orderSummary; 
        private DatabaseService _dbService; 
        private int _tableNumber;
        private bool sidebarExpand;

        public k1()
        {
            InitializeComponent();
            _menuItems = InitializeMenuItems();
            _orderSummary = new List<Order>();
            _dbService = new DatabaseService();
            label1.Text = "Menu Categories";
            sidebarExpand = true;
        }

        private Dictionary<string, Item> InitializeMenuItems()
        {
            return new Dictionary<string, Item>
        {
            {"Amaebi Sashimi", new Item("Amaebi Sashimi", 48.00, domainUpDownAmaebiSashimi)},
            {"Amaebi Sushi", new Item("Amaebi Sushi", 54.00, domainUpDownAmaebiSushi)},
            {"Blue Me Away-MockTail", new Item("Blue Me Away-MockTail", 13.90, domainUpDownBlueMeAwayMockTail)},
            {"California HandRoll", new Item("California HandRoll", 8.00, domainUpDownCaliforniaHandRoll)},
            {"Chutoro Sashimi", new Item("Chutoro Sashimi", 95.00, domainUpDownChutoroSashimi)},
            {"Drunk With U-MockTail", new Item("Drunk With U-MockTail", 13.90, domainUpDownDrunkWithUMockTail)},
            {"Ebi Sushi", new Item("Ebi Sushi", 12.00, domainUpDownEbiSushi)},
            {"Ebiten HandRoll", new Item("Ebiten HandRoll", 10.00, domainUpDownEbitenHandRoll)},
            {"Engawa HandRoll", new Item("Engawa HandRoll", 14.00, domainUpDownEngawaHandRoll)},
            {"Engawa No Seaweed Sushi", new Item("Engawa No Seaweed Sushi", 36.00, domainUpDownEngawaNoSeaweedSushi)},
            {"Engawa Sushi", new Item("Engawa Sushi", 39.00, domainUpDownEngawaSushi)},
            {"Foie Gras Sushi", new Item("Foie Gras Sushi", 75.00, domainUpDownFoieGrasSushi)},
            {"Granate Love U-MockTail", new Item("Granate Love U-MockTail", 13.90, domainUpDownGranateLoveUMockTail)},
            {"Hana Ramen", new Item("Hana Ramen", 25.00, domainUpDownHanaRamen)},
            {"Hana Sashimi Moriawase", new Item("Hana Sashimi Moriawase", 230.00, domainUpDownHanaSashimiMoriawase)},
            {"Hana Sushi Moriawase", new Item("Hana Sushi Moriawase", 155.00, domainUpDownHanaSushiMoriawase)},
            {"Hokkaido Don", new Item("Hokkaido Don", 50.00, domainUpDownHokkaidoDon)},
            {"Hotate Sashimi", new Item("Hotate Sashimi", 38.00, domainUpDownHotateSashimi)},
            {"Hotate Sushi", new Item("Hotate Sushi", 27.00, domainUpDownHotateSushi)},
            {"Ikura Salmon HandRoll", new Item("Ikura Salmon HandRoll", 13.00, domainUpDownIkuraSalmonHandRoll)},
            {"Ikura Sushi", new Item("Ikura Sushi", 39.00, domainUpDownIkuraSushi)},
            {"Inari Sushi", new Item("Inari Sushi", 6.00, domainUpDownInariSushi)},
            {"Kampachi Sashimi", new Item("Kampachi Sashimi", 45.00, domainUpDownKampachiSashimi)},
            {"Kampachi Sushi", new Item("Kampachi Sushi", 27.00, domainUpDownKampachiSushi)},
            {"Kinoko Soba Udon", new Item("Kinoko Soba Udon", 19.00, domainUpDownKinokoSobaUdon)},
            {"Maguro Sashimi", new Item("Maguro Sashimi", 38.00, domainUpDownMagoroSashimi)},
            {"Maguro Sushi", new Item("Maguro Sushi", 24.00, domainUpDownMaguroSushi)},
            {"Mint to Be-MockTail", new Item("Mint to Be-MockTail", 13.90, domainUpDownMintTobeMockTail)},
            {"Nabeyaki Udon", new Item("Nabeyaki Udon", 25.00, domainUpDownNabeyakiUdon)},
            {"Nama Seasalt Sushi", new Item("Nama Seasalt Sushi", 51.00, domainUpDownNamaSeasaltSushi)},
            {"Nama Sushi", new Item("Nama Sushi", 51.00, domainUpDownNamaSushi)},
            {"Nama Truffle Sushi", new Item("Nama Truffle Sushi", 69.00, domainUpDownNamaTruffleSushi)},
            {"Negi Aburi Sushi", new Item("Negi Aburi Sushi", 51.00, domainUpDownNegiAburiSushi)},
            {"Nikura Sushi", new Item("Nikura Sushi", 80.00, domainUpDownNikuraSushi)},
            {"Niku Soba Udon", new Item("Niku Soba Udon", 27.00, domainUpDownNikuSobaUdon)},
            {"Ninniku Aburi Sushi", new Item("Ninniku Aburi Sushi", 51.00, domainUpDownNinikuAburiSushi)},
            {"Otoro Sashimi", new Item("Otoro Sashimi", 110.00, domainUpDownOtoroSashimi)},
            {"Passion U-MockTail", new Item("Passion U-MockTail", 13.90, domainUpDownPassionUMockTail)},
            {"Salmon Lover Platter", new Item("Salmon Lover Platter", 170.00, domainUpDownSalmonLoverPlatter)},
            {"Salmon Mentai Yaki Sushi", new Item("Salmon Mentai Yaki Sushi", 18.00, domainUpDownSalmonMentaiYakiSushi)},
            {"Salmon Sashimi", new Item("Salmon Sashimi", 23.00, domainUpDownSalmonSashimi)},
            {"Salmon Sushi", new Item("Salmon Sushi", 15.00, domainUpDownSalmonSushi)},
            {"Salmon Toro Sashimi", new Item("Salmon Toro Sashimi", 35.00, domainUpDownSalmonToroSashimi)},
            {"Sashimi Makimono Platter", new Item("Sashimi Makimono Platter", 150.00, domainUpDownSashimiMakimonoPlatter)},
            {"Sea treasure Don", new Item("Sea treasure Don", 60.00, domainUpDownSeaTreasureDon)},
            {"Shake Oyako Don", new Item("Shake Oyako Don", 28.00, domainUpDownShakeOyakoDon)},
            {"Signature Makimono Platter", new Item("Signature Makimono Platter", 140.00, domainUpDownSignatureMakimonoPlatter)},
            {"Soft Shell Crab HandRoll", new Item("Soft Shell Crab HandRoll", 10.00, domainUpDownSoftShellCrabHandRoll)},
            {"Super Ocean Don", new Item("Super Ocean Don", 70.00, domainUpDownSuperOceanDon)},
            {"Sushi Hosomaki Platter", new Item("Sushi Hosomaki Platter", 150.00, domainUpDownSushiHosomakiPlatter)},
            {"Sushi Makimono Platter", new Item("Sushi Makimono Platter", 165.00, domainUpDownSushiMakimonoPlatter)},
            {"Take Sashimi Moriawase", new Item("Take Sashimi Moriawase", 150.00, domainUpDownTakeSashimiMoriawase)},
            {"Take Sushi Moriawase", new Item("Take Sushi Moriawase", 99.00, domainUpDownTakeSushiMoriawase)},
            {"Tamago Sushi", new Item("Tamago Sushi", 9.00, domainUpDownTamagoSushi)},
            {"Tekka Don", new Item("Tekka Don", 35.00, domainUpDownTekkaDon)},
            {"Tempura Soba Udon", new Item("Tempura Soba Udon", 28.00, domainUpDownTempuraSobaUdon)},
            {"Toro Sushi", new Item("Toro Sushi", 60.00, domainUpDownToroSushi)},
            {"Ume Sashimi Moriawase", new Item("Ume Sashimi Moriawase", 50.00, domainUpDownUmeSashimiMoriawase)},
            {"Ume Sushi Moriawase", new Item("Ume Sushi Moriawase", 35.00, domainUpDownUmeSushiMoriawase)},
            {"Unagi Avacado HandRoll", new Item("Unagi Avacado HandRoll", 10.00, domainUpDownUnagiAvacadoHandRoll)},
            {"Unagi Salmon Tamago Platter", new Item("Unagi Salmon Tamago Platter", 165.00, domainUpDownUnagiSalmonTamagoPlatter)},
            {"Unagi Sushi", new Item("Unagi Sushi", 24.00, domainUpDownUnagiSushi)},
            {"Uni Ikura Shake Don", new Item("Uni Ikura Shake Don", 78.00, domainUpDownUniIkuraShakeDon)},
            {"Uniku Sushi", new Item("Uniku Sushi", 120.00, domainUpDownUnikuSushi)},
            {"Uni Sashimi", new Item("Uni Sashimi", 70.00, domainUpDownUniSashimi)},
            {"Uni Sushi", new Item("Uni Sushi", 84.00, domainUpDownUniSUshi)}

        };
    }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void ResetSideBarButtonColor()
        {
            Button[] sidebarButtons = { button2, button3, button5, button7, button9, button11, button13, button15 };
            foreach (Button button in sidebarButtons)
            {
                button.BackColor = Color.Black;
            }
        }
        private void panelBottom_sidebarShow()
        {
            panelbottom.Show();
            panelbottom.BringToFront();
            sidebarContainer.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button2.BackColor = Color.DimGray;
            panelSashimi.Show();
            panelSashimi.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button3.BackColor = Color.DimGray;
            panelNigiriMoriawase.Show();
            panelNigiriMoriawase.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button5.BackColor = Color.DimGray;
            panelSushi.Show();
            panelSushi.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button7.BackColor = Color.DimGray;
            panelPlatter.Show();
            panelPlatter.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button9.BackColor = Color.DimGray;
            panelHandRoll.Show();
            panelHandRoll.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button11.BackColor = Color.DimGray;
            panelOmakaseDon.Show();
            panelOmakaseDon.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button13.BackColor = Color.DimGray;
            panelNoodles.Show();
            panelNoodles.BringToFront();
            panelBottom_sidebarShow();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ResetSideBarButtonColor();
            button15.BackColor = Color.DimGray;
            panelBeverages.Show();
            panelBeverages.BringToFront();
            panelBottom_sidebarShow();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            _orderSummary.Clear();
            listBoxOrderSummary.Items.Clear();
            ResetSideBarButtonColor();
            panelOrderSummary.Show();
            panelOrderSummary.BringToFront();
            sidebarContainer.BringToFront();

            foreach (var item in _menuItems.Values)
            {
                int quantity = item.GetQuantity();
                if (quantity > 0)
                {
                    _orderSummary.Add(new Order(item.Name, quantity, item.Price));
                }
            }

            foreach (var order in _orderSummary)
            {
                listBoxOrderSummary.Items.Add(order.GetOrderDescription());
            }
            double totalPrice = 0;
            foreach (var order in _orderSummary)
            {
                totalPrice += order.TotalPrice; 
            }
            labelTotalPrice.Text = "Total: " + totalPrice.ToString("C2");
            panelbottom.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(listBoxTable.SelectedItem?.ToString(), out _tableNumber))
            {
                MessageBox.Show("Please select a valid table number!");
                return;
            }

            _dbService.SaveOrder(_tableNumber, _orderSummary);
            MessageBox.Show($"Thank you!\nHere's your receipt:\n{labelTotalPrice.Text}\n(Already Paid!)");
            panelFeedback.Show();
            panelFeedback.BringToFront();
            label1.Text = "Welcome to ApexOn Sushi";
        }

        private void AfterFeedback(string feedback)
        {
            _dbService.SaveFeedback(_tableNumber, feedback);
            MessageBox.Show("Thank you and Welcome to ApexOn again!");
            label1.Text = "Menu Categories";
            panelFeedback.Hide();
            ResetSideBarButtonColor();
            button2.BackColor = Color.DimGray;
            panelSashimi.Show();
            panelSashimi.BringToFront();
            sidebarContainer.BringToFront();
            _orderSummary.Clear();
            listBoxOrderSummary.Items.Clear();
            panelbottom.Show();
            foreach (var item in _menuItems.Values)
            {
                item.Control.Text = "0";
            }
            labelTotalPrice.Text = "Total: $0.00";
            new k2().Show();
            this.Hide();
        }

        private void pictureBoxTooBad_Click(object sender, EventArgs e)
        {
            AfterFeedback("Too Bad");
        }

        private void pictureBoxBad_Click(object sender, EventArgs e)
        {
            AfterFeedback("Bad");
        }

        private void pictureBoxMedium_Click(object sender, EventArgs e)
        {
            AfterFeedback("Medium");
        }

        private void pictureBoxGood_Click(object sender, EventArgs e)
        {
            AfterFeedback("Good");
        }

        private void pictureBoxExcellent_Click(object sender, EventArgs e)
        {
            AfterFeedback("Excellent");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Program.customer.Show();
            this.Hide();
        }
    }
}
