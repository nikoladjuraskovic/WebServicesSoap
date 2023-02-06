using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceApp
{
    /// <summary>
    /// Summary description for mywebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class mywebservice : System.Web.Services.WebService
    {

        /*
         Namespace sluzi da na jedinstven nacin oznaci nas veb servis

        Web servis se pokrece kao i svaki web forms projekat.
        Kada se pokrene i klikne na service description izbaci WSDL dokument.
        WSDL(Web Services Description Language) je XML dokument koji sadrzi pravila komunikacije medju softverima.
        U njemu pisu mnogi detalji, npr. o metodima veb servisa, ime i tipovi argumenata i povratne vrednosti itd...
        Kada se klikne na metod Multiplication, mogu se videti XML poruke koje se salju SOAP-om.
        SOAP je Simple Object Access Protocol. 
        Ovako komuniciraju veb servis i veb aplikacija. Dakle, metod Multiplication se ne poziva kao 
        obican metod iz neke klase nego se poziva iz veb servisa i informacije o proizvodu i o unetim
        brojevima od strane korisnika u veb aplikaciji putuju izmedju veb aplikacije i veb servisa
        u XML formatu koristeci SOAP(Simple Object Access Protocol).
        Ova klasa u kojoj se nalazi metod Multiplication se zove proxy class(proksi klasa).


        SOAP je protokol tj. dogovor odnosno nacin komunikacije
        izmedju 2 aplikacije. Svaki veb servis koji ima ovaj protokol jeste SOAP veb servis.      
        Mi cemo raditi samo SOAP bazirane veb servise.
        Pristup koji koristimo je stariji tj. koristicemo XML Web Services.
        Docs: https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/ba0z6a33(v=vs.100)
        Microsoft na svojim stranicama preporucuje da se za ove tipove servisa koristi WCF(Windows Communication Foundation)
        Docs: https://learn.microsoft.com/en-us/dotnet/framework/wcf/whats-wcf
        Necemo raditi WCF.
        Generalno se danas u IT industriji najvise koriste REST bazirani servisi,
        a malo SOAP bazirani odnosno WCF bazirani jer su to starije tehnologije.

        Veb servisi takodje mogu imati REST protokol tj. mogu biti RESTful veb servisi.
        Ako zelite da napravite RESTful veb servise u .NET Framework-u onda kada pravite asp net projekat
        izaberite template WEB API. U .NET-u izaberete template ASP.NET Core Web API.
        To je novija tehnologija koja je danas dominantna u praksi(IT industriji), ne samo u ASP-u
        nego i u drugim jezicima kao sto su PHP i Node.js.


        Vratimo se na XML Web Services.
        BITNO!
        Da bi mogli da povezete vasu aplikaciju na ovaj veb servis, veb servis mora biti ONLINE tj. da radi tj.
        da je program pokrenut, zato otvorite aplikaciju i veb servis u dva posebna visual studija.

         */


        /*

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        */
        /*WebMethod mora da pise da mi neka aplikacija mogla da koristi ovaj veb servis tj. ovaj metod Multiplication.
         EnableSession = true da bi cuvali sesije tj. svako mnozenje odnosno svaki put kad je pozvan veb servis.
        Description je opis metode koji se vidi kada se pokrene veb servis.
        CacheDuration = 20 znaci da se rezultati metoda kesiraju 20 sekundi a to znaci da ako pozovemo metod
        veb servisa sa istim argumentima za manje od 20 sekundi nece se u GridView ispisati nova kalkulacija jer
        je ista kao prethodna. Ako prodje vise od 20 sekundi ili ako je razlicita kalkulacija(veb servis metod pozvan nad
        razlicitim argumentima) onda ce se dodati nova kalkulacija u GridView.*/
        [WebMethod(EnableSession =true, Description = "This method multiplies two numbers.", CacheDuration = 20)]
        public int Multiplication(int a, int b)
        {
            /*U listi cuvamo sve nase kalkulacije, tj. rezultate mnozenja svaki put kad je pozvan veb servis*/
            List<string> calculations;

            /*U Session objektu cuvamo racunanja(kalkulacije). Ako je prazan*/
            if (Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>(); // napravi novu listu
            } else
            {
                calculations = (List<string>)Session["CALCULATIONS"]; // ako ne, onda ubaci sesiju i konvertuj u listu stringova
            }

            //ispis racuna
            string strRecentCalculation = a.ToString() + " * " + b.ToString() + " = " + (a*b).ToString();

            //ubacimo u listu
            calculations.Add(strRecentCalculation);
            
            //dodela u objekat sesija
            Session["CALCULATIONS"] = calculations;



            return (a * b);
        }

        /*Method Overloading - kao u obicnoj C# klasi, tako je i ovde moguce imati metod overloading tj
         da dva metoda imaju isto ime ali razliciti potpis(razlicite argumente, povratnu vrednost itd...)
        Moramo navesti MessageName da bi se kod preveo.
        Takodje, iznad glavne klase moramo postaviti:
        [WebServiceBinding(ConformsTo = WsiProfiles.None)] umesto
        [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]*/

        [WebMethod(MessageName = "Adds 2 numbers")]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        [WebMethod(EnableSession =true)]
        public List<string> GetCalculations()
        {
            // ako je null, onda korisnik nije nista racunao tj. nije nijednom pozvan metod veb servisa
            if (Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations.");
                return calculations;

            }
            else
            {
                //vrati kalkulacije
                return (List<string>)Session["CALCULATIONS"];
            }
        }
    }
}
