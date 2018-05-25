using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public  class Payment : CatalogBase
	{
	    #region Instance fields

        private string _navn;
	    private string _adresse;
	    private int _postnummer;
	    private string _emailAdresse;
	    private int _telefonnummer;
	    private int _kortnummer;
	    private int _udløbsDato;
	    private int _cvv;

	    #endregion

        #region Constructor

        public Payment(string navn, string adresse, int postnummer, string emailAdresse, int telefonnummer, int kortnummer,
	        int udløbsdato, int cvv)
	    {
	        _navn = navn;
	        _adresse = adresse;
	        _postnummer = postnummer;
	        _emailAdresse = emailAdresse;
	        _telefonnummer = telefonnummer;
	        _kortnummer = kortnummer;
	        _udløbsdato = udløbsdato;
	        _cvv = cvv;
	    }

        #endregion

	    #region Properties

        public override string Navn
	    {
	        get { return _navn; }
	        set { _navn = value; }
        }

	    public override string Adresse
	    {
	        get { return _adresse; }
	        set { _adresse = value; }
        }

	    public override int Postnummer
	    {
	        get { return _postnummer; }
	        set { _postnummer = value; }
        }

	    public override string EmailAdresse
	    {
	        get { return _emailAdresse; }
	        set { _emailAdresse = value; }
        }

	    public override int Telefonnummer
	    {
	        get { return _telefonnummer; }
	        set { _telefonnummer = value; }
        }

	    public override int Kortnummer
	    {
	        get { return _kortnummer; }
	        set { _kortnummer = value; }
        }

	    public override int Udløbsdato
	    {
	        get { return _udløbsdato; }
	        set { _udløbsdato = value; }
        }

	    public override int Cvv
	    {
	        get { return _cvv; }
	        set { _cvv = value; }
        }

	    #endregion
    }
}
