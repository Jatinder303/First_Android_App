namespace First_Android_App;

[Activity(Label = "HomeScreen_Activity", MainLauncher = true)]
public class HomeScreen_Activity : Activity
{
    private EditText num1, num2, result;
    private Button add_btn, sub_btn, mul_btn, div_btn;
    private double number1, number2, result_number;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "Home Screen" layout resource
        SetContentView(Resource.Layout.HomeScreen);

        add_btn = FindViewById<Button>(Resource.Id.Btn_add);
        sub_btn = FindViewById<Button>(Resource.Id.Btn_sub);
        mul_btn = FindViewById<Button>(Resource.Id.Btn_Mutli);
        div_btn = FindViewById<Button>(Resource.Id.Btn_Div);
        num1 = FindViewById<EditText>(Resource.Id.Num1_TextBox);
        num2 = FindViewById<EditText>(Resource.Id.Num2_TextBox);
        result = FindViewById<EditText>(Resource.Id.Result_TextBox);


        add_btn.Click += Add_btn_Click;
    }

    private void Add_btn_Click(object? sender, EventArgs e)
    {
        number1 = Convert.ToInt32(num1.Text);
        number2 = Convert.ToInt32(num2.Text);
        result_number = number1 + number2;
        result.Text = result_number.ToString();
        
    }
}