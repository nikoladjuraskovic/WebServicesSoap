using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebService
{
    public partial class WebServicePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         * Veb servis se dodaje veb aplikaciji na sledeci nacin:
         * U solution Explorer-u:
         * 1. nacin
         * Desni klik na ime projekta, zatim Add -> Service Reference i upise URl vaseg veb servisa u adress. Zatim klikne Go i onda Ok.
         * Preporucujem 1. nacin i tako cemo raditi zbog neceg kasnije sto nam treba sto ne radi ako uradite na 2. nacin
         * 
         * 2. nacin
         * Desni klik na Add -> Service Reference -> Advanced -> Add Web Reference.
         * 
         * Zatim se u URL upise adresa veb servisa. Za nas veb servis adresa je ona koja
         * pise kao url veb servisa kada se pokrene u Visual Studiju. Upamtite,
         * da biste koristili veb servis on mora biti ONLINE tj. na mrezi, tj. ako je nas
         * onda MORA biti POKRENUT.
         * 
         * 
         * 
         Klikom na dugme se poziva i instancira veb servis koji smo prethodno dodali u projekat.
        I poziva se njegov metod za mnozenje dva broja koji to i uspesno radi.
        Web strana ima svoj UI(User Interface) na .aspx preko kojeg korisnik koristi veb servis.
        BITNO!
        Ovo nije obicno pozivanje metode iz neke druge klase, vec ovde imamo komunikaciju dve aplikacije:
        nase web aplikacije i veb servisa. One medjusobno komuniciraju koristeci SOAP(Simple Object Access Protocol).
        Preko SOAP-a salju podatke medjusobno u XML formatu. Kada se pokrene veb servis, vide se te SOAP pouruke.
        U XML formatu se veb servisu izmedju ostalog salju dva broja koje je korisnik uneo kao i njihov tip podatka.
        U veb servisu se pretvaraju u .NET integer-e i onda se izracuna proizvod. Nakon toga, opet SOAP-om se u XML
        formatu salju ti podaci nazada na veb aplikaciju, u ovom slucaju proizvod i opet konvertuju iz XML u .NET integer
        i tek onda se ispisuje rezultat na veb strani. Konvertovanje podataka iz .NET tipova(Integer, ...) u XMl podatke
        zove SERIJALIZACIJA(SERIALIZATION). A pretvaranja iz XML formata nazad u .NET tipove(Integer, ...) se zove DESERIJALIZACIJA.
        Koriscenje veb servisa od strane aplikacije se zove: consuming a web service.

        BITNO!
        Da bi mogli da povezete vasu aplikaciju na veb servis, veb servis mora biti ONLINE tj. da radi tj.
        da je program pokrenut, zato otvorite aplikaciju i veb servis u dva posebna visual studija.

        PRIMETIMO DA:
        Rekli smo da API-ji tj. veb servisi se povezuju na aplikacije i rekli smo zasto.
        Bitno je primetiti da se api moze povezati i na desktop aplikaciju tj.
        mozete .asmx veb servis povezati sa vasom C# Console ili Windows Forms aplikacijom takode.


         */

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*instanciramo servis*/
            ServiceReference1.mywebserviceSoapClient service = new ServiceReference1.mywebserviceSoapClient();
            
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            
            int c = service.Multiplication(a, b); // pozivamo metod servisa koji mnozi dva broja
            TextBox3.Text = c.ToString();

            /*metod GetCalculations se ne moze pozvati odmah nad service objektom, ne vidi ga.
             Zato se mora kliknuti u solution explorer-u desnim klikom na Connected Services -> ServiceReference1 i kliknuti na
            Update Service Reference i to dok veb servis radi, tj. dok je pokrenut program.
            Nakon toga, GetCalculations moze biti pozvan.*/
            GridViewCalculations.DataSource =  service.GetCalculations();
            GridViewCalculations.DataBind();

            GridViewCalculations.HeaderRow.Cells[0].Text = "CALCULATIONS"; // naslov GridView-a.

            /*medjutim, GridView se ne azurira, tj. ne ispisuje nase kalkulacije.
             Veb aplikacija ne salje isti Session ID veb servisu.
            Treba uci u Web.config i podesiti u system.serviceModel -> bindings ->basicHttpBinding -> binding i podesiti allowCookies="true".           
            Ovim se odrzava ista sesija izmedju klijenta i veb servisa i  cuvaju se sve kalkulacije i beleze u GridView.*/

            
            /*
             Nakon svakog azuriranja veb servisa, potrebno ga je pokrenuti, a zatim u veb aplikaciji koja ga poziva,
            kliknuti desnim klikom na Conected Services -> ServiceReference1 i kliknuti na Update Service Reference.
             */

            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            /*
             * Veb servise ne moramo uvek mi praviti, postoje takodje i gotovi veb servisi
             * koje mi mozemo koristiti i to su takozvani javni dostupni veb servisi(free public APIs).
             * Mozemo samo koristiti javno dostupne sto znaci da postoje i oni koji nisu javno dostupni.
             * Dakle API(Web Service) moze biti public(javno dostupan) ili private(nije javno dostupan) tj.
             * ne moze mu svako pristupiti tj. potrebna je autentifikacija tj. logovanje na neki nalog.
             * Takodje, API-ji mogu biti besplatni i mogu biti placeni.
             * Javne API-je mozete pronaci na sledecim adresama:
             * https://any-api.com/
             * https://rapidapi.com/collection/list-of-free-apis
             * https://github.com/public-apis/public-apis
             * https://github.com/toddmotto/public-apis
             * 
             * Na mnoge od ovih necete moci da se povezete jer su oni RESTful veb servisi,
             * a ovom tehnologijom se mozemo povezati samo na SOAP bazirane veb servise.
             * Mozete npr. da skinete program Postman koji vas moze povezati na neke od tih veb servisa.
             * postman: https://www.postman.com/downloads/
             * Video tutorial o REST Apiju i postman-om: https://www.youtube.com/watch?v=Q-BpqyOT3a8
             * Primer takvog imate dole, u pitanju je jedan kalkulator.
             * Mozete da probate da nadjete jos neki kucanjem: soap web services
             * Mora da ima ekstenziju .asmx da bi se povezalo na nasu veb aplikaciju.
             * 
             * 
             Povezali smo se na javno dostupni web servis:
            http://www.dneonline.com/calculator.asmx

            Njega dodajete na isti nacin kao i vas veb servis.
            Desni klik na ime projekta, zatim Add i Service Reference... i u Adress upiste gornju adresu i kliknete Go.

            Mozete se povezati i na ovaj servis:
            https://ecs.syr.edu/faculty/fawcett/Handouts/cse775/code/calcWebService/Calc.asmx

             */




            /*dohvatamo servis i instanciramo kao klasu.
             Klasa ima odredjene metode koje mozemo videti u Visual Studiju ili u browseru kada kliknemo na veb servis.*/

            ServiceReference2.CalculatorSoapClient calculator = new ServiceReference2.CalculatorSoapClient();

            /*pozivamo metod Subtract veb servisa sa argumentima i ispisujemo rezultat na nasoj veb strani.*/

            Label4.Text += calculator.Subtract(5, 3).ToString();

            /*Domaci, napraviti web formu koja unosi 2 broja kao argumente i bira operacije racunanja koje podrzava veb servis*/
        }
    }
}