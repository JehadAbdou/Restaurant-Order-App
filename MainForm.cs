namespace Project
{
    public partial class Form1 : Form
    {

        private OrdersList ordersList;



        public Form1()
        {
            InitializeComponent();

            InitializeGUI();


        }

        private void InitializeGUI()
        {

            cmbSize.Items.AddRange(Enum.GetNames(typeof(PortinSize)));
            for (int i = 0; i < cmbSize.Items.Count; i++)
            {
                string SizeName = cmbSize.Items[i].ToString();
                SizeName = SizeName.Replace("_", " ");
                cmbSize.Items[i] = SizeName;
            }


            cmbSides.Items.AddRange(Enum.GetNames(typeof(Sides)));
            for (int i = 0; i < cmbSides.Items.Count; i++)
            {
                string SizeName = cmbSides.Items[i].ToString();
                SizeName = SizeName.Replace("_", " ");
                cmbSides.Items[i] = SizeName;
            }

            cmbDrinks.Items.AddRange(Enum.GetNames(typeof(Drinks)));
            for (int i = 0; i < cmbDrinks.Items.Count; i++)
            {
                string SizeName = cmbDrinks.Items[i].ToString();
                SizeName = SizeName.Replace("_", " ");
                cmbDrinks.Items[i] = SizeName;
            }

            cmbDesserts.Items.AddRange(Enum.GetNames(typeof(Desserts)));
            for (int i = 0; i < cmbDesserts.Items.Count; i++)
            {
                string SizeName = cmbDesserts.Items[i].ToString();
                SizeName = SizeName.Replace("_", " ");
                cmbDesserts.Items[i] = SizeName;
            }

            cmbDishes.Items.AddRange(Enum.GetNames(typeof(Dishes)));
            for (int i = 0; i < cmbDishes.Items.Count; i++)
            {
                string SizeName = cmbDishes.Items[i].ToString();
                SizeName = SizeName.Replace("_", " ");
                cmbDishes.Items[i] = SizeName;
            }


            ordersList = new OrdersList();

            lblClock.Text = string.Empty;



        }

        private void UpateGUI()
        {

            Calc();






        }





        private void Calc() //Calculating the Sum
        {

            int Count = 0;
            int sum = 0;

            foreach (Order order in ordersList.List)
            {
                if ((order.Count >= 1) && (order.Size == PortinSize.Large))
                {
                    Count += order.Count;
                    int C = 160 * order.Count;
                    sum += C;
                }

                else if ((order.Count >= 1) && (order.Size == PortinSize.Normal))
                {
                    Count += order.Count;
                    int C = 135 * order.Count;
                    sum += C;
                }

                else if ((order.Count >= 1) && (order.Size == PortinSize.Small))
                {
                    Count += order.Count;
                    int C = 115 * order.Count;
                    sum += C;
                }




            }


            lblCount.Text = Count.ToString();


            lblSum.Text = sum.ToString();


        }

        private bool ReadOrder() //Read the input from the user
        {
            bool ok = int.TryParse(txtNumOfPor.Text, out int count);

            if (ok)
            {
                Order order = new Order();
                order.Dessert = (Desserts)cmbDesserts.SelectedIndex;
                order.Side = (Sides)cmbSides.SelectedIndex;
                order.Drink = (Drinks)cmbDrinks.SelectedIndex;
                order.Dish = (Dishes)cmbDishes.SelectedIndex;
                order.Size = (PortinSize)cmbSize.SelectedIndex;
                order.Count = count;
                ordersList.AddOrder(order);
            }


            else
                MessageBox.Show("Give a valid number");






            return ok;



        }







        private void btnAdd_Click(object sender, EventArgs e) // Add an order the the List
        {

            if (ReadOrder())
            {
                UpateGUI();

                dataGridView1.DataSource = ordersList.List;

            }


        }

        private void btnCancel_Click(object sender, EventArgs e) // Remove an order
        {
            if (dataGridView1.Rows.Count > 0)
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int rowIndex = dataGridView1.SelectedRows[0].Index;


                    dataGridView1.Rows.RemoveAt(rowIndex);
                    ordersList.DelOrder(rowIndex);
                    Calc();


                }
                else
                {

                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Handle the case where no row is selected
                }
            }
            else
            {

                MessageBox.Show("There are no rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Handle the case where there are no rows in the DataGridView
            }
        }

        private void btnChange_Click(object sender, EventArgs e)//changing an item from the order
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];  //Read the selected cell


                if (selectedCell.ColumnIndex == GetDesiredColumnIndex("Dessert"))  //Change the Dessert
                {

                    object cellValue = selectedCell.Value;


                    if (cellValue != null)
                    {

                        string DessertValue = cmbDesserts.SelectedItem.ToString();



                        if (Enum.TryParse<Desserts>(DessertValue, out Desserts NewDessert))
                        {

                            selectedCell.Value = NewDessert;

                            dataGridView1.Refresh();
                        }


                    }
                }


                else if (selectedCell.ColumnIndex == GetDesiredColumnIndex("Side")) //Change the Side
                {
                    object cellValue = dataGridView1.SelectedCells[0];

                    if (cellValue != null)
                    {
                        string SideValue = cmbSides.SelectedItem.ToString();

                        if (Enum.TryParse<Sides>(SideValue, out Sides NewSide))
                        {

                            selectedCell.Value = SideValue;

                            dataGridView1.Refresh();
                        }




                    }



                }

                else if (selectedCell.ColumnIndex == GetDesiredColumnIndex("Drink")) //Change the Drink
                {
                    object cellValue = dataGridView1.SelectedCells[0];

                    if (cellValue != null)
                    {
                        string DrinkValue = cmbDrinks.SelectedItem.ToString();

                        if (Enum.TryParse<Drinks>(DrinkValue, out Drinks NewDrink))
                        {

                            selectedCell.Value = DrinkValue;

                            dataGridView1.Refresh();
                        }




                    }



                }


                else if (selectedCell.ColumnIndex == GetDesiredColumnIndex("Dish")) //change the Dish
                {
                    object cellValue = dataGridView1.SelectedCells[0];

                    if (cellValue != null)
                    {
                        string DishValue = cmbDishes.SelectedItem.ToString();

                        if (Enum.TryParse<Dishes>(DishValue, out Dishes NewDish))
                        {

                            selectedCell.Value = DishValue;

                            dataGridView1.Refresh();
                        }




                    }



                }


                else if (selectedCell.ColumnIndex == GetDesiredColumnIndex("Size"))  //Change the size 
                {
                    object cellValue = dataGridView1.SelectedCells[0];

                    if (cellValue != null)
                    {
                        string SizeValue = cmbSize.SelectedItem.ToString();

                        if (Enum.TryParse<PortinSize>(SizeValue, out PortinSize NewSize))
                        {

                            selectedCell.Value = SizeValue;

                            dataGridView1.Refresh();
                        }




                    }



                }


                else if (selectedCell.ColumnIndex == GetDesiredColumnIndex("Count"))  //Change the Num of portions
                {
                    object cellValue = dataGridView1.SelectedCells[0];

                    if (cellValue != null)
                    {
                        string CountValue = txtNumOfPor.Text;

                        if (int.TryParse(CountValue, out int NewCount))
                        {

                            selectedCell.Value = CountValue;

                            dataGridView1.Refresh();
                        }




                    }



                }




            }
            else
            {

                MessageBox.Show("No cells are selected.");// Handle case when no cells are selected
            }

        }








        private int GetDesiredColumnIndex(string columnName)  //Get the index of the Column
        {

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                if (column.Name == columnName)
                {

                    return column.Index;
                }
            }


            return -1;
        }







        private void btnDelete_Click(object sender, EventArgs e)// Deleteing an item from the order
        {
            DataGridViewCell SelectedCell = dataGridView1.SelectedCells[0];
            int columnIndex = SelectedCell.ColumnIndex;

            if (dataGridView1.Columns[columnIndex].Name != "Count")
                SelectedCell.Value = null;


        }




        private void btnConfirm_Click(object sender, EventArgs e)//Confirm the order
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult dlg = MessageBox.Show("Confirm purshess?", "Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlg == DialogResult.OK)
                {
                    Timer timer = new Timer();
                    timer.ShowDialog();

                    ordersList = new OrdersList();
                    dataGridView1.Rows.Clear();

                    dataGridView1.DataSource = null;

                }

            }
            else
                MessageBox.Show("Your order list is empty... \nPlease add an order to the list", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongDateString();
            lblClock.Text += " " + DateTime.Now.ToLongTimeString();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
