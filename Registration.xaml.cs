using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SecureText
{

    public partial class Registration : PhoneApplicationPage
    {
        public Registration()
        {
            InitializeComponent();

            List<Country1> l = new List<Country1>();
            #region populateCountries
            l.Add(new Country1() { Country = "Afghanistan", Code = " (+93) " });
            l.Add(new Country1() { Country = "Albania", Code = " (+355) " });
            l.Add(new Country1() { Country = "Algeria", Code = " (+213) " });
            l.Add(new Country1() { Country = "American Samoa", Code = " (+1) " });
            l.Add(new Country1() { Country = "Andorra", Code = " (+376) " });
            l.Add(new Country1() { Country = "Angola", Code = " (+244) " });
            l.Add(new Country1() { Country = "Anguilla", Code = " (+1) " });
            l.Add(new Country1() { Country = "Antigua and Barbuda", Code = " (+1) " });
            l.Add(new Country1() { Country = "Argentina", Code = " (+54) " });
            l.Add(new Country1() { Country = "Armenia", Code = " (+374) " });
            l.Add(new Country1() { Country = "Aruba", Code = " (+297) " });
            l.Add(new Country1() { Country = "Ascension", Code = " (+247) " });
            l.Add(new Country1() { Country = "Australia", Code = " (+61) " });
            l.Add(new Country1() { Country = "Austria", Code = " (+43) " });
            l.Add(new Country1() { Country = "Azerbaijan", Code = " (+994) " });
            l.Add(new Country1() { Country = "Bahamas", Code = " (+1) " });
            l.Add(new Country1() { Country = "Bahrain", Code = " (+973) " });
            l.Add(new Country1() { Country = "Bangladesh", Code = " (+880) " });
            l.Add(new Country1() { Country = "Barbados", Code = " (+1) " });
            l.Add(new Country1() { Country = "Belarus", Code = " (+375) " });
            l.Add(new Country1() { Country = "Belgium", Code = " (+32) " });
            l.Add(new Country1() { Country = "Belize", Code = " (+501) " });
            l.Add(new Country1() { Country = "Benin", Code = " (+229) " });
            l.Add(new Country1() { Country = "Bermuda", Code = " (+1) " });
            l.Add(new Country1() { Country = "Bhutan", Code = " (+975) " });
            l.Add(new Country1() { Country = "Bolivia", Code = " (+591) " });
            l.Add(new Country1() { Country = "Bosnia and Herzegovina", Code = " (+387) " });
            l.Add(new Country1() { Country = "Botswana", Code = " (+267) " });
            l.Add(new Country1() { Country = "Brazil", Code = " (+55) " });            
            l.Add(new Country1() { Country = "British Virgin Islands", Code = " (+1) " });
            l.Add(new Country1() { Country = "Brunei", Code = " (+673) " });
            l.Add(new Country1() { Country = "Bulgaria", Code = " (+359) " });
            l.Add(new Country1() { Country = "Burkina Faso", Code = " (+226) " });
            l.Add(new Country1() { Country = "Burundi", Code = " (+257) " });
            l.Add(new Country1() { Country = "Cambodia", Code = " (+855) " });
            l.Add(new Country1() { Country = "Cameroon", Code = " (+237) " });
            l.Add(new Country1() { Country = "Canada", Code = " (+1) " });
            l.Add(new Country1() { Country = "Cape Verde", Code = " (+238) " });
            l.Add(new Country1() { Country = "Cayman Islands", Code = " (+1) " });
            l.Add(new Country1() { Country = "Central African Republic", Code = " (+236) " });
            l.Add(new Country1() { Country = "Chad", Code = " (+235) " });
            l.Add(new Country1() { Country = "Chile", Code = " (+56) " });
            l.Add(new Country1() { Country = "China", Code = " (+86) " });
            l.Add(new Country1() { Country = "Colombia", Code = " (+57) " });
            l.Add(new Country1() { Country = "Comoros", Code = " (+269) " });
            l.Add(new Country1() { Country = "Congo", Code = " (+242) " });
            l.Add(new Country1() { Country = "Cook Islands", Code = " (+682) " });
            l.Add(new Country1() { Country = "Costa Rica", Code = " (+506) " });
            l.Add(new Country1() { Country = "Croatia", Code = " (+385) " });
            l.Add(new Country1() { Country = "Cuba", Code = " (+53) " });
            l.Add(new Country1() { Country = "Curacao", Code = " (+599) " });
            l.Add(new Country1() { Country = "Cyprus", Code = " (+357) " });
            l.Add(new Country1() { Country = "Czech Republic", Code = " (+420) " });
            l.Add(new Country1() { Country = "Democratic Republic of Congo", Code = " (+243) " });
            l.Add(new Country1() { Country = "Denmark", Code = " (+45) " });
            l.Add(new Country1() { Country = "Diego Garcia", Code = " (+246) " });
            l.Add(new Country1() { Country = "Djibouti", Code = " (+253) " });
            l.Add(new Country1() { Country = "Dominica", Code = " (+1) " });
            l.Add(new Country1() { Country = "Dominican Republic", Code = " (+1) " });
            l.Add(new Country1() { Country = "East Timor", Code = " (+670) " });
            l.Add(new Country1() { Country = "Ecuador", Code = " (+593) " });
            l.Add(new Country1() { Country = "Egypt", Code = " (+20) " });
            l.Add(new Country1() { Country = "El Salvador", Code = " (+503) " });
            l.Add(new Country1() { Country = "Equatorial Guinea", Code = " (+240) " });
            l.Add(new Country1() { Country = "Eritrea", Code = " (+291) " });
            l.Add(new Country1() { Country = "Estonia", Code = " (+372) " });
            l.Add(new Country1() { Country = "Ethiopia", Code = " (+251) " });
            l.Add(new Country1() { Country = "Falkland (Malvinas) Islands", Code = " (+500) " });
            l.Add(new Country1() { Country = "Faroe Islands", Code = " (+298) " });
            l.Add(new Country1() { Country = "Fiji", Code = " (+679) " });
            l.Add(new Country1() { Country = "Finland", Code = " (+358) " });
            l.Add(new Country1() { Country = "France", Code = " (+33) " });
            l.Add(new Country1() { Country = "French Guiana", Code = " (+594) " });
            l.Add(new Country1() { Country = "French Polynesia", Code = " (+689) " });
            l.Add(new Country1() { Country = "Gabon", Code = " (+241) " });
            l.Add(new Country1() { Country = "Gambia", Code = " (+220) " });
            l.Add(new Country1() { Country = "Georgia", Code = " (+995) " });
            l.Add(new Country1() { Country = "Germany", Code = " (+49) " });
            l.Add(new Country1() { Country = "Ghana", Code = " (+233) " });
            l.Add(new Country1() { Country = "Gibraltar", Code = " (+350) " });
            l.Add(new Country1() { Country = "Greece", Code = " (+30) " });
            l.Add(new Country1() { Country = "Greenland", Code = " (+299) " });
            l.Add(new Country1() { Country = "Grenada", Code = " (+1) " });
            l.Add(new Country1() { Country = "Guadeloupe", Code = " (+590) " });
            l.Add(new Country1() { Country = "Guam", Code = " (+1) " });
            l.Add(new Country1() { Country = "Guatemala", Code = " (+502) " });
            l.Add(new Country1() { Country = "Guinea", Code = " (+224) " });
            l.Add(new Country1() { Country = "Guinea-Bissau", Code = " (+245) " });
            l.Add(new Country1() { Country = "Guyana", Code = " (+592) " });
            l.Add(new Country1() { Country = "Haiti", Code = " (+509) " });
            l.Add(new Country1() { Country = "Honduras", Code = " (+504) " });
            l.Add(new Country1() { Country = "Hong Kong", Code = " (+852) " });
            l.Add(new Country1() { Country = "Hungary", Code = " (+36) " });
            l.Add(new Country1() { Country = "Iceland", Code = " (+354) " });
            l.Add(new Country1() { Country = "India", Code = " (+91) " });
            l.Add(new Country1() { Country = "Indonesia", Code = " (+62) " });
            l.Add(new Country1() { Country = "Iran", Code = " (+98) " });
            l.Add(new Country1() { Country = "Iraq", Code = " (+964) " });
            l.Add(new Country1() { Country = "Ireland", Code = " (+353) " });
            l.Add(new Country1() { Country = "Israel", Code = " (+972) " });
            l.Add(new Country1() { Country = "Italy", Code = " (+39) " });
            l.Add(new Country1() { Country = "Ivory Coast", Code = " (+225) " });
            l.Add(new Country1() { Country = "Jamaica", Code = " (+1) " });
            l.Add(new Country1() { Country = "Japan", Code = " (+81) " });
            l.Add(new Country1() { Country = "Jordan", Code = " (+962) " });
            l.Add(new Country1() { Country = "Kazakhstan", Code = " (+7) " });
            l.Add(new Country1() { Country = "Kenya", Code = " (+254) " });
            l.Add(new Country1() { Country = "Kiribati", Code = " (+686) " });
            l.Add(new Country1() { Country = "Kuwait", Code = " (+965) " });
            l.Add(new Country1() { Country = "Kyrgyzstan", Code = " (+996) " });
            l.Add(new Country1() { Country = "Laos", Code = " (+856) " });
            l.Add(new Country1() { Country = "Latvia", Code = " (+371) " });
            l.Add(new Country1() { Country = "Lebanon", Code = " (+961) " });
            l.Add(new Country1() { Country = "Lesotho", Code = " (+266) " });
            l.Add(new Country1() { Country = "Liberia", Code = " (+231) " });
            l.Add(new Country1() { Country = "Libya", Code = " (+218) " });
            l.Add(new Country1() { Country = "Liechtenstein", Code = " (+423) " });
            l.Add(new Country1() { Country = "Lithuania", Code = " (+370) " });
            l.Add(new Country1() { Country = "Luxembourg", Code = " (+352) " });
            l.Add(new Country1() { Country = "Macau", Code = " (+853) " });
            l.Add(new Country1() { Country = "Macedonia", Code = " (+389) " });
            l.Add(new Country1() { Country = "Madagascar", Code = " (+261) " });
            l.Add(new Country1() { Country = "Malawi", Code = " (+265) " });
            l.Add(new Country1() { Country = "Malaysia", Code = " (+60) " });
            l.Add(new Country1() { Country = "Maldives", Code = " (+960) " });
            l.Add(new Country1() { Country = "Mali", Code = " (+223) " });
            l.Add(new Country1() { Country = "Malta", Code = " (+356) " });
            l.Add(new Country1() { Country = "Marshall Islands", Code = " (+692) " });
            l.Add(new Country1() { Country = "Martinique", Code = " (+596) " });
            l.Add(new Country1() { Country = "Mauritania", Code = " (+222) " });
            l.Add(new Country1() { Country = "Mauritius", Code = " (+230) " });
            l.Add(new Country1() { Country = "Mayotte", Code = " (+262) " });
            l.Add(new Country1() { Country = "Mexico", Code = " (+52) " });
            l.Add(new Country1() { Country = "Micronesia", Code = " (+691) " });
            l.Add(new Country1() { Country = "Moldova", Code = " (+373) " });
            l.Add(new Country1() { Country = "Monaco", Code = " (+377) " });
            l.Add(new Country1() { Country = "Mongolia", Code = " (+976) " });
            l.Add(new Country1() { Country = "Montenegro", Code = " (+382) " });
            l.Add(new Country1() { Country = "Montserrat", Code = " (+1) " });
            l.Add(new Country1() { Country = "Morocco", Code = " (+212) " });
            l.Add(new Country1() { Country = "Mozambique", Code = " (+258) " });
            l.Add(new Country1() { Country = "Myanmar", Code = " (+95) " });
            l.Add(new Country1() { Country = "Namibia", Code = " (+264) " });
            l.Add(new Country1() { Country = "Nauru", Code = " (+674) " });
            l.Add(new Country1() { Country = "Nepal", Code = " (+977) " });
            l.Add(new Country1() { Country = "Netherlands", Code = " (+31) " });
            l.Add(new Country1() { Country = "Netherlands Antilles", Code = " (+599) " });
            l.Add(new Country1() { Country = "New Caledonia", Code = " (+687) " });
            l.Add(new Country1() { Country = "New Zealand", Code = " (+64) " });
            l.Add(new Country1() { Country = "Nicaragua", Code = " (+505) " });
            l.Add(new Country1() { Country = "Niger", Code = " (+227) " });
            l.Add(new Country1() { Country = "Nigeria", Code = " (+234) " });
            l.Add(new Country1() { Country = "Niue", Code = " (+683) " });
            l.Add(new Country1() { Country = "Norfolk Island", Code = " (+6723) " });
            l.Add(new Country1() { Country = "North Korea", Code = " (+850) " });
            l.Add(new Country1() { Country = "Northern Marianas", Code = " (+1) " });
            l.Add(new Country1() { Country = "Norway", Code = " (+47) " });
            l.Add(new Country1() { Country = "Oman", Code = " (+968) " });
            l.Add(new Country1() { Country = "Pakistan", Code = " (+92) " });
            l.Add(new Country1() { Country = "Palau", Code = " (+680) " });
            l.Add(new Country1() { Country = "Panama", Code = " (+507) " });
            l.Add(new Country1() { Country = "Papua New Guinea", Code = " (+675) " });
            l.Add(new Country1() { Country = "Paraguay", Code = " (+595) " });
            l.Add(new Country1() { Country = "Peru", Code = " (+51) " });
            l.Add(new Country1() { Country = "Philippines", Code = " (+63) " });
            l.Add(new Country1() { Country = "Poland", Code = " (+48) " });
            l.Add(new Country1() { Country = "Portugal", Code = " (+351) " });
            l.Add(new Country1() { Country = "Puerto Rico", Code = " (+1) " });
            l.Add(new Country1() { Country = "Qatar", Code = " (+974) " });
            l.Add(new Country1() { Country = "Reunion", Code = " (+262) " });
            l.Add(new Country1() { Country = "Romania", Code = " (+40) " });
            l.Add(new Country1() { Country = "Russian Federation", Code = " (+7) " });
            l.Add(new Country1() { Country = "Rwanda", Code = " (+250) " });
            l.Add(new Country1() { Country = "Saint Helena", Code = " (+290) " });
            l.Add(new Country1() { Country = "Saint Kitts and Nevis", Code = " (+1) " });
            l.Add(new Country1() { Country = "Saint Lucia", Code = " (+1) " });
            l.Add(new Country1() { Country = "Saint Pierre and Miquelon", Code = " (+508) " });
            l.Add(new Country1() { Country = "Saint Vincent and the Grenadines", Code = " (+1) " });
            l.Add(new Country1() { Country = "Samoa", Code = " (+685) " });
            l.Add(new Country1() { Country = "San Marino", Code = " (+378) " });
            l.Add(new Country1() { Country = "Sao Tome and Principe", Code = " (+239) " });
            l.Add(new Country1() { Country = "Saudi Arabia", Code = " (+966) " });
            l.Add(new Country1() { Country = "Senegal", Code = " (+221) " });
            l.Add(new Country1() { Country = "Serbia", Code = " (+381) " });
            l.Add(new Country1() { Country = "Seychelles", Code = " (+248) " });
            l.Add(new Country1() { Country = "Sierra Leone", Code = " (+232) " });
            l.Add(new Country1() { Country = "Singapore", Code = " (+65) " });
            l.Add(new Country1() { Country = "Sint Maarten", Code = " (+1) " });
            l.Add(new Country1() { Country = "Slovakia", Code = " (+421) " });
            l.Add(new Country1() { Country = "Slovenia", Code = " (+386) " });
            l.Add(new Country1() { Country = "Solomon Islands", Code = " (+677) " });
            l.Add(new Country1() { Country = "Somalia", Code = " (+252) " });
            l.Add(new Country1() { Country = "South Africa", Code = " (+27) " });
            l.Add(new Country1() { Country = "South Korea", Code = " (+82) " });
            l.Add(new Country1() { Country = "South Sudan", Code = " (+211) " });
            l.Add(new Country1() { Country = "Spain", Code = " (+34) " });
            l.Add(new Country1() { Country = "Sri Lanka", Code = " (+94) " });
            l.Add(new Country1() { Country = "Sudan", Code = " (+249) " });
            l.Add(new Country1() { Country = "Suriname", Code = " (+597) " });
            l.Add(new Country1() { Country = "Swaziland", Code = " (+268) " });
            l.Add(new Country1() { Country = "Sweden", Code = " (+46) " });
            l.Add(new Country1() { Country = "Switzerland", Code = " (+41) " });
            l.Add(new Country1() { Country = "Syria", Code = " (+963) " });
            l.Add(new Country1() { Country = "Taiwan", Code = " (+886) " });
            l.Add(new Country1() { Country = "Tajikistan", Code = " (+992) " });
            l.Add(new Country1() { Country = "Tanzania", Code = " (+255) " });
            l.Add(new Country1() { Country = "Thailand", Code = " (+66) " });
            l.Add(new Country1() { Country = "Thuraya Satellite", Code = " (+882 16) " });
            l.Add(new Country1() { Country = "Togo", Code = " (+228) " });
            l.Add(new Country1() { Country = "Tokelau", Code = " (+690) " });
            l.Add(new Country1() { Country = "Tonga", Code = " (+676) " });
            l.Add(new Country1() { Country = "Trinidad and Tobago", Code = " (+1) " });
            l.Add(new Country1() { Country = "Tunisia", Code = " (+216) " });
            l.Add(new Country1() { Country = "Turkey", Code = " (+90) " });
            l.Add(new Country1() { Country = "Turkmenistan", Code = " (+993) " });
            l.Add(new Country1() { Country = "Turks and Caicos Islands", Code = " (+1) " });
            l.Add(new Country1() { Country = "Tuvalu", Code = " (+688) " });
            l.Add(new Country1() { Country = "Uganda", Code = " (+256) " });
            l.Add(new Country1() { Country = "Ukraine", Code = " (+380) " });
            l.Add(new Country1() { Country = "United Arab Emirates", Code = " (+971) " });
            l.Add(new Country1() { Country = "United Kingdom", Code = " (+44) " });
            l.Add(new Country1() { Country = "United States of America", Code = " (+1) " });
            l.Add(new Country1() { Country = "U.S. Virgin Islands", Code = " (+1) " });
            l.Add(new Country1() { Country = "Uruguay", Code = " (+598) " });
            l.Add(new Country1() { Country = "Uzbekistan", Code = " (+998) " });
            l.Add(new Country1() { Country = "Vanuatu", Code = " (+678) " });
            l.Add(new Country1() { Country = "Vatican City", Code = " (+379) " });
            l.Add(new Country1() { Country = "Venezuela", Code = " (+58) " });
            l.Add(new Country1() { Country = "Vietnam", Code = " (+84) " });
            l.Add(new Country1() { Country = "Wallis and Futuna", Code = " (+681) " });
            l.Add(new Country1() { Country = "Yemen", Code = " (+967) " });
            l.Add(new Country1() { Country = "Zambia", Code = " (+260) " });
            l.Add(new Country1() { Country = "Zimbabwe", Code = " (+263) " });
            #endregion

            var cityByCountry = from item in l
                                group item by item.Country[0].ToString() into c
                                orderby c.Key
                                select new Group<Country1>(c.Key, c);

            this.citiesListGropus.ItemsSource = cityByCountry;
            //this.countryPicker.ItemsSource = l; 

            setInputScope(phoneNumber);
       
        }

        public void setInputScope(TextBox t)
        {
            InputScopeNameValue numeric = InputScopeNameValue.Number;
            t.InputScope = new InputScope() { 
                Names = { new InputScopeName() { NameValue = numeric } } 
            };
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Country1 sel = (Country1)citiesListGropus.SelectedItem;
            App.curCoun = sel;
            App.phoneNumber = phoneNumber.Text;
            NavigationService.Navigate(new Uri("/Verification.xaml", UriKind.Relative));
        }   
    }

    

    public class Group<T> : IEnumerable<T>
    {
        public Group(string name, IEnumerable<T> items)
        {
            this.Title = name;
            this.Items = new List<T>(items);
        }

        public override bool Equals(object obj)
        {
            Group<T> that = obj as Group<T>;

            return (that != null) && (this.Title.Equals(that.Title));
        }

        public string Title
        {
            get;
            set;
        }

        public IList<T> Items
        {
            get;
            set;
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        #endregion
    }
}