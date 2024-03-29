namespace Project
{
    using System.Timers;
    public partial class UserForm1 : Form
    {

        UserData user = Welcome.ActiveUser;
        List<VehicleDetails> userCars;
        Form form = null;
        private System.Timers.Timer timer;

        public UserForm1()
        {
            InitializeComponent();
        }

        private void UserForm1_Load(object sender, EventArgs e)
        {
            //example
            //VehicleDetails carEx = new VehicleDetails("123", "arjav@gmail.com", "benchi", "E12", "red", "Unparked");
            //ApplicationDB.vehicleDetails.Add(carEx);

            labelWelcomeUser.Text = $"Welcome {user.Firstname} {user.Lastname}";
            userCars = UserDB.CheckCar(user);
            LoadGridBox();
            timer = new Timer();
            timer.Interval = 2000; 
            timer.Elapsed += TimerElapsed; 
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    LoadGridBox();
                }));
            }
            else
            {
                LoadGridBox();
            }
        }

        public void LoadGridBox()
        {
            carGrid.Rows.Clear();
            foreach (var car in userCars)
            {
                carGrid.Rows.Add(
                    car.CarNo,
                    car.Brand,
                    car.Model,
                    car.Color,
                    car.Status);
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (form != null)
            {
                form.Close();
            }
            form = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void carGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CarNoSelected = carGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            VehicleDetails car = UserDB.CheckCarTransections(CarNoSelected);

            if (car.Status == "Unparked")
            {
                OpenChildForm(new UserEnterParking(car));
            }
            else if (car.Status == "Parked")
            {
                OpenChildForm(new UserPayFee(car));
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (timer != null)
            {
                timer.Stop(); // Stop the timer
                timer.Elapsed -= TimerElapsed; // Unsubscribe from the Elapsed event
                timer.Dispose(); // Dispose the timer
                timer = null; // Set timer to null
            }
        }
    }
}
