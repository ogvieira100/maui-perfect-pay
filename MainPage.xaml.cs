namespace perfect_pay;

public partial class MainPage : ContentPage
{

    decimal grana = 0;
    int tip = 0;
    int noPersons = 1;

    public MainPage()
    {
        InitializeComponent();
    }

    private void txtgrana_Completed(object sender, EventArgs e)
    {

        if (decimal.TryParse(txtgrana.Text, out grana))
            CalcTotal();


    }

    private void CalcTotal()
    {
        var totalTip = (grana * tip) / 100;

        var tipPerson = (totalTip / noPersons);
        lblTipbyPerson.Text = $"{tipPerson:C}";

        var subTotal = (grana / noPersons);
        lblSubTotal.Text = $"{subTotal:C}";

        var totalByPerson = (grana + totalTip) / noPersons;

        lblTotal.Text = $"{totalByPerson:C}";
    }

    private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        tip = (int)sldTip.Value;
        lblTip.Text = $" Tip: {tip}% ";
        CalcTotal();
    }

  

    private void btn10_Clicked(object sender, EventArgs e)
    {
        sldTip.Value = 10d;
        CalcTotal();
    }

    private void btn15_Clicked(object sender, EventArgs e)
    {
        sldTip.Value = 15d;
        CalcTotal();
    }

    private void btn20_Clicked(object sender, EventArgs e)
    {
        sldTip.Value = 20d;
        CalcTotal();
    }

    private void btnMore_Clicked(object sender, EventArgs e)
    {

        noPersons++;

        lblNoPerson.Text = noPersons.ToString();
        CalcTotal();
    }

    private void btnMinus_Clicked(object sender, EventArgs e)
    {
        if (noPersons > 1)
            noPersons--;

        lblNoPerson.Text = noPersons.ToString();
        CalcTotal();

    }
}

